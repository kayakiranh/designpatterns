using Entities;
using FactoryMethodDesignPattern.Factories;

namespace FactoryMethodDesignPattern
{
    public class Demo
    {
        public string Run(CreditCardTypeEnum cardType)
        {
            //https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/
            //https://www.evrenbal.com/tasarim-kaliplari-design-patterns-factory-method-nedir
            switch (cardType)
            {
                case CreditCardTypeEnum.AmericanExpress:
                    #region code

                    ICreditCardService americanExpressService = new AmericanExpressFactory().CreateCreditCard();
                    if (americanExpressService != null)
                    {
                        americanExpressService.GetCreditCard();
                        americanExpressService.GetLimit();
                        americanExpressService.GetMonthlyCharge();

                        return "american express : success";
                    }
                    else
                    {
                        return "american express : fail";
                    }

                    #endregion
                case CreditCardTypeEnum.Platinium:
                    #region code

                    ICreditCardService platiniumService = new PlatiniumFactory().CreateCreditCard();
                    if (platiniumService != null)
                    {
                        platiniumService.GetCreditCard();
                        platiniumService.GetLimit();
                        platiniumService.GetMonthlyCharge();

                        return "platinium : success";
                    }
                    else
                    {
                        return "platinium : fail";
                    }

                    #endregion
                case CreditCardTypeEnum.Gold:
                    #region code

                    ICreditCardService goldService = new GoldFactory().CreateCreditCard();
                    if (goldService != null)
                    {
                        goldService.GetCreditCard();
                        goldService.GetLimit();
                        goldService.GetMonthlyCharge();

                        return "gold : success";
                    }
                    else
                    {
                        return "gold : fail";
                    }

                    #endregion
                case CreditCardTypeEnum.Regular:
                    #region code

                    ICreditCardService regularService = new RegularFactory().CreateCreditCard();
                    if (regularService != null)
                    {
                        regularService.GetCreditCard();
                        regularService.GetLimit();
                        regularService.GetMonthlyCharge();

                        return "regular : success";
                    }
                    else
                    {
                        return "regular : fail";
                    }

                    #endregion
                default:
                    return "Not valid enum";
            }
        }
    }
}