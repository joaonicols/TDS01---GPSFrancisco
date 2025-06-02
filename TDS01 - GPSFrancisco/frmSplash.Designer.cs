namespace TDS01___GPSFrancisco
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblGPSFrancisco = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pgbPorcentagem = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(257, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(237, 191);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblGPSFrancisco
            // 
            this.lblGPSFrancisco.AutoSize = true;
            this.lblGPSFrancisco.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSFrancisco.Location = new System.Drawing.Point(264, 221);
            this.lblGPSFrancisco.Name = "lblGPSFrancisco";
            this.lblGPSFrancisco.Size = new System.Drawing.Size(217, 47);
            this.lblGPSFrancisco.TabIndex = 1;
            this.lblGPSFrancisco.Text = "GSFrancisco";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(239, 290);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(292, 24);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Seja bem-vindo(a) à casa espírita!";
            // 
            // pgbPorcentagem
            // 
            this.pgbPorcentagem.Location = new System.Drawing.Point(178, 376);
            this.pgbPorcentagem.Name = "pgbPorcentagem";
            this.pgbPorcentagem.Size = new System.Drawing.Size(405, 32);
            this.pgbPorcentagem.TabIndex = 3;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(357, 342);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(32, 20);
            this.lblPorcentagem.TabIndex = 4;
            this.lblPorcentagem.Text = "0%";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.pgbPorcentagem);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblGPSFrancisco);
            this.Controls.Add(this.pcbLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Login";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblGPSFrancisco;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.ProgressBar pgbPorcentagem;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Timer tmrSplash;
    }
}