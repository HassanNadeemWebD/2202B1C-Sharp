using System;


namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jArr =
           new int[4][] {

               new int[] { 1,2,3,4,5 },
                new int[] { 23 , 44,8,6},
                new int[] {24,6,88},
                new int[] { 55,67},



            };


            //Console.WriteLine(jArr[2][1]);

            foreach (int[] arr in jArr)
            {

                foreach (int item in arr)
                {

                    Console.Write(item);
                    Console.Write('\t');


                }

                Console.WriteLine('\n');

            }

            int[][] jaggedArr = new int[4][];

            int len = 5;
            for (int i = 0; i < 4; i++)
            {
                jaggedArr[i] = new int[len];
                for (int j = 0; j < len; j++)
                {
                    Console.Write("Enter Integer : ");
                    jaggedArr[i][j] = Convert.ToInt32(Console.ReadLine());

                }

                len -= 1;





            }

            foreach (int[] arr in jaggedArr)
            {
                foreach (int elem in arr)
                {

                    Console.Write(elem + "\t");

                }

                Console.WriteLine('\n');



            }


            Console.ReadLine();


        }
    }
}
