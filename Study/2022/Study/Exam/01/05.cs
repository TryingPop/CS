﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 문자열 처리 연습문제
 */

namespace Exam._01
{
    internal class _01_05
    {
        static void Main5(string[] args)
        {
            string strScore = "60,72,82,86,92";
            string[] score = strScore.Split(',');
            // string[] score = strScore.Split(",");
            // 딱히 차이 없다

            int total = 0;

            for (int i = 0; i < score.Length; i++)
            {
                total += int.Parse(score[i]);
            }
            Console.WriteLine("총점 : {0}", total);
        }
    }
}
