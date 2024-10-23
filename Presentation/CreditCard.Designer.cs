namespace PhumlaKamnandiHotel.Presentation
{
    partial class CreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.numberp = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardn = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.ccv = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(332, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Check";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Azure;
            this.id.Location = new System.Drawing.Point(403, 175);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 13);
            this.id.TabIndex = 31;
            this.id.Text = "CVV\r\n";
            // 
            // numberp
            // 
            this.numberp.AutoSize = true;
            this.numberp.BackColor = System.Drawing.Color.Azure;
            this.numberp.Location = new System.Drawing.Point(284, 175);
            this.numberp.Name = "numberp";
            this.numberp.Size = new System.Drawing.Size(52, 13);
            this.numberp.TabIndex = 30;
            this.numberp.Text = "Exp. date";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Azure;
            this.email.Location = new System.Drawing.Point(284, 126);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 13);
            this.email.TabIndex = 29;
            this.email.Text = "Card number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // cardn
            // 
            this.cardn.Location = new System.Drawing.Point(287, 142);
            this.cardn.Name = "cardn";
            this.cardn.Size = new System.Drawing.Size(210, 20);
            this.cardn.TabIndex = 26;
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(287, 201);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(64, 20);
            this.exp.TabIndex = 25;
            this.exp.Text = "MM/YY";
            // 
            // ccv
            // 
            this.ccv.Location = new System.Drawing.Point(406, 201);
            this.ccv.Name = "ccv";
            this.ccv.Size = new System.Drawing.Size(64, 20);
            this.ccv.TabIndex = 24;
            this.ccv.Text = "123";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(332, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 27);
            this.button2.TabIndex = 36;
            this.button2.Text = "Logout";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.numberp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardn);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.ccv);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CreditCard";
            this.Text = "CreditCard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label numberp;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardn;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox ccv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
    }
}