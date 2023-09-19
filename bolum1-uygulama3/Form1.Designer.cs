namespace bolum1_uygulama3
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
            this.btnkırmızı = new System.Windows.Forms.Button();
            this.btnyesil = new System.Windows.Forms.Button();
            this.btnpurple = new System.Windows.Forms.Button();
            this.btnblue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkırmızı
            // 
            this.btnkırmızı.BackColor = System.Drawing.Color.Red;
            this.btnkırmızı.Location = new System.Drawing.Point(30, 37);
            this.btnkırmızı.Name = "btnkırmızı";
            this.btnkırmızı.Size = new System.Drawing.Size(126, 109);
            this.btnkırmızı.TabIndex = 0;
            this.btnkırmızı.Text = "kırmızı";
            this.btnkırmızı.UseVisualStyleBackColor = false;
            this.btnkırmızı.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnyesil
            // 
            this.btnyesil.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnyesil.Location = new System.Drawing.Point(162, 152);
            this.btnyesil.Name = "btnyesil";
            this.btnyesil.Size = new System.Drawing.Size(126, 109);
            this.btnyesil.TabIndex = 1;
            this.btnyesil.Text = "yeşil";
            this.btnyesil.UseVisualStyleBackColor = false;
            this.btnyesil.Click += new System.EventHandler(this.btnyesil_Click);
            // 
            // btnpurple
            // 
            this.btnpurple.BackColor = System.Drawing.Color.BlueViolet;
            this.btnpurple.Location = new System.Drawing.Point(30, 152);
            this.btnpurple.Name = "btnpurple";
            this.btnpurple.Size = new System.Drawing.Size(126, 109);
            this.btnpurple.TabIndex = 2;
            this.btnpurple.Text = "mor";
            this.btnpurple.UseVisualStyleBackColor = false;
            this.btnpurple.Click += new System.EventHandler(this.btngri_Click);
            // 
            // btnblue
            // 
            this.btnblue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnblue.Location = new System.Drawing.Point(162, 37);
            this.btnblue.Name = "btnblue";
            this.btnblue.Size = new System.Drawing.Size(126, 109);
            this.btnblue.TabIndex = 3;
            this.btnblue.Text = "mavi";
            this.btnblue.UseVisualStyleBackColor = false;
            this.btnblue.Click += new System.EventHandler(this.btnblue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnblue);
            this.Controls.Add(this.btnpurple);
            this.Controls.Add(this.btnyesil);
            this.Controls.Add(this.btnkırmızı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkırmızı;
        private System.Windows.Forms.Button btnyesil;
        private System.Windows.Forms.Button btnpurple;
        private System.Windows.Forms.Button btnblue;
    }
}

