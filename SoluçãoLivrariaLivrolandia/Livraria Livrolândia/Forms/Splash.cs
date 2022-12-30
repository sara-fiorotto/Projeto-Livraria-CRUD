using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Livraria_Livrolândia.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {

            InitializeComponent();
            
        }
        private bool efect = true;
        int couter;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            couter++;
            if (efect)
            {
                this.Opacity -= 0.001D;
            }
            if (this.Opacity == 0)
            {
                efect = false;
            }
            if (couter >= 500)
            {
                timer1.Enabled = false;
                Forms.Menu menu = new Forms.Menu();
                menu.Show();
                this.Hide();
            }
           
        }
    }
}
