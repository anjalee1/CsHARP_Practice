using System;


namespace basicCsharp
{
    class Array
    {


        public static int[,] ar1 = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
       
        public static void MultiArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar1[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }

        public static void JaggedArray()
        {
            int[][] ar2 = new int[4][];
            ar2[0] = new int[4] {1,2,3,4 };
            ar2[1] = new int[3] {5,6,7};
            ar2[2] = new int[6] {8,9,10,11,12,13 };
            ar2[3] = new int[2] {1,4};

            ar2[0][1] = 5;

            for(int i =0; i< ar2.Length; i++)
            {
                for (int j=0;j<ar2[i].Length;j++ )
                {
                    Console.Write(ar2[i][j] + " ");
                }
                System.Console.WriteLine();
            }

        }

        public static void Params(params int[] arr3)
        {
            for(int i = 0; i < arr3.Length; i++)
            {
                
                    Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();
        }
        }
    }

