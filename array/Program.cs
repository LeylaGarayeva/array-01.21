using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int tek = 0;
            int cut = 0;
            int o = 0;
            int[] a = new int[10];

            Random f_ikili = new Random();

            int[,] ikili = new int[3, 3];


            for(int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    ikili[i, j] = f_ikili.Next(10);

                    //ikili[i, j] = i + j;

                    Console.Write("\t"+ikili[i,j]);

                    if (ikili[i, i] == ikili[j, j])
                    {
                        o += ikili[i, i];
                    }



                }
                Console.WriteLine();
            }

            int coords = 0;
            for(int i = 0; i < 3; i++)
            {
                coords += ikili[i,ikili.GetLength(0)-1-i];

            }

            Console.WriteLine(coords);
            Console.WriteLine(o);
            

            Random ran = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ran.Next(10);

                if (a[i] % 2 == 0)
                {
                    cut += a[i];
                    
                }
                else
                {
                    tek += a[i];
                    
                }
                //for (int j = 0; j < i; j++)
                //{
                //    if (a[i] == a[j])
                //    {
                //        Console.WriteLine(a[i] + "var");
                //    }
                //}


                //Array.Sort(a);
                //Console.WriteLine(a[0]);
                //Console.WriteLine(a[a.Length-1]);
          
               
                // c = c + a[i];


            }
            int max = a[0];
            int min = a[0];

          
            for (int z = 0; z < a.Length; z++)
            {
                if (max < a[z])
                {
                    max = a[z];
                }

                if(min > a[z])
                {
                    min = a[z];

                }
            }

            //Console.WriteLine(max+"max");
            //Console.WriteLine(min + "min");
            //Console.WriteLine(cut + "cut ");
            //Console.WriteLine(tek + "tek ");
            //Console.WriteLine(string.Join(",",a));

           // Console.WriteLine(c);

            //foreach(int f in a)
            //  {
            //      a[f] = ran.Next(10);
            //      Console.WriteLine(a[f]);
            //  }

            Console.ReadLine();

        }
    }
}




