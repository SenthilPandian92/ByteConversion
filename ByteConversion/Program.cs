using System;
using static ByteConversion.Conversion;

namespace ByteConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu();
        }

        public static void UserMessage()
        {
           
           //Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Megabytes to Bytes");
            Console.WriteLine("2) Gigabytes to Megabytes");
            Console.WriteLine("3) Terabytes to Gigabytes");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");
        }



        private static void MainMenu()
        {
            bool continuepar = false;
           
            string number;
            long n = 0;
         
            do
            {
                UserMessage();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter number:");
                        number = Console.ReadLine();
                        //continuepar = true;
                        if (CheckisNumeric(number, ref n))
                        {
                            Console.WriteLine(Conversion.MegabyteToBytes(n));

                        }
                        else
                        {
                            continuepar = false;
                           
                        }


               
                        break;
                    case "2":
                        Console.WriteLine("Enter number:");
                        number = Console.ReadLine();
                       // continuepar = true;
                        if (CheckisNumeric(number, ref n))
                        {
                            Console.WriteLine(Conversion.GigabyteToMegaBytes(Int64.Parse(number)));
                        }
                        else
                        {
                            continuepar = false;
                          
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter number:");
                        number = Console.ReadLine();
                       // continuepar = true;
                        if (CheckisNumeric(number, ref n))
                        {
                            Console.WriteLine(Conversion.TerabyteToGigaBytes(Int64.Parse(number)));
                        }
                        else
                        {
                            continuepar = false;
                         
                        }
                        break;
                    case "4":
                        Environment.Exit(1);
                        break;
                    default:
                        continuepar = false;
                      
                        break;
                }
            } while (continuepar == false);
        }

        private static bool CheckisNumeric(string number, ref long n)
        {
            bool isNumeric = long.TryParse(number, out n);
            return isNumeric;
        }

    }

  
}
