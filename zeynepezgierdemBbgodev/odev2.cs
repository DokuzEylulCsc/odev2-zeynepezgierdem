using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2

{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Program x = new Program();
                x.Cevir();

            }

            public void Cevir()
            {

                int a,b,c,d,sayi;

                Console.Write("cevirmek istediğiniz sayıyı giriniz = ");

                string sayi2 = Console.ReadLine();

                sayi = Convert.ToInt32(sayi2);
                a = sayi / 1000;
                b = (sayi % 1000) / 100;
                c = ((sayi % 1000) % 100) / 10;
                d = ((sayi % 1000) % 100) % 10;

                if (sayi <= 3999)
                {
                    switch (a)
                    {
                        case 1:
                            Console.Write("M");
                            break;
                        case 2:
                            Console.Write("MM");
                            break;
                        case 3:
                            Console.Write("MMM");
                            break;
                        case 4:
                            Console.Write("Mv");
                            break;
                        case 5:
                            Console.Write("v");
                            break;
                        case 6:
                            Console.Write("vM");
                            break;
                        case 7:
                            Console.Write("vMM");
                            break;
                        case 8:
                            Console.Write("vMMM");
                            break;
                        case 9:
                            Console.Write("Mx");
                            break;
                    }
                    switch (b)
                    {
                        case 1:
                            Console.Write("C");
                            break;
                        case 2:
                            Console.Write("CC");
                            break;
                        case 3:
                            Console.Write("CCC");
                            break;
                        case 4:
                            Console.Write("CD");
                            break;
                        case 5:
                            Console.Write("D");
                            break;
                        case 6:
                            Console.Write("DC");
                            break;
                        case 7:
                            Console.Write("DCC");
                            break;
                        case 8:
                            Console.Write("DCCC");
                            break;
                        case 9:
                            Console.Write("C");
                            break;
                    }
                    switch (c)
                    {
                        case 1:
                            Console.Write("X");
                            break;
                        case 2:
                            Console.Write("XX");
                            break;
                        case 3:
                            Console.Write("XXX");
                            break;
                        case 4:
                            Console.Write("XL");
                            break;
                        case 5:
                            Console.Write("L");
                            break;
                        case 6:
                            Console.Write("LX");
                            break;
                        case 7:
                            Console.Write("LXX");
                            break;
                        case 8:
                            Console.Write("LXXX");
                            break;
                        case 9:
                            Console.Write("XC");
                            break;
                    }
                    switch (d)
                    {
                        case 1:
                            Console.Write("I");
                            break;
                        case 2:
                            Console.Write("II");
                            break;
                        case 3:
                            Console.Write("III");
                            break;
                        case 4:
                            Console.Write("IV");
                            break;
                        case 5:
                            Console.Write("V");
                            break;
                        case 6:
                            Console.Write("VI");
                            break;
                        case 7:
                            Console.Write("VII");
                            break;
                        case 8:
                            Console.Write("VIII");
                            break;
                        case 9:
                            Console.Write("IX");
                            break;
                    }

                }
                else
                {
                    Console.Write("Lütfen 1- 3999 arasında sayi girişi yapınız");
                }
                Console.ReadKey();

            }
        }
    }
}
