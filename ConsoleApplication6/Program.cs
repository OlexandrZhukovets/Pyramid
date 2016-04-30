using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static int way=75;
        static void Main(string[] args)
        {
     

        int[][] data = new int[14][];

            data[0] = new int[]                          { 95, 64 };
            data[1] = new int[]                        { 17, 47 ,82 };
            data[2] = new int[]                      { 18 ,35, 87, 10 };
            data[3] = new int[]                     { 20, 4 ,82, 47, 65 };
            data[4] = new int[]                    { 19, 1, 23, 75, 3, 34 };
            data[5] = new int[]                   { 88, 2, 77, 73, 07, 63 ,67 };
            data[6] = new int[]                 { 99, 65, 04, 28, 06, 16, 7 ,92 };
            data[7] = new int[]                { 41, 41, 26 ,56 ,83 ,40 ,80, 70, 33 };
            data[8] = new int[]              { 41, 48, 72, 33, 47, 32 ,37 ,16, 94, 29 };
            data[9] = new int[]             { 53 ,71 ,44, 65, 25, 43, 91, 52, 97, 51, 14 };
            data[10] = new int[]          { 70, 11, 33, 28, 77 ,73, 17, 78, 39, 68 ,17, 57 };
            data[11] = new int[]         { 91, 71 ,52 ,38 ,17 ,14 ,91 ,43, 58, 50, 27, 29, 48 };
            data[12] = new int[]        { 63 ,66, 4 ,68 ,89 ,53 ,67 ,30 ,73 ,16, 69, 87, 40, 31 };
            data[13] = new int[]      { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38 ,53, 6 ,4, 23 };
            

            for (int i =0;i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                  
                    if (data[i][i] > data[i][i + 1])
                    {
                        way += data[i][i];
                        break;
                    }
                    else
                    {
                        way += data[i][i];
                        break;
                    }
                        
                }
            }
            Console.WriteLine(way);
            Console.ReadKey();
        }

    }
}
