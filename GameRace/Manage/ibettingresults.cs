using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRace.Manage
{
    class ibettingresults
    {
        //forces you to be consistant aqcross all of your classes
        interface ibettingresult
        {
            int Won { get; set; }
            int Lost { get; set; }

            //method
            int TotalBets();
        }
    }
}
