using Entities;
using InterfaceDesignPattern.Cards;

namespace InterfaceDesignPattern
{
    public class Demo
    {
        public string Run(CreditCardTypeEnum cardType)
        {
            switch (cardType)
            {
                case CreditCardTypeEnum.AmericanExpress:
                    #region code

                    try
                    {
                        AmericanExpress americanExpress = new AmericanExpress();
                        americanExpress.GetCreditCard();
                        americanExpress.GetLimit();                       
                        americanExpress.GetMonthlyCharge();

                        return "american express : success";
                    }
                    catch
                    {
                        return "american express : fail";
                    }

                    #endregion
                case CreditCardTypeEnum.Platinium:
                    #region code

                    try
                    {
                        Platinium platinium = new Platinium();
                        platinium.GetCreditCard();
                        platinium.GetLimit();
                        platinium.GetMonthlyCharge();

                        return "platinium : success";
                    }
                    catch
                    {
                        return "platinium : fail";
                    }

                #endregion
                case CreditCardTypeEnum.Gold:
                    #region code

                    try
                    {
                        Gold gold = new Gold();
                        gold.GetCreditCard();
                        gold.GetLimit();
                        gold.GetMonthlyCharge();

                        return "gold : success";
                    }
                    catch
                    {
                        return "gold : fail";
                    }

                #endregion
                case CreditCardTypeEnum.Regular:
                    #region code

                    try
                    {
                        Regular regular = new Regular();
                        regular.GetCreditCard();
                        regular.GetLimit();
                        regular.GetMonthlyCharge();

                        return "regular : success";
                    }
                    catch
                    {
                        return "regular: fail";
                    }

                #endregion
                default:
                    return "Not valid enum";
            }
        }
    }
}