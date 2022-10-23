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
    public partial class Cruzamento : Form
    {
        int caso = 0;
        int casoCartao = 0;
        int sequencia = 0;
        public Cruzamento()
        {
            InitializeComponent();
        }

        private void Cruzamento_Load(object sender, EventArgs e)
        {
            picVerde1.Visible = true;
            picVerde2.Visible = false;

            picAmarelo1.Visible = false;
            picAmarelo2.Visible = false;

            picVermelho1.Visible = false;
            picVermelho2.Visible = true;

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 0:
                    timer1.Interval = 5000;
                    caso = 1;
                    break;
                case 1:
                    if (picVerde1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;
                    }
                    else if (picVerde2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;
                    }
                    timer1.Interval = 4000;
                    caso = 2;
                    break;
                case 2:
                    if (picAmarelo1.Visible == true)
                    {
                        picVermelho1.Visible = true;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = false;

                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = true;
                    }
                    else if (picAmarelo2.Visible == true)
                    {
                        picVermelho2.Visible = true;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = false;


                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = true;
                    }
                    timer1.Interval = 8000;
                    caso = 3;
                    break;
                case 3:
                    timer1.Interval = 1;
                    caso = 0;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y > 400)
            {
                picCarroPreto.Top -= 1;
            }
            else if(picVerde1.Visible == true || ((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y < 400))
            {
                picCarroPreto.Top -= 2;
            }
            else if((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y  == 400)
            {
                picCarroPreto.Top -= 0;
            }
            

            if((picAmarelo2.Visible || picVermelho2.Visible) == true && picCarroBranco.Location.X > 642)
            {
                picCarroBranco.Left -= 1;
            }
            else if(picVerde2.Visible == true || ((picAmarelo2.Visible || picVermelho2.Visible) == true  && picCarroBranco.Location.X < 642))
            {
                picCarroBranco.Left -= 2;
            }
            else if((picAmarelo2.Visible || picVermelho2.Visible) == true && picCarroBranco.Location.X == 642)
            {
                picCarroBranco.Left -= 0;
            }


            if(picVermelho1.Visible == true && picAmarelo2.Visible == false || picPedestre.Location.X < 128 || picPedestre.Location.X >= 358)
            {
                picPedestre.Left += 1;
            }
            if (picVermelho1.Visible == true && picVermelho2.Visible == true || picCadeirante.Location.Y < 14 || picCadeirante.Location.Y >= 245)
            {
                picCadeirante.Top += 1;
            }
            


            if (picCarroPreto.Location.Y < -133)
            {
                picCarroPreto.Location = new Point(picVerde1.Location.X, 548);
            }
            else if (picCarroBranco.Location.X < -128)
            {
                picCarroBranco.Location = new Point(797, picVerde2.Location.Y);
            }
            else if (picPedestre.Location.X >= 907)
            {
                picPedestre.Location = new Point(-95, 323);
            }
            else if (picCadeirante.Location.Y >= 638)
            {
                picCadeirante.Location = new Point(569, -52);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer1.Enabled = false;
            casoCartao = 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            switch (casoCartao)
            {
                case 1:
                    if (picVerde1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;
                        sequencia = 1;
                    }
                    else if (picVerde2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;
                        sequencia = 2;
                    }
                    else if (picAmarelo1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;

                        picVermelho2.Visible = true;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = false;

                        sequencia = 1;
                    }
                    else if (picAmarelo2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;


                        picVermelho1.Visible = true;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = false;

                        sequencia = 2;
                    }
                    timer3.Interval = 3000;
                    casoCartao = 2;
                    break;

                case 2:
                    picVermelho1.Visible = true;
                    picVermelho2.Visible = true;
                    picAmarelo1.Visible = false;
                    picAmarelo2.Visible = false;

                    timer3.Interval = 5000;
                    casoCartao = 3;
                    break;
                case 3:

                    if(sequencia == 2)
                    {
                        picVerde1.Visible = true;
                        picVermelho1.Visible = false;
                    }
                    else if(sequencia == 1)
                    {
                        picVerde2.Visible = true;
                        picVermelho2.Visible = false;
                    }
                    timer3.Interval = 1;
                    timer1.Enabled = true;
                    casoCartao = 0;
                    caso = 0;
                    break;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            picCadeirante.Location = new Point(569, 14);
            picPedestre.Location = new Point(95, 323);

            picCarroPreto.Location = new Point(222, 548);
            picCarroBranco.Location = new Point(797, 123);

            picVerde1.Visible = true;
            picVermelho2.Visible = true;

            picAmarelo1.Visible = false;
            picAmarelo2.Visible = false;
            picVermelho1.Visible = false;
            picVerde2.Visible = false;
            caso = 0;
        }
    }
}
