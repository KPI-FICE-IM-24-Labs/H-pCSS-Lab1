namespace Tasks {
    public class T1 {
        public static void invoke(int matrixLength) {
            Console.WriteLine("Task T1 started");

            // C = A - B * (MA * MC) * e

            // Initialization of vectors and matrixes
            int[] C;
            int[] A = new int[matrixLength];
            int[] B = new int[matrixLength];
            int [,] MA = new int[matrixLength, matrixLength];
            int [,] MC = new int[matrixLength, matrixLength];
            int e;

            if (matrixLength <= 4) {
                Console.WriteLine("Value for the first expression: ");
                string? input = Console.ReadLine();
                if (input == null) {
                    throw new ArgumentException();
                }
                e = int.Parse(input);

                Data.fillFirstExpressionValues(matrixLength, e, A, B, MA, MC);
            } else {
                e = 1;
                Data.fillFirstExpressionValues(matrixLength, e, A, B, MA, MC);
            }

            // Calculate vector C = A - B * (MA * MC) * e

            // MA * MC
            int [,] multipliedMatrixes = Data.multiplyMatrixByMatrix(MA, MC);

            // B * (MA * MC)
            int[] multipliedVectorB = Data.multiplyVectorByMatrix(B, multipliedMatrixes);

            // B * (MA * MC) * e
            int[] multipliedVectorBWithScalar = Data.multiplyVectorbyScalar(multipliedVectorB, e);

            // A - B * (MA * MC) * e
            C = Data.substractVectors(A, multipliedVectorBWithScalar);

            if (matrixLength <= 4) {
                Console.WriteLine(Data.toString("Vector C", C));
            }
            Console.WriteLine("Task T1 end");
        }
    }
}