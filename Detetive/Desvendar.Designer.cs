namespace Detetive
{
    partial class Desvendar
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
            this.imgLugar = new System.Windows.Forms.PictureBox();
            this.imgPessoa = new System.Windows.Forms.PictureBox();
            this.imgArma = new System.Windows.Forms.PictureBox();
            this.lblugar = new System.Windows.Forms.Label();
            this.lbPessoa = new System.Windows.Forms.Label();
            this.lbArma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArma)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLugar
            // 
            this.imgLugar.Location = new System.Drawing.Point(1, 47);
            this.imgLugar.Name = "imgLugar";
            this.imgLugar.Size = new System.Drawing.Size(362, 423);
            this.imgLugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLugar.TabIndex = 0;
            this.imgLugar.TabStop = false;
            // 
            // imgPessoa
            // 
            this.imgPessoa.Location = new System.Drawing.Point(369, 47);
            this.imgPessoa.Name = "imgPessoa";
            this.imgPessoa.Size = new System.Drawing.Size(362, 423);
            this.imgPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPessoa.TabIndex = 1;
            this.imgPessoa.TabStop = false;
            // 
            // imgArma
            // 
            this.imgArma.Location = new System.Drawing.Point(737, 47);
            this.imgArma.Name = "imgArma";
            this.imgArma.Size = new System.Drawing.Size(362, 423);
            this.imgArma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgArma.TabIndex = 2;
            this.imgArma.TabStop = false;
            // 
            // lblugar
            // 
            this.lblugar.AutoSize = true;
            this.lblugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblugar.Location = new System.Drawing.Point(12, 24);
            this.lblugar.Name = "lblugar";
            this.lblugar.Size = new System.Drawing.Size(51, 20);
            this.lblugar.TabIndex = 3;
            this.lblugar.Text = "label1";
            // 
            // lbPessoa
            // 
            this.lbPessoa.AutoSize = true;
            this.lbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPessoa.Location = new System.Drawing.Point(388, 24);
            this.lbPessoa.Name = "lbPessoa";
            this.lbPessoa.Size = new System.Drawing.Size(51, 20);
            this.lbPessoa.TabIndex = 4;
            this.lbPessoa.Text = "label1";
            // 
            // lbArma
            // 
            this.lbArma.AutoSize = true;
            this.lbArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArma.Location = new System.Drawing.Point(751, 24);
            this.lbArma.Name = "lbArma";
            this.lbArma.Size = new System.Drawing.Size(51, 20);
            this.lbArma.TabIndex = 5;
            this.lbArma.Text = "label1";
            // 
            // Desvendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 482);
            this.Controls.Add(this.lbArma);
            this.Controls.Add(this.lbPessoa);
            this.Controls.Add(this.lblugar);
            this.Controls.Add(this.imgArma);
            this.Controls.Add(this.imgPessoa);
            this.Controls.Add(this.imgLugar);
            this.Name = "Desvendar";
            this.Text = "Assassino";
            ((System.ComponentModel.ISupportInitialize)(this.imgLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgLugar;
        public System.Windows.Forms.PictureBox imgPessoa;
        public System.Windows.Forms.PictureBox imgArma;
        public System.Windows.Forms.Label lblugar;
        public System.Windows.Forms.Label lbPessoa;
        public System.Windows.Forms.Label lbArma;
    }
}