using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        ss[] Car_Betting;
       
        ss Current_Betting;



                            Car_Race_Hound[] Car;
        public Form1()
        {
            InitializeComponent();
            Random Take_Any = new Random();

           
            Car_Betting = new ss[3];
            Car = new Car_Race_Hound[4];

      
            Car_Betting[0] = new ss();
            Car_Betting[0].CarName = "Jorden";
            Car_Betting[0].RadioButton = JordenRadioButton;
            Car_Betting[0].Label = JordenButtonLabel;
            Car_Betting[0].Dollar = 50;
            Car_Betting[0].LabelForUpdation();

            Car_Betting[1] = new ss();
            Car_Betting[1].CarName = "Baron";
            Car_Betting[1].RadioButton = BaronRadioButton;
            Car_Betting[1].Label = BaronButtonLabel;
            Car_Betting[1].Dollar = 75;
            Car_Betting[1].LabelForUpdation();

            Car_Betting[2] = new ss();
            Car_Betting[2].CarName = "Adom";
            Car_Betting[2].RadioButton = AdomRadioButton;
            Car_Betting[2].Label = AdomButtonLabel;
            Car_Betting[2].Dollar = 45;
            Car_Betting[2].LabelForUpdation();


            int StartPointPosition = Car1.Location.X;
            int distance = CarTrackimage.Width;
            for (int i = 0; i < 4; i++)
            {
                Car[i] = new Car_Race_Hound();
                Car[i].Take_Any = Take_Any;
                Car[i].Car_Track = distance;
                Car[i].Location = Car[i].Begin = StartPointPosition;
            }

            Car[0].Car_Box = Car1;
            Car[1].Car_Box = Car2;
            Car[2].Car_Box = Car3;
            Car[3].Car_Box = Car4;

            Current_Betting = Car_Betting[0];
        }


        private void JordenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FixTheBetting(0);
        }

        private void BaronRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            FixTheBetting(1);
        }

        private void AdomRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            FixTheBetting(2);
        }




        private void FixTheBetting(int index)
        {
            Current_Betting = Car_Betting[index];
            NameLabel.Text = Current_Betting.CarName;
            if (Current_Betting.StartBet != null)
            {
                numericincreasedecrease.Value = Current_Betting.StartBet.Charge;
                numericincreasedecreaseCar.Value = Current_Betting.StartBet.Car;
            }
            else
            {
                numericincreasedecrease.Value = numericincreasedecrease.Minimum;
                numericincreasedecreaseCar.Value = 1;
            }
        }
        private void CarRaceGo(object sender, EventArgs e)
        {
            int CarWinner = 0;
            int Number_Of_Winners = 0;

            while (Number_Of_Winners == 0)
            {
                for (int i = 0; i < Car.Length; i++)
                {
                    if (Car[i].MovingTheCars())
                    {
                        Number_Of_Winners++;
                        CarWinner = i + 1;
                    }
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(3);
            }



            for (int i = 0; i < Car.Length; i++)
            {
                Car[i].Place();
            }
            string messageContent = "Congratulations Rider \n";
            bool WinnerWhoWins = false;
            for (int i = 0; i < Car_Betting.Length; i++)
            {
                if (Car_Betting[i].StartBet.Car == CarWinner)
                {
                    WinnerWhoWins = true;
                    messageContent += Car_Betting[i].CarName + "\n";
                }
                Car_Betting[i].Collect(CarWinner);
                Car_Betting[i].BetClearDone();
                Car_Betting[i].LabelForUpdation();
            }
            if (WinnerWhoWins)
            {
               
                MessageBox.Show(" Car Number" + CarWinner + "wins!\n" + messageContent);
            }

            if (Number_Of_Winners > 1)
                MessageBox.Show("We gave " + Number_Of_Winners + " wins");
            else if (!WinnerWhoWins)
            {
                MessageBox.Show(" Car Number" + CarWinner + "wins!");
            }
            numericincreasedecrease.Value = numericincreasedecrease.Minimum;
            numericincreasedecreaseCar.Value = numericincreasedecreaseCar.Minimum;
            ResetAllTheCars();
        }

        
        

        private void BetsButton_Click(object sender, EventArgs e)
        {
            Current_Betting.FixTheBet((int)numericincreasedecrease.Value, (int)numericincreasedecreaseCar.Value);
            Current_Betting.LabelForUpdation();
        }


        private void Car2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumButton.Text = "To Start Min CarBet $5.00";
        }


        private void frmbtnRacing_Click(object sender, EventArgs e)
        {
            int CarWinner = 0;
            int WinCarNumber = 0;
            int count = 0;
            for (int i = 0; i < Car_Betting.Length; i++)
            {
                if (Car_Betting[1].StartBet != null)
                {
                    count++;
                }
            }

            if (count == Car_Betting.Length)
            {
                while (CarWinner == 0)
                {
                    for (int i = 0; i < Car.Length; i++)
                    {
                        if (Car[i].MovingTheCars())
                        {
                            CarWinner++;
                            WinCarNumber = i + 1;
                            for (int i2 = 0; i2 < Car_Betting.Length; i2++)
                            {
                                Car_Betting[i2].Collect(i + 1);
                            }
                        }
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    }
                }
                if (CarWinner > 1)
                {
                    MessageBox.Show("More Than One Car wins!", "Yeh");
                }
                else
                {
                    MessageBox.Show("The CarWinner was" + WinCarNumber);
                }
                for (int i = 0; i < Car_Betting.Length; i++)
                {
                    Car_Betting[i].BetClearDone(true);
                }
                for (int i = 0; i < Car.Length; i++)
                {
                    Car[i].Place();
                }
            }
            else
            {
                MessageBox.Show("Every player have Not placed their bets!!", "Please wait!");
            }
        }

        private void CarTrackimage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAllTheCars();
        }

        private void Car1_Click(object sender, EventArgs e)
        {

        }

        private void ResetAllTheCars()
        {
            Car1.Location = new Point(61, 32);
            Car2.Location = new Point(61, 84);
            Car3.Location = new Point(61, 131);
            Car4.Location = new Point(61, 181);
        }


        private void Car3_Click(object sender, EventArgs e)
        {

        }

        private void numericincreasedecrease_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
