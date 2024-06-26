﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 피보나치 연습문제
 */

namespace Exam._04
{
    class MyGeneric<T>
    {
        private T[] arr;
        private int count = 0;

        public MyGeneric(int length)
        {
            this.arr = new T[length];
            this.count = length;
        }

        public void Insert(params T[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                this.arr[i] = args[i];
            }
        }

        public void Print()
        {
            foreach (T i in this.arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
    internal class _04_04
    {

        static void Main4(string[] args)
        {
            MyGeneric<int> mg1 = new MyGeneric<int>(10);
            MyGeneric<string> mg2 = new MyGeneric<string>(5);

            mg1.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            mg2.Insert("김유신", "김춘추", "장보고", "강감찬", "이순신");

            mg1.Print();
            mg2.Print();
        }

    }
}
