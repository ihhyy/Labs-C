using System;


namespace train2
{
    class Vector
    {
        public int[,] vector = { };
        public int elems;

        public Vector(int[,] arr)
        {
            Vect = arr;
        }

        public int[,] Vect
        {
            get { return vector; }
            set
            {
                for (int i = 0; i < value.Length / 2; i++)
                {
                    if (value[i, 0] == 0 || value[i, 1] == 0)
                    {
                        throw new Exception("wrong vector");
                    }

                    else
                    {
                        vector = value;
                    }
                }
            }
        }


        public int[,] Multiply(int mult)
        {
            int[,] result = { };
            elems = vector.Length / 2;
            for (int i = 0; i < elems; i++)
            {
                for (int y = 0; y < 2; y++)
                {
                    result[i, y] = vector[i, y] * mult;
                }
            }
            return result;
        }

        public int[,] Sum(int term)
        {
            int[,] result = { };
            elems = vector.Length / 2;
            for (int i = 0; i < elems; i++)
            {
                for (int y = 0; y < 2; y++)
                {
                    result[i, y] = vector[i, y] + term;
                }
            }

            return result;
        }
    }
}

