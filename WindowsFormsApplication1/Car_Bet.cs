using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Race
{
    public class Car_Bet
    {
        public int Charge;


                            public int Car;



        public ss BetCar; 
        public string Method()
        {
                            if (Charge > 0)
      return BetCar.CarName + " Car_Bets " + Charge + " bucks on The Car." + Car;
                                     else
                        return BetCar.CarName + " Has Not Select a Car_Bet";
        }
        public int PayForCar(int Car_Winner)
        {
                            if (Car_Winner == Car)
                   {
         int PayForCar = Charge * 2;
                             return PayForCar;
                   }
                         else
                {
         int PayForCar = 0;
         return PayForCar;
                }
        }
    }
}