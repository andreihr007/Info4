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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "PASSIVE" + Environment.NewLine + "CALEA RĂTĂCITORULUI" + Environment.NewLine + "Șansa de lovitură critică a lui Yasuo este crescută. În plus, Yasuo se îndreaptă spre un scut ori de câte ori se mișcă. Scutul se declanșează atunci când primește daune de la un campion sau un monstru.";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Q" + Environment.NewLine + "FURTUNA DE OȚEL" + Environment.NewLine + "mpinge înainte, dăunând tuturor inamicilor dintr-o linie. La lovitură, oferă un teanc de Furtună de adunare pentru câteva secunde. La 2 stive, Steel Tempest trage un vârtej care lovește Airborne. Steel Tempest este tratat ca un atac de bază și cântărește cu toate aceleași lucruri.";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "W" + Environment.NewLine + "ZIDUL DE VÂNT" + Environment.NewLine + "Creează un zid în mișcare care blochează toate proiectilele inamice timp de 4 secunde.";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "E" + Environment.NewLine + "LAMA DE MĂTURAT" + Environment.NewLine + "Se strecoară prin inamicul țintă, provocând daune magice. Fiecare turnare mărește daunele ulterioare ale liniuței, până la o sumă maximă. Nu poate fi aruncat din nou asupra aceluiași inamic timp de câteva secunde. Dacă Steel Tempest este aruncat în timp ce fugi, va lovi ca un cerc.";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "R" + Environment.NewLine + "ULTIMA SUFLARE" + Environment.NewLine + "Clipește către un campion inamic aeropurtat, provocând daune fizice și ținând în aer toți inamicii aeropurtați din zonă. Oferă flux maxim, dar resetează toate stivele de Gathering Storm. Pentru un timp moderat după aceea, loviturile critice ale lui Yasuo obțin o penetrare semnificativă a armurii bonus.";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 formular2 = new Form2();
            formular2.Show();
            this.Close();
        }
    }
}
