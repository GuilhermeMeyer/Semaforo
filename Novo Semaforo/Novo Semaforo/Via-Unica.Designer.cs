
namespace Novo_Semaforo
{
    partial class viaUnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viaUnica));
            this.picCarro = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.picPedestre = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnReinicia = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarro
            // 
            this.picCarro.Image = ((System.Drawing.Image)(resources.GetObject("picCarro.Image")));
            this.picCarro.Location = new System.Drawing.Point(380, 547);
            this.picCarro.Margin = new System.Windows.Forms.Padding(2);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(112, 140);
            this.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarro.TabIndex = 0;
            this.picCarro.TabStop = false;
            // 
            // picVerde
            // 
            this.picVerde.Image = ((System.Drawing.Image)(resources.GetObject("picVerde.Image")));
            this.picVerde.Location = new System.Drawing.Point(380, 130);
            this.picVerde.Margin = new System.Windows.Forms.Padding(2);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(86, 41);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 1;
            this.picVerde.TabStop = false;
            // 
            // picAmarelo
            // 
            this.picAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("picAmarelo.Image")));
            this.picAmarelo.Location = new System.Drawing.Point(380, 130);
            this.picAmarelo.Margin = new System.Windows.Forms.Padding(2);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(86, 41);
            this.picAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo.TabIndex = 2;
            this.picAmarelo.TabStop = false;
            // 
            // picVermelho
            // 
            this.picVermelho.Image = ((System.Drawing.Image)(resources.GetObject("picVermelho.Image")));
            this.picVermelho.Location = new System.Drawing.Point(380, 130);
            this.picVermelho.Margin = new System.Windows.Forms.Padding(2);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(86, 41);
            this.picVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho.TabIndex = 3;
            this.picVermelho.TabStop = false;
            // 
            // picPedestre
            // 
            this.picPedestre.Image = ((System.Drawing.Image)(resources.GetObject("picPedestre.Image")));
            this.picPedestre.Location = new System.Drawing.Point(212, 254);
            this.picPedestre.Margin = new System.Windows.Forms.Padding(2);
            this.picPedestre.Name = "picPedestre";
            this.picPedestre.Size = new System.Drawing.Size(67, 84);
            this.picPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedestre.TabIndex = 4;
            this.picPedestre.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 118);
            this.label1.TabIndex = 5;
            this.label1.Text = "||||||||||||";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Botão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cartão";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnReinicia
            // 
            this.btnReinicia.Location = new System.Drawing.Point(718, 11);
            this.btnReinicia.Margin = new System.Windows.Forms.Padding(2);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(67, 33);
            this.btnReinicia.TabIndex = 8;
            this.btnReinicia.Text = "Reiniciar";
            this.btnReinicia.UseVisualStyleBackColor = true;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // viaUnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.btnReinicia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picVermelho);
            this.Controls.Add(this.picAmarelo);
            this.Controls.Add(this.picVerde);
            this.Controls.Add(this.picPedestre);
            this.Controls.Add(this.picCarro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viaUnica";
            this.Text = "Via Única";
            this.Load += new System.EventHandler(this.viaUnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarro;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.PictureBox picPedestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.Timer timer3;
    }
}