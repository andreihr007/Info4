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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "PASSIVE" + Environment.NewLine + "WARPATH" + Environment.NewLine + "Hecarim câștigă Daune de atac egale cu un procent din Viteza de mișcare bonus.";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "E" + Environment.NewLine + "ÎNCĂRCARE DEVASTATOARE" + Environment.NewLine + "Hecarim câștigă o viteză de mutare crescândă și se poate deplasa prin unități pentru o perioadă scurtă de timp. Următorul său atac dobândește ținta înapoi și provoacă daune fizice suplimentare în funcție de distanța pe care a parcurs-o de la activarea capacității.";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "R" + Environment.NewLine + "ASALT DE UMBRE" + Environment.NewLine + "Hecarim cheamă călăreți spectrale și încarcă înainte, provocând daune magice într-o linie. Hecarim creează o undă de șoc când își termină încărcarea, făcându-i pe inamicii din apropiere să fugă îngroziți.";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Q" + Environment.NewLine + "IEŞIRE VIOLENTĂ" + Environment.NewLine + "Hecarim desprinde inamicii din apropiere provocând daune fizice. Dacă Hecarim dăunează cel puțin unui inamic, el crește daunele și scade timpul de răcire al Rampages-urilor ulterioare.";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "W" + Environment.NewLine + "SPIRITUL DE GROAZĂ" + Environment.NewLine + "Hecarim dobândește armură și rezistență magică. Hecarim provoacă daune magice inamicilor din apropiere și câștigă sănătate egală cu un procent din orice daune suferite de acești inamici.";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form4 formular4 = new Form4();
            formular4.Show();
            this.Hide();
        }
    }
}
