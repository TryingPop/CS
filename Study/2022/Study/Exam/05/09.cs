﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 피보나치 연습문제
 */

namespace Exam._05
{
    class MyStack
    {
        const int maxSize = 10;
        private int[] arr = new int[maxSize];
        private int top;

        public MyStack()
        {
            top = 0;
        }

        public void Push(int val)
        {
            if (top < maxSize)
            {
                arr[top] = val;
                top++;
            }
            else
            {
                Console.WriteLine("Stack Full!");
                return;
            }
        }
        public int Pop()
        {
            if (top > 0)
            {
                top--;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty!");
                return default(int);
            }
        }
    }
    internal class _05_09
    {
        static void Main9(string[] args)
        {
            MyStack mstack = new MyStack();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next(1, 100);
                mstack.Push(val);
                Console.WriteLine($"Push({val})");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pop() = {mstack.Pop()}");
            }
        }

    }
}
