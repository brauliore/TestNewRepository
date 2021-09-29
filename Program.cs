using System;
using System.Collections.Generic;

namespace TrianguloPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (checkIfHaveParams(args, 1))
            {
                trianguloPascal(100, args);
            }
            else
            {
                trianguloPascal(20, args);
            }

            
        }

        private static bool checkIfHaveParams(string[] args, int paramsCount)
        {
            return args.Length > paramsCount;
        }

        private static void trianguloPascal(int v, string[] args)
        {
            
            if (checkIfHaveParams(args, 2))
            {

            }

            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { 1 });
            list.Add(new List<int> { 1, 1 });

            for (int i = 1; i < v; i++)
            {
                List<int> newList = new List<int>();
                newList.Add(1);
                for (int j = 0; j < list.Count-1; j++)
                {
                    newList.Add(list[i][j] + list[i][j + 1]);
                }
                newList.Add(1);
                list.Add(newList);
            }

            foreach(List<int> listinlist in list)
            {
                foreach (int number in listinlist)
                {
                    Console.Write(number.ToString() + " ");
                }
                Console.WriteLine("");
            }
            


        }

    }
}
