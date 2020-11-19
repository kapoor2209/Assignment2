using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Race
{
    public class Car_Race_Hound
    {
        public int Begin;


        public Random Take_Any;


        public int Car_Track;

       

        public void Place()
        {
                Begin = 0;
        }
        public int Location = 0;





        public PictureBox Car_Box = null;



        public bool MovingTheCars()
        {
        int ForwardMove = Take_Any.Next(1, 4);




            Point Getz = Car_Box.Location;


        Getz.X += ForwardMove;


            Car_Box.Location = Getz;



        if (Getz.X >= Car_Track)



                return true;
        else
        return false;
        }
        
    }
}