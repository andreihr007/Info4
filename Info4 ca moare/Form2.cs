using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info4_ca_moare
{
    public partial class Form2 : Form
    {
        int Da=0,Nu=0;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Da++;
            Form3 formular3 = new Form3();
            formular3.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 formular1 = new Form1();
            formular1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nu++;
            Form6 formular6 = new Form6();
            formular6.Show();
            this.Close();
            

            
              
        }

  
    }
}
