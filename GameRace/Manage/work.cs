using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRace.Manage
{
    class work
    {
        //Descides which class we want to instantiate
        //1,2,3
        public static Player GetAPlayer(int id)
        {
            switch (id)
            {
                case 0:
                    return new harmanpreet();
                case 1:
                    return new anil();
                case 2:
                    return new gaganpreet();

                default: return null;

            }

        }

    }
}
