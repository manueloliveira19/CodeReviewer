﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeReviewer
{
    public static class Start
    {
        public static void Main(string[] args)
        {
            RandomCode();
            Console.WriteLine("Noice");
            RandomIfCode("2");
            var x = RandomEarlyReturn();

            Console.WriteLine(z);
        }

        private static void RandomCode()
        {
            if (false)
            {
                Console.WriteLine("This cannot be used");
            }

            Console.WriteLine("This should be used instead");
        }

      private static void RandomCodeV2()
        {
            if (false)
            {
                Console.WriteLine("This cannot be used");
            }

            Console.WriteLine("This should be used instead");
        }

        private static void RandomIfCode(string key)
        {
            if (key == "1")
            {
                Console.WriteLine("The key is 1");
            }
            if (key == "2")
            {
                Console.WriteLine("The key is not 1");
            }
            if (key == "3")
            {
                Console.WriteLine("The key is not 1");
            }
            if (key == "4")
            {
                Console.WriteLine("The key is not 1");
            }
        }

        private static string RandomEarlyReturn()
        {
            var y = string.Empty;
            var z = "22";
            y = "22";

            return y;
            return z;
        }
    }
}
