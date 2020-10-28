using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialNFC
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {

            InitializeComponent();
            timer1.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
    
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {

                timer1.Enabled = false;
                timer1.Stop();
               
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                this.Hide();
                

                
            }
             

        }
    }
}
