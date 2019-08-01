using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameRace
{
    public abstract class Player
    { 
            public string PlayerName { get; set; }
            public string Tractor { get; set; }
            public Single Cash { get; set; }
            public Single Bet { get; set; }
            public Label LabelWinner { get; set; }

            public Color MyColor { get; set; }


            public string FavoriteDrink { get; set; }


        }
    }

