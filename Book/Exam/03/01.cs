﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.21
 * 내용 : 피보나치 연습문제
 */

namespace Exam._03
{
    internal class _03_01
    {
        private string name;
        private int age;

        public _03_01(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("이름 : {0}", this.name);
            Console.WriteLine("나이 : {0}", this.age);
            Console.WriteLine("----------------");
        }

        static void Main1(string[] args)
        {
            _03_01 kim = new _03_01("김유신", 23);
            _03_01 lee = new _03_01("이순신", 31);

            kim.Show();
            lee.Show();
        }

    }
}
