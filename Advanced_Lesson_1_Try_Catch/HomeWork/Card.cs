using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_1_Try_Catch.HomeWork
{
    internal class Card
    {
        public Card(double balance, CardType type, Currency currencyType)
        {
            Balance = balance;
            this.type = type;
            this.currencyType = currencyType;
        }

        public int ID { get; set; }
        public string Owner { get; set; }
        public double Balance { get; set; }
        public CardType type { get; set; }

        public Currency currencyType { get; set; }
    }
    class CardTypeNotMatch: SystemException
    {
        public override string Message { get; } = "Kartalar holati mos bo'lmagan holat. ";
        
    }
    class NotEnoughMoney: SystemException
    {
        public override string Message { get; } = "Pul yetarli bo'lmagan holat. ";
        
    }

}
