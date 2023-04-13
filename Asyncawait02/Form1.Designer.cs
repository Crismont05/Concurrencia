namespace Asyncawait02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btniniciar = new System.Windows.Forms.Button();
            this.ptbloading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbloading)).BeginInit();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(286, 33);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(237, 63);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Iniciar proceso";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // ptbloading
            // 
            this.ptbloading.Image = ((System.Drawing.Image)(resources.GetObject("ptbloading.Image")));
            this.ptbloading.Location = new System.Drawing.Point(336, 183);
            this.ptbloading.Name = "ptbloading";
            this.ptbloading.Size = new System.Drawing.Size(144, 122);
            this.ptbloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbloading.TabIndex = 1;
            this.ptbloading.TabStop = false;
            this.ptbloading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbloading);
            this.Controls.Add(this.btniniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbloading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btniniciar;
        private PictureBox ptbloading;
    }
}