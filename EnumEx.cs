using System;

namespace EnumDemo
{
    class EnumEx
    {
        enum Days
        {
            sun, mon, tue, wed, thus, fri, sat
        };
        static void Main(string[] args)
        {
            Days days = Days.sat;
            switch(days)
            {
                case Days.sun:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("PUBG Day");
                    break;
                case Days.mon:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("BGMI Day");
                    break;
                case Days.tue:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("Valorant Day");
                    break;
                case Days.wed:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("MindCraft Day");
                    break;
                case Days.thus:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("CS:GO Day");
                    break;
                case Days.fri:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("GTA5-Story mode Day");
                    break;
                case Days.sat:
                    Console.WriteLine("Which Game Day Today?");
                    Console.WriteLine("GTA5-RP mode Day");
                    break;
            }
        }
    }
}
