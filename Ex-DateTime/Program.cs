using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ====== Start ====== ");

            DateTime dt = DateTime.Now;
            Console.WriteLine("Date Now :" + dt);
            DateTime st = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek)); // 本周一
            Console.WriteLine("this week Monday:" + st);

            DateTime et = dt.AddDays(8 - Convert.ToInt32(dt.DayOfWeek)); // 下周一
            Console.WriteLine("next week Monday:" + et);

            Console.WriteLine("Is Now in this Time Zone?" + 
            DateTimeExtension.IsDayInZone(dt, st, et));

            Console.WriteLine(" ====== End ======");
            Console.ReadKey();
        }
    }

    public static class DateTimeExtension
    {
        /// <summary>
        /// 判斷輸入日期是否在設定的區間中
        /// - design by Allen 2015/06/11 -
        /// </summary>
        /// <param name="dt">輸入日期時間</param>
        /// <param name="sdt">要判斷區間的起始日期時間</param>
        /// <param name="edt">要判斷區間的結束日期時間</param>
        /// <returns></returns>
        public static bool IsDayInZone(this DateTime dt,DateTime sdt , DateTime edt)
        {
            return (dt.CompareTo(sdt) >= 0 && dt.CompareTo(edt) <= 0);
        }
    }
}
