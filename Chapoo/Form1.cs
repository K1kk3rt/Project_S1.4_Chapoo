using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;


namespace Chapoo
{
    public partial class Chapoo : Form
    {
        public Chapoo()
        {
            InitializeComponent();
        }

        public void btn_testKeuken_Click(object sender, EventArgs e)
        {
            KeukenLogic.TestKeukenOverzicht();
        }
    }
}
