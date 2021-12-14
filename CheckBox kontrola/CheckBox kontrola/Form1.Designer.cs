namespace CheckBox_kontrola
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
            this.chkdoručak = new System.Windows.Forms.CheckBox();
            this.btnposalji = new System.Windows.Forms.Button();
            this.chkručak = new System.Windows.Forms.CheckBox();
            this.chkvečera = new System.Windows.Forms.CheckBox();
            this.chksakrijnarudžbu = new System.Windows.Forms.CheckBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkdoručak
            // 
            this.chkdoručak.AutoSize = true;
            this.chkdoručak.Location = new System.Drawing.Point(47, 35);
            this.chkdoručak.Name = "chkdoručak";
            this.chkdoručak.Size = new System.Drawing.Size(67, 17);
            this.chkdoručak.TabIndex = 0;
            this.chkdoručak.Text = "Doručak";
            this.chkdoručak.UseVisualStyleBackColor = true;
            // 
            // btnposalji
            // 
            this.btnposalji.Location = new System.Drawing.Point(30, 153);
            this.btnposalji.Name = "btnposalji";
            this.btnposalji.Size = new System.Drawing.Size(159, 35);
            this.btnposalji.TabIndex = 1;
            this.btnposalji.Text = "Pošalji";
            this.btnposalji.UseVisualStyleBackColor = true;
            this.btnposalji.Click += new System.EventHandler(this.btnposalji_Click);
            // 
            // chkručak
            // 
            this.chkručak.AutoSize = true;
            this.chkručak.Location = new System.Drawing.Point(47, 67);
            this.chkručak.Name = "chkručak";
            this.chkručak.Size = new System.Drawing.Size(58, 17);
            this.chkručak.TabIndex = 2;
            this.chkručak.Text = "Ručak";
            this.chkručak.UseVisualStyleBackColor = true;
            // 
            // chkvečera
            // 
            this.chkvečera.AutoSize = true;
            this.chkvečera.Location = new System.Drawing.Point(47, 100);
            this.chkvečera.Name = "chkvečera";
            this.chkvečera.Size = new System.Drawing.Size(60, 17);
            this.chkvečera.TabIndex = 3;
            this.chkvečera.Text = "Večera";
            this.chkvečera.UseVisualStyleBackColor = true;
            // 
            // chksakrijnarudžbu
            // 
            this.chksakrijnarudžbu.AutoSize = true;
            this.chksakrijnarudžbu.Location = new System.Drawing.Point(219, 163);
            this.chksakrijnarudžbu.Name = "chksakrijnarudžbu";
            this.chksakrijnarudžbu.Size = new System.Drawing.Size(99, 17);
            this.chksakrijnarudžbu.TabIndex = 4;
            this.chksakrijnarudžbu.Text = "Sakrij narudžbu";
            this.chksakrijnarudžbu.UseVisualStyleBackColor = true;
            this.chksakrijnarudžbu.CheckedChanged += new System.EventHandler(this.chksakrijnarudžbu_CheckedChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(170, 24);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(257, 104);
            this.txtIspis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 212);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.chksakrijnarudžbu);
            this.Controls.Add(this.chkvečera);
            this.Controls.Add(this.chkručak);
            this.Controls.Add(this.btnposalji);
            this.Controls.Add(this.chkdoručak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkdoručak;
        private System.Windows.Forms.Button btnposalji;
        private System.Windows.Forms.CheckBox chkručak;
        private System.Windows.Forms.CheckBox chkvečera;
        private System.Windows.Forms.CheckBox chksakrijnarudžbu;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

