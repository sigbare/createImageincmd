using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace workWithImg
{
    internal class ImgTesting
    {


        static void Main(string[] args)
        {
            Bitmap picture = new Bitmap(@"C:\Users\qwert\Downloads\image.jpg"); //your path img 

            List<int[]> lis = new List<int[]>();

            lis.Add(new int[3] { 0, 0, 0 });
            lis.Add(new int[3] { 0, 0, 139 });
            lis.Add(new int[3] { 0, 100, 0 });
            lis.Add(new int[3] { 0, 191, 255 });
            lis.Add(new int[3] { 139, 0, 0 });
            lis.Add(new int[3] { 139, 0, 139 });
            lis.Add(new int[3] { 255, 140, 0 });
            lis.Add(new int[3] { 128, 128, 128 });
            lis.Add(new int[3] { 169, 169, 169 });
            lis.Add(new int[3] { 0, 0, 255 });
            lis.Add(new int[3] { 0, 128, 0 });
            lis.Add(new int[3] { 135, 206, 235 });
            lis.Add(new int[3] { 255, 0, 0 });
            lis.Add(new int[3] { 255, 0, 255 });
            lis.Add(new int[3] { 255, 255, 0 });



            for (int i = 0; i < picture.Height; i++)
            {


                for (int j = 0; j < picture.Width; j++)
                {
                    int cl  = GetColor(lis, new int[3] { picture.GetPixel(j, i).R, picture.GetPixel(j, i).G, picture.GetPixel(j, i).B });
                    switch (cl)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Black; break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkRed; break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Gray; break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.DarkGray; break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Blue; break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.Green; break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.Cyan; break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.Red; break;
                        case 13:
                            Console.ForegroundColor = ConsoleColor.Magenta; break;
                        case 14:
                            Console.ForegroundColor = ConsoleColor.Yellow; break;
                        case 15:
                            Console.ForegroundColor = ConsoleColor.White; break;

                    }
                    
                    Console.Write("@@");
                    
                }

                Console.WriteLine();
            }
            


            Console.Write("Testing" + Console.WindowHeight);
            Console.ReadLine();

        }


       static public int GetColor(List<int[]> lis , int[] RGB)
        {
            int result = 0;

            List<int> dist = new List<int>();


            for(int i = 0; i < lis.Count; i++)
            {
                int distance = 0;
                int[] buf = new int[3] {0,0,0};

                if (lis[i].Length == 3)
                buf = lis[i];

                distance = (RGB[0] - buf[0]) + (RGB[1] - buf[1]) + (RGB[2] - buf[2]);

                if (distance < 0)
                    distance = distance * -1;
                dist.Add(distance);
            }

            int low = dist.Min();
            
            for(int i =0; i < dist.Count; i++)
            {
                if(dist[i] == low)
                {
                    result = i;
                    break;
                }
                    

            }


            return result;
        }
    }
}
