using System.Data;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace test;
class Program
{
    static void Main(string[] args)
    {
        int ay = 10;

        switch (ay)
        {
            case 12:
            case 1:
            case 2:
                System.Console.WriteLine("kış mevsimi");
                break;
            case 3:
            case 4: 
            case 5:
                System.Console.WriteLine("ilkbahar mevsimi");
                break;
            case 6:
            case 7:
            case 8:
                System.Console.WriteLine("yaz mevsimi");
                break;
            case 9:
            case 10:
            case 11:
                System.Console.WriteLine("sonbahar mevsimi");
                break;
            default:
                System.Console.WriteLine("yanlış bilgi");
                break;
        }

    }
}