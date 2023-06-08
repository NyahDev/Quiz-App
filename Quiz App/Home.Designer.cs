namespace Quiz_App
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 384);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(259, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "2022 National Quiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.cbgender);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtfirst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(923, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // cbgender
            // 
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Location = new System.Drawing.Point(106, 160);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(150, 23);
            this.cbgender.TabIndex = 8;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(105, 111);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(151, 23);
            this.txtlast.TabIndex = 7;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(106, 289);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(151, 23);
            this.txtpass.TabIndex = 6;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(106, 248);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(151, 23);
            this.txtuser.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(105, 65);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(151, 23);
            this.txtfirst.TabIndex = 2;
            this.txtfirst.TextChanged += new System.EventHandler(this.txtfirst_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Last Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1147, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1066, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 481);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(40, 100);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "registrationPage";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtfirst;
        private Label label3;
        private Label label2;
        private ComboBox cbgender;
        private TextBox txtlast;
        private TextBox txtpass;
        private TextBox txtuser;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}