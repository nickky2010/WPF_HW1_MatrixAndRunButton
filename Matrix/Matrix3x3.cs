using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix3x3
    {
        double[,] matrix;
        public double[,] Matrix
        {
            get => matrix;
            set
            {
                if (value.GetLength(0) == 3 && value.GetLength(1) == 3)
                    matrix = value;
                else
                    throw new Exception("The matrix property has a dimension of 3x3 and cannot be assigned an array of a different dimension!!!");
            }
        }
        public Matrix3x3()
        {
            matrix = new double[3, 3];
        }

        public double GetDeterminant()
        {
            return
            (
                matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1] +
                matrix[0, 1] * matrix[1, 2] * matrix[2, 0] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                matrix[0, 0] * matrix[1, 2] * matrix[2, 1] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2]
            );
        }
    }
}
