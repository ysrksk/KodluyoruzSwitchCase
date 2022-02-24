using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = DateTime.Now.Month;
            switch(month)
            {                
                case 1:
                    System.Console.WriteLine("Ocak Ayındasınız.");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan Ayındasınız.");
                    break;
                case 3:
                    System.Console.WriteLine("Yanlış veri girdiniz");
                break;
            }

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar ayındasınız");
                    break;

                default:
                break;
            }

        }
    }
}
