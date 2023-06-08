namespace Quiz_App
{
    partial class AdminQuestionPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbE = new System.Windows.Forms.ComboBox();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.cbA = new System.Windows.Forms.ComboBox();
            this.lbE = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtquest = new System.Windows.Forms.TextBox();
            this.cbno = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(20, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 328);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbE);
            this.panel2.Controls.Add(this.cbD);
            this.panel2.Controls.Add(this.cbC);
            this.panel2.Controls.Add(this.cbB);
            this.panel2.Controls.Add(this.cbA);
            this.panel2.Controls.Add(this.lbE);
            this.panel2.Controls.Add(this.lbD);
            this.panel2.Controls.Add(this.lbC);
            this.panel2.Controls.Add(this.lbB);
            this.panel2.Controls.Add(this.lbA);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtquest);
            this.panel2.Controls.Add(this.cbno);
            this.panel2.Location = new System.Drawing.Point(127, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 280);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbE
            // 
            this.cbE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbE.FormattingEnabled = true;
            this.cbE.Location = new System.Drawing.Point(149, 242);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(121, 25);
            this.cbE.TabIndex = 25;
            this.cbE.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbD
            // 
            this.cbD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbD.FormattingEnabled = true;
            this.cbD.Location = new System.Drawing.Point(149, 217);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(121, 25);
            this.cbD.TabIndex = 25;
            this.cbD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbC
            // 
            this.cbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbC.FormattingEnabled = true;
            this.cbC.Location = new System.Drawing.Point(149, 195);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(121, 25);
            this.cbC.TabIndex = 25;
            this.cbC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbB
            // 
            this.cbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbB.FormattingEnabled = true;
            this.cbB.Location = new System.Drawing.Point(149, 165);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(121, 25);
            this.cbB.TabIndex = 25;
            this.cbB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbA
            // 
            this.cbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbA.FormattingEnabled = true;
            this.cbA.Location = new System.Drawing.Point(149, 139);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(121, 25);
            this.cbA.TabIndex = 25;
            this.cbA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Location = new System.Drawing.Point(125, 254);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(16, 15);
            this.lbE.TabIndex = 23;
            this.lbE.Text = "E.";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(125, 227);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(18, 15);
            this.lbD.TabIndex = 23;
            this.lbD.Text = "D.";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(125, 198);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(18, 15);
            this.lbC.TabIndex = 23;
            this.lbC.Text = "C.";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(125, 170);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(17, 15);
            this.lbB.TabIndex = 23;
            this.lbB.Text = "B.";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(125, 144);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(18, 15);
            this.lbA.TabIndex = 23;
            this.lbA.Text = "A.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(830, 46);
            this.dataGridView1.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "View";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(683, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(764, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtquest
            // 
            this.txtquest.Location = new System.Drawing.Point(93, 75);
            this.txtquest.Multiline = true;
            this.txtquest.Name = "txtquest";
            this.txtquest.Size = new System.Drawing.Size(830, 51);
            this.txtquest.TabIndex = 1;
            this.txtquest.TextChanged += new System.EventHandler(this.tquest_TextChanged);
            // 
            // cbno
            // 
            this.cbno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbno.FormattingEnabled = true;
            this.cbno.Location = new System.Drawing.Point(28, 75);
            this.cbno.Name = "cbno";
            this.cbno.Size = new System.Drawing.Size(46, 23);
            this.cbno.TabIndex = 0;
            this.cbno.SelectedIndexChanged += new System.EventHandler(this.cbno_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1058, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1139, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminQuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 481);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Location = new System.Drawing.Point(40, 100);
            this.Name = "AdminQuestionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminQuestion";
            this.Load += new System.EventHandler(this.AdminQuestionPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button1;
        private Panel panel2;
        private ComboBox cbno;
        private TextBox txtquest;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private Label lbA;
        private Label lbE;
        private Label lbD;
        private Label lbC;
        private Label lbB;
        private ComboBox cbA;
        private ComboBox cbE;
        private ComboBox cbD;
        private ComboBox cbC;
        private ComboBox cbB;
    }
}