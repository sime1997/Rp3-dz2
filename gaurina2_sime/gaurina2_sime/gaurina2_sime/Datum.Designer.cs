namespace gaurina2_sime
{
    partial class Datum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dan = new System.Windows.Forms.TextBox();
            this.mjesec = new System.Windows.Forms.TextBox();
            this.godina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dan
            // 
            this.dan.Location = new System.Drawing.Point(0, 0);
            this.dan.Name = "dan";
            this.dan.Size = new System.Drawing.Size(100, 22);
            this.dan.TabIndex = 0;
            this.dan.TextChanged += new System.EventHandler(this.dan_TextChanged);
            // 
            // mjesec
            // 
            this.mjesec.Location = new System.Drawing.Point(123, 0);
            this.mjesec.Name = "mjesec";
            this.mjesec.Size = new System.Drawing.Size(100, 22);
            this.mjesec.TabIndex = 1;
            this.mjesec.TextChanged += new System.EventHandler(this.mjesec_TextChanged);
            // 
            // godina
            // 
            this.godina.Location = new System.Drawing.Point(244, 0);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(100, 22);
            this.godina.TabIndex = 2;
            this.godina.TextChanged += new System.EventHandler(this.godina_TextChanged);
            // 
            // Datum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.godina);
            this.Controls.Add(this.mjesec);
            this.Controls.Add(this.dan);
            this.Name = "Datum";
            this.Size = new System.Drawing.Size(357, 26);
            this.Load += new System.EventHandler(this.Datum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dan;
        private System.Windows.Forms.TextBox mjesec;
        private System.Windows.Forms.TextBox godina;
    }
}
