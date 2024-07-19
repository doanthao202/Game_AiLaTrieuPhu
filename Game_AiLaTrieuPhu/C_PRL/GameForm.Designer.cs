namespace Game_AiLaTrieuPhu.C_PRL
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            groupBox1 = new GroupBox();
            btn_D = new Button();
            btn_C = new Button();
            btn_B = new Button();
            btn_A = new Button();
            txt_Question = new TextBox();
            lb_money = new Label();
            lb_time = new Label();
            groupBox2 = new GroupBox();
            btn_Play = new Button();
            btn_150000 = new Button();
            btn_85000 = new Button();
            btn_60000 = new Button();
            btn_40000 = new Button();
            btn_30000 = new Button();
            btn_22000 = new Button();
            btn_14000 = new Button();
            btn_10000 = new Button();
            btn_6000 = new Button();
            btn_3000 = new Button();
            btn_2000 = new Button();
            btn_1tr = new Button();
            btn_600 = new Button();
            btn_400 = new Button();
            btn_200 = new Button();
            groupBox3 = new GroupBox();
            ptb_Change = new PictureBox();
            ptb_BacHoc = new PictureBox();
            ptb_Viewer = new PictureBox();
            ptb_5050 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_BacHoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_D);
            groupBox1.Controls.Add(btn_C);
            groupBox1.Controls.Add(btn_B);
            groupBox1.Controls.Add(btn_A);
            groupBox1.Controls.Add(txt_Question);
            groupBox1.Font = new Font("Oswald", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 505);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Câu hỏi & đáp án";
            // 
            // btn_D
            // 
            btn_D.BackColor = Color.Silver;
            btn_D.ForeColor = Color.Black;
            btn_D.Location = new Point(438, 389);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(220, 60);
            btn_D.TabIndex = 4;
            btn_D.UseVisualStyleBackColor = false;
            btn_D.Click += btn_D_Click;
            // 
            // btn_C
            // 
            btn_C.BackColor = Color.Silver;
            btn_C.ForeColor = Color.Black;
            btn_C.Location = new Point(74, 389);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(218, 60);
            btn_C.TabIndex = 3;
            btn_C.UseVisualStyleBackColor = false;
            btn_C.Click += btn_C_Click;
            // 
            // btn_B
            // 
            btn_B.BackColor = Color.Silver;
            btn_B.ForeColor = Color.Black;
            btn_B.Location = new Point(438, 288);
            btn_B.Name = "btn_B";
            btn_B.Size = new Size(220, 60);
            btn_B.TabIndex = 2;
            btn_B.UseVisualStyleBackColor = false;
            btn_B.Click += btn_B_Click;
            // 
            // btn_A
            // 
            btn_A.BackColor = Color.Silver;
            btn_A.ForeColor = Color.Black;
            btn_A.Location = new Point(74, 288);
            btn_A.Name = "btn_A";
            btn_A.Size = new Size(218, 60);
            btn_A.TabIndex = 1;
            btn_A.UseVisualStyleBackColor = false;
            btn_A.Click += btn_A_Click;
            // 
            // txt_Question
            // 
            txt_Question.BackColor = Color.Pink;
            txt_Question.Location = new Point(22, 38);
            txt_Question.Multiline = true;
            txt_Question.Name = "txt_Question";
            txt_Question.ReadOnly = true;
            txt_Question.Size = new Size(724, 231);
            txt_Question.TabIndex = 0;
            // 
            // lb_money
            // 
            lb_money.AutoSize = true;
            lb_money.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_money.ForeColor = Color.LightCoral;
            lb_money.Location = new Point(509, 148);
            lb_money.Name = "lb_money";
            lb_money.Size = new Size(115, 53);
            lb_money.TabIndex = 6;
            lb_money.Text = "0000";
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_time.ForeColor = Color.LightCoral;
            lb_time.Location = new Point(118, 148);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(69, 53);
            lb_time.TabIndex = 5;
            lb_time.Text = "30";
            lb_time.Click += lb_time_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Pink;
            groupBox2.Controls.Add(btn_Play);
            groupBox2.Controls.Add(btn_150000);
            groupBox2.Controls.Add(btn_85000);
            groupBox2.Controls.Add(btn_60000);
            groupBox2.Controls.Add(btn_40000);
            groupBox2.Controls.Add(btn_30000);
            groupBox2.Controls.Add(btn_22000);
            groupBox2.Controls.Add(btn_14000);
            groupBox2.Controls.Add(btn_10000);
            groupBox2.Controls.Add(btn_6000);
            groupBox2.Controls.Add(btn_3000);
            groupBox2.Controls.Add(btn_2000);
            groupBox2.Controls.Add(btn_1tr);
            groupBox2.Controls.Add(btn_600);
            groupBox2.Controls.Add(btn_400);
            groupBox2.Controls.Add(btn_200);
            groupBox2.Font = new Font("Oswald", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(781, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 757);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách 15 câu hỏi và các mức thưởng";
            // 
            // btn_Play
            // 
            btn_Play.BackColor = Color.LightPink;
            btn_Play.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Play.ForeColor = Color.FromArgb(255, 128, 128);
            btn_Play.Location = new Point(86, 707);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(224, 44);
            btn_Play.TabIndex = 16;
            btn_Play.Text = "Bắt đầu chơi";
            btn_Play.UseVisualStyleBackColor = false;
            btn_Play.Click += btn_Play_Click;
            // 
            // btn_150000
            // 
            btn_150000.BackColor = Color.Gray;
            btn_150000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_150000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_150000.Location = new Point(17, 26);
            btn_150000.Name = "btn_150000";
            btn_150000.Size = new Size(338, 37);
            btn_150000.TabIndex = 15;
            btn_150000.Text = "15: 150.000";
            btn_150000.UseVisualStyleBackColor = false;
            // 
            // btn_85000
            // 
            btn_85000.BackColor = Color.Gray;
            btn_85000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_85000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_85000.Location = new Point(17, 71);
            btn_85000.Name = "btn_85000";
            btn_85000.Size = new Size(338, 37);
            btn_85000.TabIndex = 14;
            btn_85000.Text = "14: 85.000";
            btn_85000.UseVisualStyleBackColor = false;
            // 
            // btn_60000
            // 
            btn_60000.BackColor = Color.Gray;
            btn_60000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_60000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_60000.Location = new Point(17, 116);
            btn_60000.Name = "btn_60000";
            btn_60000.Size = new Size(338, 37);
            btn_60000.TabIndex = 13;
            btn_60000.Text = "13: 60.000";
            btn_60000.UseVisualStyleBackColor = false;
            // 
            // btn_40000
            // 
            btn_40000.BackColor = Color.Gray;
            btn_40000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_40000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_40000.Location = new Point(17, 161);
            btn_40000.Name = "btn_40000";
            btn_40000.Size = new Size(338, 37);
            btn_40000.TabIndex = 12;
            btn_40000.Text = "12: 40.000";
            btn_40000.UseVisualStyleBackColor = false;
            // 
            // btn_30000
            // 
            btn_30000.BackColor = Color.Gray;
            btn_30000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_30000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_30000.Location = new Point(17, 206);
            btn_30000.Name = "btn_30000";
            btn_30000.Size = new Size(338, 37);
            btn_30000.TabIndex = 11;
            btn_30000.Text = "11: 30.000";
            btn_30000.UseVisualStyleBackColor = false;
            // 
            // btn_22000
            // 
            btn_22000.BackColor = Color.Silver;
            btn_22000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_22000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_22000.Location = new Point(17, 251);
            btn_22000.Name = "btn_22000";
            btn_22000.Size = new Size(338, 37);
            btn_22000.TabIndex = 10;
            btn_22000.Text = "10: 22.000";
            btn_22000.UseVisualStyleBackColor = false;
            // 
            // btn_14000
            // 
            btn_14000.BackColor = Color.Silver;
            btn_14000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_14000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_14000.Location = new Point(17, 296);
            btn_14000.Name = "btn_14000";
            btn_14000.Size = new Size(338, 37);
            btn_14000.TabIndex = 9;
            btn_14000.Text = "9: 14.000";
            btn_14000.UseVisualStyleBackColor = false;
            // 
            // btn_10000
            // 
            btn_10000.BackColor = Color.Silver;
            btn_10000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_10000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_10000.Location = new Point(17, 341);
            btn_10000.Name = "btn_10000";
            btn_10000.Size = new Size(338, 37);
            btn_10000.TabIndex = 7;
            btn_10000.Text = "8: 10.000";
            btn_10000.UseVisualStyleBackColor = false;
            // 
            // btn_6000
            // 
            btn_6000.BackColor = Color.Silver;
            btn_6000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_6000.Location = new Point(17, 386);
            btn_6000.Name = "btn_6000";
            btn_6000.Size = new Size(338, 37);
            btn_6000.TabIndex = 6;
            btn_6000.Text = "7: 6.000";
            btn_6000.UseVisualStyleBackColor = false;
            // 
            // btn_3000
            // 
            btn_3000.BackColor = Color.Silver;
            btn_3000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_3000.Location = new Point(17, 431);
            btn_3000.Name = "btn_3000";
            btn_3000.Size = new Size(338, 37);
            btn_3000.TabIndex = 5;
            btn_3000.Text = "6: 3.000";
            btn_3000.UseVisualStyleBackColor = false;
            // 
            // btn_2000
            // 
            btn_2000.BackColor = Color.FromArgb(224, 224, 224);
            btn_2000.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2000.ForeColor = Color.FromArgb(255, 128, 128);
            btn_2000.Location = new Point(17, 476);
            btn_2000.Name = "btn_2000";
            btn_2000.Size = new Size(338, 37);
            btn_2000.TabIndex = 4;
            btn_2000.Text = "5: 2.000";
            btn_2000.UseVisualStyleBackColor = false;
            // 
            // btn_1tr
            // 
            btn_1tr.BackColor = Color.FromArgb(224, 224, 224);
            btn_1tr.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1tr.ForeColor = Color.FromArgb(255, 128, 128);
            btn_1tr.Location = new Point(17, 521);
            btn_1tr.Name = "btn_1tr";
            btn_1tr.Size = new Size(338, 37);
            btn_1tr.TabIndex = 3;
            btn_1tr.Text = "4: 1.000";
            btn_1tr.UseVisualStyleBackColor = false;
            // 
            // btn_600
            // 
            btn_600.BackColor = Color.FromArgb(224, 224, 224);
            btn_600.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_600.ForeColor = Color.FromArgb(255, 128, 128);
            btn_600.Location = new Point(17, 566);
            btn_600.Name = "btn_600";
            btn_600.Size = new Size(338, 37);
            btn_600.TabIndex = 2;
            btn_600.Text = "3: 600";
            btn_600.UseVisualStyleBackColor = false;
            // 
            // btn_400
            // 
            btn_400.BackColor = Color.FromArgb(224, 224, 224);
            btn_400.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_400.ForeColor = Color.FromArgb(255, 128, 128);
            btn_400.Location = new Point(17, 611);
            btn_400.Name = "btn_400";
            btn_400.Size = new Size(338, 37);
            btn_400.TabIndex = 1;
            btn_400.Text = "2: 400";
            btn_400.UseVisualStyleBackColor = false;
            // 
            // btn_200
            // 
            btn_200.BackColor = Color.Gainsboro;
            btn_200.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_200.ForeColor = Color.FromArgb(255, 128, 128);
            btn_200.Location = new Point(17, 656);
            btn_200.Name = "btn_200";
            btn_200.Size = new Size(338, 37);
            btn_200.TabIndex = 0;
            btn_200.Text = "1: 200";
            btn_200.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lb_money);
            groupBox3.Controls.Add(ptb_Change);
            groupBox3.Controls.Add(lb_time);
            groupBox3.Controls.Add(ptb_BacHoc);
            groupBox3.Controls.Add(ptb_Viewer);
            groupBox3.Controls.Add(ptb_5050);
            groupBox3.Font = new Font("Oswald", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(13, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(763, 217);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thời gian và quyền trợ giúp, tiền đang có";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // ptb_Change
            // 
            ptb_Change.Image = (Image)resources.GetObject("ptb_Change.Image");
            ptb_Change.Location = new Point(634, 54);
            ptb_Change.Name = "ptb_Change";
            ptb_Change.Size = new Size(117, 91);
            ptb_Change.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Change.TabIndex = 3;
            ptb_Change.TabStop = false;
            ptb_Change.Click += ptb_Change_Click;
            // 
            // ptb_BacHoc
            // 
            ptb_BacHoc.Image = (Image)resources.GetObject("ptb_BacHoc.Image");
            ptb_BacHoc.Location = new Point(432, 54);
            ptb_BacHoc.Name = "ptb_BacHoc";
            ptb_BacHoc.Size = new Size(117, 91);
            ptb_BacHoc.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_BacHoc.TabIndex = 2;
            ptb_BacHoc.TabStop = false;
            ptb_BacHoc.Click += ptb_BacHoc_Click;
            // 
            // ptb_Viewer
            // 
            ptb_Viewer.Image = (Image)resources.GetObject("ptb_Viewer.Image");
            ptb_Viewer.Location = new Point(221, 54);
            ptb_Viewer.Name = "ptb_Viewer";
            ptb_Viewer.Size = new Size(117, 91);
            ptb_Viewer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Viewer.TabIndex = 1;
            ptb_Viewer.TabStop = false;
            ptb_Viewer.Click += ptb_Viewer_Click;
            // 
            // ptb_5050
            // 
            ptb_5050.Image = (Image)resources.GetObject("ptb_5050.Image");
            ptb_5050.Location = new Point(35, 54);
            ptb_5050.Name = "ptb_5050";
            ptb_5050.Size = new Size(117, 91);
            ptb_5050.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_5050.TabIndex = 0;
            ptb_5050.TabStop = false;
            ptb_5050.Click += ptb_5050_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 772);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_BacHoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_money;
        private Label lb_time;
        private Button btn_D;
        private Button btn_C;
        private Button btn_B;
        private Button btn_A;
        private TextBox txt_Question;
        private GroupBox groupBox2;
        private Button btn_Play;
        private Button btn_150000;
        private Button btn_85000;
        private Button btn_60000;
        private Button btn_40000;
        private Button btn_30000;
        private Button btn_22000;
        private Button btn_14000;
        private Button btn_10000;
        private Button btn_6000;
        private Button btn_3000;
        private Button btn_2000;
        private Button btn_1tr;
        private Button btn_600;
        private Button btn_400;
        private Button btn_200;
        private GroupBox groupBox3;
        private PictureBox ptb_Change;
        private PictureBox ptb_BacHoc;
        private PictureBox ptb_Viewer;
        private PictureBox ptb_5050;
        private System.Windows.Forms.Timer timer2;
    }
}