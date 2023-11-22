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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "PASSIVE" + Environment.NewLine + "REZONANȚĂ Z-DRIVE" + Environment.NewLine + "Fiecare al treilea atac sau vrajă de daune asupra aceleiași ținte provoacă daune magice bonus și îi oferă lui Ekko o explozie de viteză dacă ținta este un campion.";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Q" + Environment.NewLine + "TIMEWINDER" + Environment.NewLine + "Ekko aruncă o grenadă temporală care se extinde într-un câmp de distorsiune a timpului la lovirea unui campion inamic, încetinind și dăunând pe oricine prins înăuntru. După o întârziere, grenada se derulează înapoi spre Ekko, provocând daune la întoarcere.";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "W" + Environment.NewLine + "CONVERGENTA PARALELA" + Environment.NewLine + "Atacurile de bază ale lui Ekko fac daune magice bonus inamicilor cu sănătate scăzută. El poate arunca Parallel Convergence pentru a împărți cronologia, creând o anomalie după câteva secunde care încetinește inamicii prinși înăuntru. Dacă Ekko intră în anomalie, el câștigă scuturi și uimește inamicii suspendându-i la timp.";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "E" + Environment.NewLine + "SCUFUNDARE DE FAZĂ" + Environment.NewLine + "Ekko se rostogolește evaziv în timp ce își încarcă Z-Drive-ul. Următorul său atac provoacă daune bonus și deformează realitatea, teleportându-l la ținta sa.";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "R" + Environment.NewLine + "CRONOBREAK" + Environment.NewLine + "Ekko își zdrobește cronologia, devenind imposibil de vizat și revenind la un moment mai favorabil în timp. Se întoarce oricând a fost acum câteva secunde și se vindecă pentru un procent din daunele primite în acea perioadă. Inamicii din apropierea zonei sale de sosire primesc pagube masive.";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox2.Text = " ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form5 formular5 = new Form5();
            formular5.Show();
            this.Close();

        }
    }
}
