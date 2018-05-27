using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;


namespace LOGIC
{
    public class KeukenLogic
    {
        public static void TestKeukenOverzicht()
        {
            KeukenDAO.GetKeukenOverzicht(KeukenModel.keukenoverzicht);
        }
    }
}
