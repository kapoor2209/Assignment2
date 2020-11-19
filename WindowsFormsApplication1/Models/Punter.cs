using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public abstract class Punter
    {
        public string Amount { get; set; }
        public string Busted { get; set; }
        public string Value { get; set; }
        public string Motor { get; set; }
        public string BetBike { get; set; }
        public string MyLabel { get; set; }
        public string MyRadioButton { get; set; }
        public string Name { get; set; }
        public string WinningDog { get; set; }
    }
}
