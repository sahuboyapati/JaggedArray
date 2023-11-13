using System;

class Program
{
    static void Main()
    {
        // Task 1: Declaration and Initialization
        // 1.1 Declare a jagged array of integers named matrix with three rows.
        int[][] matrix = new int[3][];

        // 1.2 Initialize each row of the matrix with different lengths.
        matrix[0] = new int[] { 1, 2, 3, 4 };      // 4 elements
        matrix[1] = new int[] { 5, 6 };            // 2 elements
        matrix[2] = new int[] { 7, 8, 9 };         // 3 elements

        // Task 2: Accessing and Display
        // 2.1 Access and store the value of the second element in the first row in a variable named element.
        int element = matrix[0][1];

        // 2.2 Display the entire matrix using a nested loop.
        Console.WriteLine("Task 2: Displaying the matrix");
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Task 3: Modification
        // 3.1 Modify the third element in the second row of the matrix to have a value of 15.
        if (matrix.Length > 1 && matrix[1].Length > 2)
        {
            matrix[1][2] = 15;

            // Display the modified matrix
            Console.WriteLine("\nTask 3: Modified matrix");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        //else
        //{
        //    Console.WriteLine("Task 3: Unable to modify matrix. Ensure the array bounds are correct.");
        //}

        // Task 4: Advanced Concepts
        // 4.1 Declare and initialize a jagged array named objectMatrix.
        object[][] objectMatrix = new object[][]
        {
            new object[] { 123, "welcome", 3.14 },
            new object[] { true, 'B', DateTime.Now }
        };

        // 4.2 Display the contents of the objectMatrix using nested loops.
        Console.WriteLine("\nTask 4: Displaying objectMatrix");
        for (int i = 0; i < objectMatrix.Length; i++)
        {
            for (int j = 0; j < objectMatrix[i].Length; j++)
            {
                Console.WriteLine($"Type: {objectMatrix[i][j].GetType()}, Value: {objectMatrix[i][j]}");
            }
            Console.ReadKey();
        }
    }
}
