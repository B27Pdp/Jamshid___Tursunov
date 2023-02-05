using Modul_3.Advanced_Lesson_1_Try_Catch.HomeWork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_1_Try_Catch
{
    internal class Lesson1
    {
        public static void Start()
        {
            
            //LengthOfString.StartUp();   
            Card card1 = new(100000, CardType.HUMO, Currency.SOM);
            Card card2 = new(100000, CardType.UZCARD, Currency.SOM);
            Card card3 = new(100000, CardType.VISA, Currency.DOLLAR);
            Card card4 = new(100000, CardType.UNIONPAY, Currency.DOLLAR);
            Card card11 = new(100000, CardType.HUMO, Currency.SOM);
            Card card22 = new(100000, CardType.UZCARD, Currency.SOM);
            Card card33 = new(100000, CardType.VISA, Currency.DOLLAR);
            Card card44 = new(100000, CardType.UNIONPAY, Currency.DOLLAR);
            Console.WriteLine("=============WELCOME TO BANK SYSTEM============");
            Console.WriteLine(" Here you can exchange your money from card to card. ");
            Console.WriteLine("from => \n 1=> UzCard \n 2=> Humo \n 3=> Visa \n 4=> UnionPay");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("to => \n 1=> UzCard \n 2=> Humo \n 3=> Visa \n 4=> UnionPay");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the amount of Money");
            int number3 = int.Parse(Console.ReadLine());
            Console.Clear();
            try
            {
                switch ((number1, number2))
                {
                    case (1, 1):
                        if (number3 <= card1.Balance)
                        {
                            card1.Balance -= number3;
                            card11.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    
                    case (1, 2):
                        if (number3 <= card1.Balance)
                        {
                            card1.Balance -= number3;
                            card2.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    
                    case (2,1):
                        if (number3 <= card2.Balance)
                        {
                            card2.Balance -= number3;
                            card1.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (2,2):
                        if (number3 <= card2.Balance)
                        {
                            card2.Balance -= number3;
                            card22.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (3,4):
                        if (number3 <= card3.Balance)
                        {
                            card3.Balance -= number3;
                            card4.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (3,3):
                        if (number3 <= card3.Balance)
                        {
                            card3.Balance -= number3;
                            card33.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (4,3):
                        if (number3 <= card4.Balance)
                        {
                            card4.Balance -= number3;
                            card3.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (4,4):
                        if (number3 <= card4.Balance)
                        {
                            card4.Balance -= number3;
                            card44.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (1, 3):
                    case (1, 4):
                    case (2, 3):
                    case (2, 4):
                    case (3, 1):
                    case (4, 1):
                    case (3, 2):
                    case (4, 2): throw new CardTypeNotMatch();
                        break;

                }

                Console.WriteLine("succesfully withdrawed. ");
            }

            catch(NotEnoughMoney e)
            {
                Console.WriteLine(e.Message);

            }
            catch(CardTypeNotMatch e)
            {
                Console.WriteLine(e.Message);

            }
        }


    }
}
