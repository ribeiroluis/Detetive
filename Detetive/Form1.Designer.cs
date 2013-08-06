namespace Detetive
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbLugar = new System.Windows.Forms.ComboBox();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.btnpalpite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSorteio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsorteio2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 442);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.regrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desvendarToolStripMenuItem});
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // desvendarToolStripMenuItem
            // 
            this.desvendarToolStripMenuItem.Name = "desvendarToolStripMenuItem";
            this.desvendarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.desvendarToolStripMenuItem.Text = "Desvendar";
            this.desvendarToolStripMenuItem.Click += new System.EventHandler(this.desvendarToolStripMenuItem_Click);
            // 
            // regrasToolStripMenuItem
            // 
            this.regrasToolStripMenuItem.Name = "regrasToolStripMenuItem";
            this.regrasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.regrasToolStripMenuItem.Text = "Regras";
            this.regrasToolStripMenuItem.Click += new System.EventHandler(this.regrasToolStripMenuItem_Click);
            // 
            // cbLugar
            // 
            this.cbLugar.FormattingEnabled = true;
            this.cbLugar.Location = new System.Drawing.Point(16, 72);
            this.cbLugar.Name = "cbLugar";
            this.cbLugar.Size = new System.Drawing.Size(158, 21);
            this.cbLugar.TabIndex = 2;
            // 
            // cbPessoa
            // 
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(211, 72);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(158, 21);
            this.cbPessoa.TabIndex = 3;
            // 
            // cbArma
            // 
            this.cbArma.FormattingEnabled = true;
            this.cbArma.Location = new System.Drawing.Point(391, 72);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(158, 21);
            this.cbArma.TabIndex = 4;
            // 
            // btnpalpite
            // 
            this.btnpalpite.Enabled = false;
            this.btnpalpite.Location = new System.Drawing.Point(575, 72);
            this.btnpalpite.Name = "btnpalpite";
            this.btnpalpite.Size = new System.Drawing.Size(75, 23);
            this.btnpalpite.TabIndex = 5;
            this.btnpalpite.Text = "Palpite";
            this.btnpalpite.UseVisualStyleBackColor = true;
            this.btnpalpite.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sortear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSorteio
            // 
            this.lbSorteio.AutoSize = true;
            this.lbSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSorteio.ForeColor = System.Drawing.Color.DarkRed;
            this.lbSorteio.Location = new System.Drawing.Point(164, 222);
            this.lbSorteio.Name = "lbSorteio";
            this.lbSorteio.Size = new System.Drawing.Size(140, 73);
            this.lbSorteio.TabIndex = 7;
            this.lbSorteio.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Suspeito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Arma";
            // 
            // lbsorteio2
            // 
            this.lbsorteio2.AutoSize = true;
            this.lbsorteio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsorteio2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbsorteio2.Location = new System.Drawing.Point(428, 222);
            this.lbsorteio2.Name = "lbsorteio2";
            this.lbsorteio2.Size = new System.Drawing.Size(140, 73);
            this.lbsorteio2.TabIndex = 12;
            this.lbsorteio2.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(157, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "1 Jogada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(422, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "2 Jogada";
            // 
            // timer1
            // 
            this.timer1.Interval = 90;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbsorteio2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSorteio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnpalpite);
            this.Controls.Add(this.cbArma);
            this.Controls.Add(this.cbPessoa);
            this.Controls.Add(this.cbLugar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbLugar;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.Button btnpalpite;
        private System.Windows.Forms.ToolStripMenuItem desvendarToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSorteio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsorteio2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

