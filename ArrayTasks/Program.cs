using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region matrix 3x3

            var ar3 = new int[,]
            {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 }
            };


            Console.WriteLine("ShowArray");
            ShowArray(ar3);


            Console.WriteLine("ShowDiagonal");
            ShowDiagonal(ar3);


            Console.WriteLine('\n');
            Console.WriteLine("RotateMatrixToLeft");
            ShowArray( RotateMatrixToLeft(ar3));

            Console.WriteLine();
            Console.WriteLine("RotateMatrixToRight");
            ShowArray(RotateMatrixToRight(ar3));

            #endregion

            #region matrix 4x4

            var ar4 = new char[,]
            {
                { 'A','B','C','D' },
                { 'E','I','F','J' },
                { 'K','L','M','N' },
                { 'O','P','Q','R' }
            };


            Console.WriteLine("ShowArray");
            ShowArray(ar4);


            Console.WriteLine("ShowDiagonal");
            ShowDiagonal(ar4);


            Console.WriteLine('\n');
            Console.WriteLine("RotateMatrixToLeft");
            ShowArray(RotateMatrixToLeft(ar4));

            Console.WriteLine();
            Console.WriteLine("RotateMatrixToRight");
            ShowArray(RotateMatrixToRight(ar4));

            #endregion

        }


        static void ShowArray<T>(T [,] array)
        {
            var str = string.Empty;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    str += array[row, column] + " ";
                }

                str += "\n";
            }

            Console.WriteLine(str);
        }


        static void ShowDiagonal<T>(T [,] array)
        {
            Console.WriteLine("from left to right");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i, i] + " ");
            }


            Console.WriteLine();
            Console.WriteLine("from right to left");

            for (int i = 0, j = array.GetLength(0) - 1; i < array.GetLength(0); i++, j--)
            {
                Console.Write(array[i, j] + " ");
            }
        }


        static T[,] RotateMatrixToLeft<T>(T[,] array)
        {
            var newArray = new T[array.GetLength(0), array.GetLength(1)];

            for (int row = 0, newColumn = 0 ; row < array.GetLength(0); row++, newColumn++)
            {
                for (int column = 0, newRow = array.GetLength(1) - 1;
                    column < array.GetLength(1); column++, newRow--)
                {
                    newArray[newRow, newColumn] = array[row, column];
                }
            }

            return newArray;

            // 1 2 3
            // 4 5 6
            // 7 8 9

            // <-
            // 3 6 9
            // 2 5 8
            // 1 4 7
        }

        static T[,] RotateMatrixToRight<T>(T [,] array)
        {
            var newArray = new T[array.GetLength(0), array.GetLength(1)];

            for (int row = 0, newColumn = array.GetLength(0) - 1; row < array.GetLength(0); row++, newColumn-- )
            {
                for (int column = 0, newRow = 0; column < array.GetLength(1); column++, newRow++)
                {
                    newArray[newRow, newColumn] = array[row, column];
                }
            }

            return newArray;

            // 1 2 3
            // 4 5 6
            // 7 8 9

            // ->
            // 7 4 1
            // 8 5 2
            // 9 6 3
        }
    }
}
