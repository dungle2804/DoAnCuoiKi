
namespace ThiTracNghiem
{
    partial class TracNghiem
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_4 = new System.Windows.Forms.RadioButton();
            this.lbAns = new System.Windows.Forms.ListBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(610, 333);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 31);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thời gian còn lại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số câu hỏi: 20";
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Items.AddRange(new object[] {
            "Phần mềm",
            "Phần cứng",
            "Mạng bảo mật"});
            this.cbxChuyenNganh.Location = new System.Drawing.Point(114, 391);
            this.cbxChuyenNganh.Margin = new System.Windows.Forms.Padding(2);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(136, 21);
            this.cbxChuyenNganh.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chọn chuyên ngành";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 367);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 20);
            this.txtID.TabIndex = 13;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(114, 341);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(136, 20);
            this.txtTen.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên người dự thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chương trình thi trắc nghiệm";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(596, 23);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(83, 67);
            this.txtTime.TabIndex = 20;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(523, 374);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(76, 31);
            this.btn_Next.TabIndex = 21;
            this.btn_Next.Text = "Tiếp theo";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(610, 374);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(79, 31);
            this.btn_Close.TabIndex = 22;
            this.btn_Close.Text = "Hoàn thành";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(436, 374);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(76, 31);
            this.btn_Prev.TabIndex = 23;
            this.btn_Prev.Text = "Trước đó";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(671, 68);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(7, 4);
            this.lbQuestion.TabIndex = 24;
            this.lbQuestion.Visible = false;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(9, 166);
            this.rbtn_1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(45, 26);
            this.rbtn_1.TabIndex = 25;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "A";
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(9, 203);
            this.rbtn_2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(45, 26);
            this.rbtn_2.TabIndex = 26;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "B";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_3
            // 
            this.rbtn_3.AutoSize = true;
            this.rbtn_3.Location = new System.Drawing.Point(9, 239);
            this.rbtn_3.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_3.Name = "rbtn_3";
            this.rbtn_3.Size = new System.Drawing.Size(45, 26);
            this.rbtn_3.TabIndex = 27;
            this.rbtn_3.TabStop = true;
            this.rbtn_3.Text = "C";
            this.rbtn_3.UseVisualStyleBackColor = true;
            // 
            // rbtn_4
            // 
            this.rbtn_4.AutoSize = true;
            this.rbtn_4.Location = new System.Drawing.Point(8, 274);
            this.rbtn_4.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_4.Name = "rbtn_4";
            this.rbtn_4.Size = new System.Drawing.Size(46, 26);
            this.rbtn_4.TabIndex = 28;
            this.rbtn_4.TabStop = true;
            this.rbtn_4.Text = "D";
            this.rbtn_4.UseVisualStyleBackColor = true;
            // 
            // lbAns
            // 
            this.lbAns.FormattingEnabled = true;
            this.lbAns.Location = new System.Drawing.Point(672, 166);
            this.lbAns.Margin = new System.Windows.Forms.Padding(2);
            this.lbAns.Name = "lbAns";
            this.lbAns.Size = new System.Drawing.Size(7, 4);
            this.lbAns.TabIndex = 29;
            this.lbAns.Visible = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(9, 68);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(598, 93);
            this.txtQuestion.TabIndex = 30;
            // 
            // TracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 416);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lbAns);
            this.Controls.Add(this.rbtn_4);
            this.Controls.Add(this.rbtn_3);
            this.Controls.Add(this.rbtn_2);
            this.Controls.Add(this.rbtn_1);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxChuyenNganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TracNghiem";
            this.Text = "Thi trac nghiem";
            this.Load += new System.EventHandler(this.TracNghiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxChuyenNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.RadioButton rbtn_3;
        private System.Windows.Forms.RadioButton rbtn_4;
        private System.Windows.Forms.ListBox lbAns;
        private System.Windows.Forms.TextBox txtQuestion;
    }
}

