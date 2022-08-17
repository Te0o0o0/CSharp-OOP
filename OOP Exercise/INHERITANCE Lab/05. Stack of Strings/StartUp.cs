﻿using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new List<string>() { "2323", "434e" });
            Console.WriteLine(stack.IsEmpty());

            Console.WriteLine(string.Join(" ",stack));
        }
    }
}
