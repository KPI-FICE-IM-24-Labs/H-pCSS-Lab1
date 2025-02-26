// Data class
using System.Text;

public static class Data {

    // Math methods

    // Substract two vectors and return the result vector
    public static int[] substractVectors(int[] vectorA, int[] vectorB) {
        int vectorLength = vectorA.Length;
        int[] resultVector = new int[vectorLength];    
    
        for (int i = 0; i < vectorLength; i++) {
            resultVector[i] = vectorA[i] - vectorB[i];
        }
        return resultVector;
    }

    // Multiply vector by matrix and return the result vector
    public static int[] multiplyVectorByMatrix(int[] vectorA, int[,] matrix) {
        int vectorLength = vectorA.Length;
        int[] resultVector = new int[vectorLength];
        
        for (int i = 0; i < vectorLength; i++) {
            for (int j = 0; j < vectorLength; j++) {
                resultVector[i] += vectorA[i] * matrix[j, i];
            }
        }
        return resultVector;
    }

    // Multiply matrix by matrix and return the result matrix
    public static int[,] multiplyMatrixByMatrix(int[,] matrixA, int[,] matrixB) {
        int matrixLength = matrixA.GetLength(0);
        int[,] resultMatrix = new int[matrixLength, matrixLength];

        for (int i = 0; i < matrixLength; i++) {
            for (int j = 0; j < matrixLength; j++) {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < matrixLength; k++) {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return resultMatrix;
    }

    // Multiply matrix by scalar and return the result matrix
    public static int[,] multiplyMatrixByScalar(int[,] matrix, int scalar) {
        int matrixLength = matrix.GetLength(0);
        int[,] resultMatrix = new int[matrixLength, matrixLength];

        for (int i = 0; i < matrixLength; i++) {
            for (int j = 0; j < matrixLength; j++) {
                resultMatrix[i, j] = scalar * matrix[i, j];
            }
        }
        return resultMatrix;
    }

    // Multiply vector by scalar and return the result vector
    public static int[] multiplyVectorbyScalar(int[] vector, int scalar) {
        int vectorLength = vector.Length;
        int[] resultVector = new int[vectorLength];

        for (int i = 0; i < vectorLength; i++) {
            resultVector[i] = vector[i] * scalar;
        }
        return resultVector;
    }

    // Get max element from matrix and return it
    public static int findMatrixMaxElement(int[,] matrix) {
        int matrixLength = matrix.GetLength(0);
        int max = matrix[0, 0];

        for (int i = 0; i < matrixLength; i++) {
            for (int j = 0; j < matrixLength; j++) {
                int currentElement = matrix[i, j];
                if (currentElement > max) {
                    max = currentElement;
                }
            }
        }
        return max;
    }

    // Sort matrix lines and return the sorted matrix
    public static int[,] sortMatrixLines(int[,] matrix) {
        int matrixLength = matrix.GetLength(0);
        int[,] sortedMatrix = new int[matrixLength, matrixLength];

        for (int i = 0; i < matrixLength; i++) {
            int[] row = new int[matrixLength];

            for (int j = 0; j < matrixLength; j++) {
                row[j] = matrix[i, j];
            }

            Array.Sort(row);

            for (int j = 0; j < matrixLength; j++) {
                sortedMatrix[i, j] = row[j];
            }
        }
        return sortedMatrix;
    }

    // Matrix and vector fill methods

    // Fill values for the first expression C = A - B * (MA * MC) * e with defined or random value
    public static void fillFirstExpressionValues(int matrixLength, int value, int[] vectorA, int[] vectorB, int[,] matrixMA, int[,] matrixMC) {
        for (int i = 0; i < matrixLength; i++) {
            vectorA[i] = value;
            vectorB[i] = value;
            
            for (int j = 0; j < matrixLength; j++) {
                matrixMA[i, j] = value;
                matrixMC[i, j] = value;
            }
        }
    } 

    // Fill values for the second expression MG = MAX(MH) * (MK * ML)
    public static void fillSecondExpressionValues(int matrixLength, int value, int[,] matrixMH, int[,] matrixMK, int[,] matrixML) {
        for (int i = 0; i < matrixLength; i++) {
            for (int j = 0; j < matrixLength; j++) {
                matrixMH[i, j] = value;
                matrixMK[i, j] = value;
                matrixML[i, j] = value;
            }
        }
    }

    // Fill values for the third expression O = SORT(MP * MR) * S with defined or random values to check sort  operation
    public static void fillThirdExpressionValues(int matrixLength, int[,] matrixMP, int[,] matrixMR, int[] vectorS, int value = -1) {
        Random random = new Random();
        
        for (int i = 0; i < matrixLength; i++) {
            value = (value == -1) ? random.Next(1, 10) : value; // If no value provided use random one
            vectorS[i] = value;

            for (int j = 0; j < matrixLength; j++) {
                value = (value == -1) ? random.Next(1, 10) : value; // If no value provided use random one
                matrixMP[i, j] = value;

                value = (value == -1) ? random.Next(1, 10) : value; // If no value provided use random one
                matrixMR[i, j] = value;
            }
        }
    }

    // Matrix and vector convertion to string methods

    // Vector to string
    public static string toString(string dataName, int[] vector) {
        return dataName + ": " + "[" + string.Join(" ", vector) + "]";
    }

    // Matrix to string
    public static string toString(string dataName, int[,] matrix) {
        StringBuilder matrixString = new StringBuilder(dataName + ": \n");
        int matrixLength = matrix.GetLength(0);

        for (int i = 0; i < matrixLength; i++) {
            for (int j = 0; j < matrixLength; j++) {
                matrixString.Append(matrix[i, j] + " ");
            }
            matrixString.AppendLine();
        }
        return matrixString.ToString();
    }
}