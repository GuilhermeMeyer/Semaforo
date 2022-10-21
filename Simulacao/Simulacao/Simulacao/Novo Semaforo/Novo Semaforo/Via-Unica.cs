using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Semaforo
{
    public partial class viaUnica : Form
    {
        int caso = 0;
        public int tempo = 20;
        public viaUnica()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                //Tempos do Botão//
                case 1:
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2:
                    picVerde.Visible = false;
                    picAmarelo.Visible = true;
                    timer1.Interval = 3000;
                    caso = 3;
                    break;
                case 3:
                    picAmarelo.Visible = false;
                    picVermelho.Visible = true;
                    timer1.Interval = 10000;
                    caso = 4;
                    break;
                case 4:
                    picVermelho.Visible = false;
                    picVerde.Visible = true;
                    timer3.Enabled = true;
                    caso = 0;
                    break;

                //Tempos do Cartão//
                case 5:
                    timer1.Interval = 3000;
                    caso = 6;
                    break;
                case 6:
                    picVerde.Visible = false;
                    picAmarelo.Visible = true;
                    timer1.Interval = 3000;
                    caso = 7;
                    break;
                case 7:
                    picAmarelo.Visible = false;
                    picVermelho.Visible = true;
                    timer1.Interval = 15000;
                    caso = 8;
                    break;
                case 8:
                    picVermelho.Visible = false;
                    picVerde.Visible = true;
                    caso = 0;
                    break;

            }
        }

        private void viaUnica_Load(object sender, EventArgs e)
        {
            picVerde.Visible = true;
            picVermelho.Visible = false;
            picAmarelo.Visible = false;

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text != "Botão")
            {
                caso = 0;
            }
            else
            {
                caso = 1;
            }
            if (button1.Text == "Botão" && timer3.Enabled == true)
            {
                timer3.Enabled = false;
                tempo = 20;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (picVermelho.Visible == true)
                picPedestre.Left += 1;

            if (picVermelho.Visible == true && (picCarro.Location.Y == 422 && picCarro.Location.Y > 388))
                picCarro.Top -= 0;

            else if (picVermelho.Visible == true && (picCarro.Location.Y > 422 || picCarro.Location.Y < 388))
                picCarro.Top -= 2;

            else if (picAmarelo.Visible == true)
                picCarro.Top -= 2;

            else if (picVerde.Visible == true)
                picCarro.Top -= 3;

            if (picCarro.Location.Y < -172)
                picCarro.Location = new Point(picVerde.Location.X, 673);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caso = 5;
        }

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            picCarro.Location = new Point(picVerde.Location.X, 673);
            picPedestre.Location = new Point(212, 254);

            timer3.Enabled = false;
            button1.Text = "Botão";
            tempo = 20;

            if ((picVermelho.Visible || picAmarelo.Visible) == true)
            {
                picVerde.Visible = true;
                picAmarelo.Visible = false;
                picVermelho.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(tempo > 0)
            {
                tempo -= 1;
                button1.Text = tempo.ToString();
            }
            else
            {
                button1.Text = "Botão";
            }
        }
    }
}
