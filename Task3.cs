namespace Tasks {
    public static class T3 {
        public static void invoke(int matrixLength) {
            Console.WriteLine("Task T3 started");

            // O = SORT(MP * MR) * S

            // Initialization of vectors and matrixes
            int[] O;
            int[] S = new int[matrixLength];
            int [,] MP = new int[matrixLength, matrixLength];
            int [,] MR = new int[matrixLength, matrixLength];

            if (matrixLength <= 4) {
                Console.WriteLine("Value for the third expression: ");
                string? input = Console.ReadLine();
                if (input == null) {
                    Data.fillThirdExpressionValues(matrixLength, MP, MR, S);
                } else {
                    int value = int.Parse(input);
                    Data.fillThirdExpressionValues(matrixLength, MP, MR, S, value);
                }
                
            } else {
                Data.fillThirdExpressionValues(matrixLength, MP, MR, S, 3);
            }

            // Calculate vector O = SORT(MP * MR) * S

            // MP * MR
            int [,] multipliedMatrixes = Data.multiplyMatrixByMatrix(MP, MR);

            // SORT(MP * MR)
            int[,] sortedMatrix = Data.sortMatrixLines(multipliedMatrixes);

            // SORT(MP * MR) * S
            O = Data.multiplyVectorByMatrix(S, sortedMatrix);

            if (matrixLength <= 4) {
                Console.WriteLine(Data.toString("Vector O", O));
            }
            Console.WriteLine("Task T3 ended");
        }
    }
}