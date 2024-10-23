namespace PhumlaKamnandiHotel.Presentation
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.numberp = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(281, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(210, 20);
            this.textName.TabIndex = 0;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(281, 248);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(210, 20);
            this.textID.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(281, 197);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(210, 20);
            this.Phone.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(281, 147);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(210, 20);
            this.textEmail.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(278, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 7;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(278, 131);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 13);
            this.email.TabIndex = 9;
            this.email.Text = "Email Adress";
            // 
            // numberp
            // 
            this.numberp.AutoSize = true;
            this.numberp.Location = new System.Drawing.Point(278, 181);
            this.numberp.Name = "numberp";
            this.numberp.Size = new System.Drawing.Size(38, 13);
            this.numberp.TabIndex = 10;
            this.numberp.Text = "Phone";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(281, 232);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(81, 13);
            this.id.TabIndex = 11;
            this.id.Text = "Identity Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(352, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.numberp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Create";
            this.Text = "create account";
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label numberp;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}