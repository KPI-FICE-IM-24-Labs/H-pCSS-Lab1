namespace Tasks {
    public static class T2 {
        public static void invoke(int matrixLength) {
            Console.WriteLine("Task T2 started");

            // MG = MAX(MH) * (MK * ML)

            // Initialization of vectors and matrixes
            int [,] MH = new int[matrixLength, matrixLength];
            int [,] MK = new int[matrixLength, matrixLength];
            int [,] ML = new int[matrixLength, matrixLength];
            int [,] MG;  

            if (matrixLength <= 4) {
                Console.WriteLine("Value for the second expression: ");
                string? input = Console.ReadLine();
                if (input == null) {
                    throw new ArgumentException();
                }
                int value = int.Parse(input);

                Data.fillSecondExpressionValues(matrixLength, value, MH, MK, ML);
            } else {
                Data.fillSecondExpressionValues(matrixLength, 2, MH, MK, ML);
            }

            // Calculate matrix MG = MAX(MH) * (MK * ML)

            // MK * ML
            int [,] multipliedMatrixes = Data.multiplyMatrixByMatrix(MK, ML);

            // MAX(MH)
            int maxMatrixElement = Data.findMatrixMaxElement(MH);

            // MG = MAX(MH) * (MK * ML)
            MG = Data.multiplyMatrixByScalar(multipliedMatrixes, maxMatrixElement);

            if (matrixLength <= 4) {
                Console.WriteLine(Data.toString("Matrix MG", MG));
            }
            Console.WriteLine("Task T2 ended");
        }
    }
}