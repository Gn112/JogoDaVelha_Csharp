using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool turno = true;

        private void b1_Click(object sender, EventArgs e)
        {
            if (turno == true && b1.Enabled == true)
            {
                b1.Text = "X";
                b1.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b1.Text = "O";
                b1.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (turno == true && b2.Enabled == true)
            {
                b2.Text = "X";
                b2.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b2.Text = "O";
                b2.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (turno == true && b3.Enabled == true)
            {
                b3.Text = "X";
                b3.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b3.Text = "O";
                b3.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (turno == true && b4.Enabled == true)
            {
                b4.Text = "X";
                b4.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b4.Text = "O";
                b4.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (turno == true && b5.Enabled == true)
            {
                b5.Text = "X";
                b5.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b5.Text = "O";
                b5.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (turno == true && b6.Enabled == true)
            {
                b6.Text = "X";
                b6.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1); ;
            }
            else
            {
                b6.Text = "O";
                b6.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (turno == true && b7.Enabled == true)
            {
                b7.Text = "X";
                b7.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b7.Text = "O";
                b7.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (turno == true && b3.Enabled == true)
            {
                b8.Text = "X";
                b8.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b8.Text = "O";
                b8.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (turno == true && b9.Enabled == true)
            {
                b9.Text = "X";
                b9.Enabled = false;
                turno = false;
                Testa0(1);
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
            }
            else
            {
                b9.Text = "O";
                b9.Enabled = false;
                turno = true;
                Testa0(2);
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
            }
        }

        public void Testa0(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";

                if ((t == b1.Text) && (t == b2.Text) && (t == b3.Text))
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
                else
                {
                    t = "O";

                    if ((t == b1.Text) && (t == b2.Text) && (t == b3.Text))
                    {
                        MessageBox.Show("Jogador 2 Venceu");
                    }
                }

            }
        }

        public void Testa1(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";

                if ((t == b4.Text) && (t == b5.Text) && (t == b6.Text))
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
                else
                {
                    t = "O";

                    if ((t == b4.Text) && (t == b5.Text) && (t == b6.Text))
                    {
                        MessageBox.Show("Jogador 2 Venceu");
                    }
                }

            }
        }
        public void Testa2(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";

                if ((t == b7.Text) && (t == b8.Text) && (t == b9.Text))
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
                else
                {
                    t = "O";

                    if ((t == b7.Text) && (t == b8.Text) && (t == b9.Text))
                    {
                        MessageBox.Show("Jogador 2 Venceu");
                    }
                }

            }
        }

        public void Testa3(int jogador)
        {

        }
        public void Testa4(int jogador)
        {

        }
        public void Testa5(int jogador)
        {

        }
        public void Testa6(int jogador)
        {

        }
        public void Testa7(int jogador)
        {

        }
    }
}
