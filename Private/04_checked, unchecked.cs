﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.29
 * 내용 : checked - overflow 감지
 */

namespace Private
{
    internal class _04_checked__unchecked
    {
        static void Main4(string[] args)
        {
            int ten = 10;
            // int overflow = 2147483648; // unit 속성을 int로 변환할 수 없다고 에러를 감지한다
            
            int chknum = 2147483647 + ten;
            // 오버플로우가 됐음에도 오버플로우 감지 X
            Console.WriteLine(chknum); // -2147483639

            // checked를 통해 오버플로우 감지 가능
            
            try
            {
                // checked Expression
                // Console.WriteLine(checked(2147483647 + ten));

                // checked Block
                checked
                {
                    chknum = 2147483647 + ten; // chknum에 위와 달리 여기서는 오버플로우를 감지한다
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}


// 참고 사이트
// https://moonpmj.tistory.com/72
