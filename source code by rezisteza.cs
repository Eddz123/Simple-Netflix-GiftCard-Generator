﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace GiftCard_Generator_Rezistenza
{
    class source_code_by_rezisteza
    {
        public static int numberCodes;
        public static string charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string numset = "123456789";
        public static string part1 = "LEQ";
        public static string part2 = "";
        public static string part3 = "";
        public static string netflixcode = "";
        public static int length1 = 2;
        public static int length2 = 6;
        public static StreamWriter streamWriter = new StreamWriter("codes.txt");

        static void Main(string[] args)
        {
            
            Console.Title = ("[© Coded By Rezistenza ] NETFLIX GC Gen v1.0 ~ Public Source Code ");
            Console.WriteWithGradient(@"

                 _   _      _    __ _ _         _____          _         _____            
                | \ | |    | |  / _| (_)       / ____|        | |       / ____|           
                |  \| | ___| |_| |_| |___  __ | |     ___   __| | ___  | |  __  ___ _ __  
                | . ` |/ _ \ __|  _| | \ \/ / | |    / _ \ / _` |/ _ \ | | |_ |/ _ \ '_ \ 
                | |\  |  __/ |_| | | | |>  <  | |___| (_) | (_| |  __/ | |__| |  __/ | | |
                |_| \_|\___|\__|_| |_|_/_/\_\  \_____\___/ \__,_|\___|  \_____|\___|_| |_|

", Color.IndianRed, Color.Red, 5);
            Console.WriteWithGradient("                     © Rezistenza Discord :Rezistenza#9229", Color.LightCyan, Color.White, 2);
            Console.WriteLine("\n");
            Console.Write("[~]", Color.Red);
            Console.Write(" > How Many Codes you want to Generate ?", Color.White);
            Console.WriteLine();
            Console.ForegroundColor = Color.Red;
            numberCodes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("\n");
                Console.Write("Netflix Codes Gen > ", Color.Red);
                Console.Write("Start Generating Netflix Gift Card Codes ...", Color.White);
                Thread.Sleep(5000);
                Console.WriteLine("\n");
                for (int i = 0; i < numberCodes; i++)
                {
                    //streamWriter.WriteLine(m2(2, charset));
                    part2 = generatechar(length1, charset);
                    part3 = generatenum(length2, numset);
                    netflixcode = part1 + part2 + part3;
                    streamWriter.WriteLine(netflixcode);

                }
                return;
            }
            finally
            {
                ((IDisposable)streamWriter).Dispose();

            }
        }
        private static string generatechar(int length, string charset)
        {
            return new string(Enumerable.Repeat<string>(charset, length).Select(new Func<string, char>(helper)).ToArray<char>());
        }

        public static string generatenum(int length, string charset)
        {
            return new string(Enumerable.Repeat<string>(charset, length).Select(new Func<string, char>(helper)).ToArray<char>());
        }

        private static Random random = new Random();

        private static char helper(string string_0)
        {
            return string_0[random.Next(string_0.Length)];
        }


    }
    
    }

