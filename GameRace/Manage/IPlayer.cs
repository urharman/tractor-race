using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameRace.Manage
{
    interface IPlayer
    {

        string PlayerName { get; set; }
        string Tractor { get; set; }
        Single Cash { get; set; }
        Single Bet { get; set; }
        Label LabelWinner { get; set; }

        Color MyColor { get; set; }

        string FavoriteDrink { get; set; }

        int WildCard { get; set; }
    }
}
