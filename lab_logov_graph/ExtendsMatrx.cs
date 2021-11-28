using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_logov_graph
{
    static class ExtendsMatrx
    {
        public static int[][] UsersClone(this int[][] matrix)
        {
            int size = matrix.Length;
            int[][] tempMatrix = new int[size][];

            for(int i = 0; i < size; i++)
            {
                tempMatrix[i] = (int[])matrix[i].Clone();
            }

            return tempMatrix;
        }

    }
}
