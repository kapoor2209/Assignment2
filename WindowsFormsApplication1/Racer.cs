using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Race
{
    public class ss
    {
        public RadioButton RadioButton;



        public Label Label;



                                public string CarName; 
        public Car_Bet StartBet = null;


                                public int Dollar;
       
                 public void BetClearDone(bool CarRaceOver)
        {
                        if (CarRaceOver)
        {
                            StartBet = null;
        }
        else
        {
                            if (this.StartBet != null)
        {
                        Dollar += this.StartBet.Charge;
                                 this.StartBet = null;
        }
        else
        {
                            this.StartBet = null;
        }
        }
                 LabelForUpdation();
        }

        public void LabelForUpdation()
        {
                    if (StartBet == null)
                                    Label.Text = CarName + " Not Car_Bet Yet";
        else
                    Label.Text = StartBet.Method();
                        RadioButton.Text = CarName + " Having " + Dollar + " Dollar";
        }

        public bool FixTheBet(int Charge, int Car)
        {
                    if (Charge > Dollar)
        {
                             MessageBox.Show("No Dollar For The Car_Bet", CarName + " saying");
                    return false;
        }
        else
        {
                        if (this.StartBet == null)
        {
                     this.StartBet = new Car_Bet() { Charge = Charge, BetCar = this, Car = Car };
                this.Dollar -= Charge;
                            this.LabelForUpdation();
                return true;
        }
        else
        {
                                        this.Dollar += this.StartBet.Charge;
                this.StartBet = null;
                                            this.StartBet = new Car_Bet() { Charge = Charge, BetCar = this, Car = Car };
                            this.Dollar -= Charge;
                                            this.LabelForUpdation();
                            return true;
        }
        }
        }

        static void Main()
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        }


        internal void BetClearDone()
        {
            // throw new NotImplementedException();
        }
        internal void Collect(int Car_Winner)
        {

        //throw new NotImplementedException();
        }

        
    }
}
