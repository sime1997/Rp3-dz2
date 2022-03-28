namespace gaurina2_sime
{
    partial class vremenski_raspon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datum2 = new gaurina2_sime.Datum();
            this.datum1 = new gaurina2_sime.Datum();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Početak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kraj:";
            // 
            // datum2
            // 
            this.datum2.Location = new System.Drawing.Point(495, 0);
            this.datum2.Name = "datum2";
            this.datum2.Size = new System.Drawing.Size(630, 162);
            this.datum2.TabIndex = 1;
            this.datum2.vrijednost = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.datum2.promjena += new System.EventHandler<System.DateTime>(this.datum2_promjena);
            this.datum2.Load += new System.EventHandler(this.datum2_Load);
            // 
            // datum1
            // 
            this.datum1.Location = new System.Drawing.Point(78, 3);
            this.datum1.Name = "datum1";
            this.datum1.Size = new System.Drawing.Size(357, 26);
            this.datum1.TabIndex = 0;
            this.datum1.vrijednost = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.datum1.promjena += new System.EventHandler<System.DateTime>(this.datum1_promjena);
            this.datum1.Load += new System.EventHandler(this.datum1_Load);
            // 
            // vremenski_raspon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datum2);
            this.Controls.Add(this.datum1);
            this.Name = "vremenski_raspon";
            this.Size = new System.Drawing.Size(1169, 161);
            this.Load += new System.EventHandler(this.vremenski_raspon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Datum datum1;
        private Datum datum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
