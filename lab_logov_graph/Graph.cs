using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_logov_graph
{
    class Graph
    {
        public int quantity { get; set; }
        int[][] matrix;
        public int LargeLength = 0;

        public Graph(int size)
        {
            if(size > 0)
                quantity = size;
            matrix = new int[quantity][];

            for (int i = 0; i < quantity; i++)
            {
                matrix[i] = new int[quantity];
            }

            int num = 0;
            do
            {
                Console.Write("Введите первый населённый пункт: ");
                int locality1 = int.Parse(Console.ReadLine());
                Console.Write("Введите второй населённый пункт: ");
                int locality2 = int.Parse(Console.ReadLine());
                Console.Write("Введите длину пути: ");
                num = int.Parse(Console.ReadLine());

                if ((locality1 & locality2) < quantity & (locality1 & locality2) >= 0 &
                    num > 0 & (locality1 != locality2))
                {
                    if (matrix[locality2][locality1] == 0)
                        matrix[locality1][locality2] = num;
                }


            } while (num != 0);


        }

        private void FindRecursive(int a, int b, int length, int[][]matrix)
        {
            
            for (int i = 0; i < quantity; i++)
            {
                int tempLength = length;
                if (matrix[a][i] != 0)
                {

                    if(i == b)
                    {
                        
                        if(tempLength + matrix[a][i] > this.LargeLength)
                        {
                            this.LargeLength = tempLength + matrix[a][i];
                        }
                    }
                    else
                    {
                        int[][] tempMatrix = matrix.UsersClone();
                        tempMatrix[a][i] = 0;
                        FindRecursive(i, b, tempLength += matrix[a][i], tempMatrix);

                    }


                }
            }

        }

        public int FindLength(int a, int b)
        {
            FindRecursive(a, b, 0, this.matrix);
            return this.LargeLength;
        }


        public void PrintMatrix()
        {
            Console.WriteLine();
            foreach (int[] value in matrix)
            {
                Console.WriteLine();
                foreach (int cur in value)
                {
                    Console.Write(cur + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
