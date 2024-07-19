using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_AiLaTrieuPhu.A_DAL;
using Game_AiLaTrieuPhu.B_BUS;

namespace Game_AiLaTrieuPhu.C_PRL
{
    public partial class GameForm : Form
    {
        GameServices sv = new GameServices();
        //list để lưu lại câu hỏi được lấy ra trong database
        List<int> selectQuestion = new List<int>();
        int chooseId;//id của câu hỏi đang được chọn tại thời điểm chơi
        int[] questionArr = new int[15] { 200, 400, 600, 1000, 2000, 3000, 6000, 10000, 14000, 22000, 30000, 40000, 60000, 85000, 150000 };
        int selectIndex = 0;
        int level = 1;//lever mặc định là 1
        int Timer = 30;//
        System.Media.SoundPlayer Sspl = new System.Media.SoundPlayer(@"D:\Chome_Tai_Ve\y2mate.com-Nhạc-hiệu-Ai-là-Triệu-Phú-2052008-3182010-572011-1962012.wav");
        public GameForm()
        {
            InitializeComponent();
        }



        private void btn_Play_Click(object sender, EventArgs e)
        {
            Sspl.Stop();

            timer2.Start();
            btn_200.BackColor = Color.LightBlue;//đổi màu cột mốc đầu
            btn_Play.Enabled = false;//disable  nút
            ptb_BacHoc.Enabled = true;
            ptb_5050.Enabled = true;
            ptb_Viewer.Enabled = true;
            ptb_Change.Enabled = true;
            RandomQuestionShow();


        }
        //Question question ;
        public void RandomQuestionShow()
        {
            lb_time.Text = "30";
            Timer = 30;
            timer2.Start();

            while (selectQuestion.Count < sv.countNumber(level))
            {
                Question question = sv.RamdomQuestion(level);
                if (!selectQuestion.Contains(question.Id))
                {
                    txt_Question.Text = question.QuestionText;
                    btn_A.Text = question.AnswerA;
                    btn_B.Text = question.AnswerB;
                    btn_C.Text = question.AnswerC;
                    btn_D.Text = question.AnsewerD;
                    selectQuestion.Add(question.Id);
                    chooseId = question.Id;//gán Id đang được chọn
                    //MessageBox.Show(""+ chooseId);
                    break;
                }
                else continue;

            }

        }

        public void CheckTrue(string ansew)
        {
            if (sv.checkDapan(chooseId, ansew))
            {
                if (selectIndex < 14)
                {
                    timer2.Stop();
                    MessageBox.Show("Đúng rồi");
                    //update tiền thắng
                    lb_money.Text = questionArr[selectIndex].ToString();
                    selectIndex++;

                    if (selectIndex == 10) { level = 3; selectQuestion.Clear(); }
                    else if (selectIndex == 5) { level = 2; selectQuestion.Clear(); };

                    RandomQuestionShow();


                    nhayButton();
                }
                else if (selectIndex == 14)
                {
                    timer2.Stop();
                    btn_150000.BackColor = Color.Gray;
                    //nhayButton();
                    MessageBox.Show("Chúc mừng bạn.\nBạn đã hoàn thành 15 câu hỏi và ra về với mức thưởng cao nhất của chương trình ");
                    Resetchuongtrinh();
                    selectQuestion.Clear();

                };

            }
            else
            {

                timer2.Stop();
                MessageBox.Show("Bạn ra về với số tiền là: " + lb_money.Text);

                Resetchuongtrinh();
                selectQuestion.Clear();
                DoiMau();




            };



        }
        public void Resetchuongtrinh()
        {
            txt_Question.Text = "";
            btn_A.Text = "";
            btn_B.Text = "";
            btn_C.Text = "";
            btn_D.Text = "";
            lb_time.Text = "30";
            btn_Play.Enabled = true;
            //chooseId = 1;
            level = 1;
            selectIndex = 0;
            lb_money.Text = "0000";
            ptb_BacHoc.Visible = true;
            ptb_5050.Visible = true;
            ptb_Viewer.Visible = true;
            ptb_Change.Visible = true;
            ptb_BacHoc.Enabled = false;
            ptb_5050.Enabled = false;
            ptb_Viewer.Enabled = false;
            ptb_Change.Enabled = false;
        }
        public void nhayButton()
        {

            if (selectIndex == 1)
            {
                btn_400.BackColor = Color.LightBlue;
                btn_200.BackColor = Color.Gainsboro;
            }
            else if (selectIndex == 2)
            {
                btn_600.BackColor = Color.LightBlue;
                btn_400.BackColor = Color.Gainsboro;
                //btn_200.BackColor = Color.Gainsboro;
            }
            else if (selectIndex == 3)
            {
                btn_1tr.BackColor = Color.LightBlue;
                btn_600.BackColor = Color.Gainsboro;

            }
            else if (selectIndex == 4)
            {
                btn_2000.BackColor = Color.LightBlue;
                btn_1tr.BackColor = Color.Gainsboro;

            }
            else if (selectIndex == 5)
            {
                btn_3000.BackColor = Color.LightBlue;
                btn_2000.BackColor = Color.Gainsboro;

            }
            else if (selectIndex == 6)
            {
                btn_6000.BackColor = Color.LightBlue;
                btn_3000.BackColor = Color.Silver;

            }
            else if (selectIndex == 7)
            {
                btn_10000.BackColor = Color.LightBlue;
                btn_6000.BackColor = Color.Silver;

            }
            else if (selectIndex == 8)
            {
                btn_14000.BackColor = Color.LightBlue;
                btn_10000.BackColor = Color.Silver;

            }
            else if (selectIndex == 9)
            {
                btn_22000.BackColor = Color.LightBlue;
                btn_14000.BackColor = Color.Silver;

            }
            else if (selectIndex == 10)
            {
                btn_30000.BackColor = Color.LightBlue;
                btn_22000.BackColor = Color.Silver;

            }
            else if (selectIndex == 11)
            {
                btn_40000.BackColor = Color.LightBlue;
                btn_30000.BackColor = Color.Gray;

            }
            else if (selectIndex == 12)
            {
                btn_60000.BackColor = Color.LightBlue;
                btn_40000.BackColor = Color.Gray;

            }
            else if (selectIndex == 13)
            {
                btn_85000.BackColor = Color.LightBlue;
                btn_60000.BackColor = Color.Gray;

            }
            else if (selectIndex == 14)
            {
                btn_150000.BackColor = Color.LightBlue;
                btn_85000.BackColor = Color.Gray;

            }
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            //if (CheckTrue("A")) btn_A.BackColor = Color.Green;

            CheckTrue("A");


            /* RandomQuestionShow();*/

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            //if (CheckTrue("C")) btn_C.BackColor = Color.Green;

            CheckTrue("C");
            /* RandomQuestionShow();*/
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            //if (CheckTrue("B")) btn_B.BackColor = Color.Green;

            CheckTrue("B");
            /* RandomQuestionShow();*/
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            CheckTrue("D");
            //if (CheckTrue("D")) btn_D.BackColor = Color.Green;


        }

        private void ptb_5050_Click(object sender, EventArgs e)
        {
            string trueAnsewr = sv.GetTrueAnswer(chooseId);
            Random r = new Random();
            int hold = r.Next(3);
            if (trueAnsewr == "A")
            {
                if (hold == 1) { btn_C.Text = ""; btn_D.Text = ""; }
                else if (hold == 2) { btn_B.Text = ""; btn_D.Text = ""; }
                else { btn_B.Text = ""; btn_C.Text = ""; }
            }
            else if (trueAnsewr == "B")
            {
                if (hold == 1) { btn_C.Text = ""; btn_D.Text = ""; }
                else if (hold == 2) { btn_A.Text = ""; btn_D.Text = ""; }
                else { btn_A.Text = ""; btn_C.Text = ""; }
            }
            else if (trueAnsewr == "C")
            {
                if (hold == 1) { btn_B.Text = ""; btn_D.Text = ""; }
                else if (hold == 2) { btn_A.Text = ""; btn_D.Text = ""; }
                else { btn_A.Text = ""; btn_B.Text = ""; }
            }
            else
            {
                if (hold == 1) { btn_B.Text = ""; btn_C.Text = ""; }
                else if (hold == 2) { btn_A.Text = ""; btn_C.Text = ""; }
                else { btn_A.Text = ""; btn_B.Text = ""; }
            }
            ptb_5050.Visible = false;//vísible là thuộc tính chỉ khả năng hiển thị của 1 control;
                                     // ptb_5050.Enabled = false;//chỉ khả năng thao tác 

        }

        private void ptb_BacHoc_Click(object sender, EventArgs e)
        {
            string trueAnswer = sv.GetTrueAnswer(chooseId);
            Random r = new Random();
            /*int r1 =   r.Next(100);
            int r2 = r.Next(100-r1);
            int r3 = r.Next(100-r2-r1);
            int r4 = 100-r3-r2-r1;
            MessageBox.Show($"A: {r1}\nB: {r2}\nC: {r3}\nD: {r4}");*/
            //thao túng tỷ lệ xác suất thua thấp
            int r2 = r.Next(0, 30);
            int r3 = r.Next(0, 30);
            int r4 = r.Next(0, 30);
            int rTrue = 100 - r2 - r3 - r4;
            string show;
            if (trueAnswer == "A") show = $"A: {rTrue}\nB: {r2}\nC: {r3}\nD: {r4}";
            else if (trueAnswer == "B") show = $"A: {r2}\nB: {rTrue}\nC: {r3}\nD: {r4}";
            else if (trueAnswer == "C") show = $"A: {r2}\nB: {r3}\nC: {rTrue}\nD: {r4}";
            else show = $"A: {r2}\nB: {r3}\nC: {r4}\nD: {rTrue}";
            timer2.Stop();
            MessageBox.Show(show);
            timer2.Start();
            ptb_BacHoc.Visible = false;
        }

        private void ptb_Viewer_Click(object sender, EventArgs e)
        {
            string trueAnswer = sv.GetTrueAnswer(chooseId);
            timer2.Stop();
            MessageBox.Show("Chuyên gia khuyên bạn chọn đáp án " + trueAnswer);
            timer2.Start();
            ptb_Viewer.Visible = false;
        }

        private void ptb_Change_Click(object sender, EventArgs e)
        {
            //Th1: cho k 1 câu
            /*//loát câu hỏi mới
            RandomQuestionShow();
            //update tiền hiển thị
            lb_money.Text = questionArr[selectIndex].ToString();
            //Thực hiện update selecIndex
            selectIndex++;
*/
            //th2 thay đổi câu hỏi
            RandomQuestionShow();
            ptb_Change.Visible = false;
        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            //khi nào timer chạy :khi bắt đầu câu hỏi mới 
            //timelimit : giảm dần từng dây 
            Timer--;
            //sét thuộc tính interval=1000
            timer2.Interval = 1000;
            lb_time.Text = Timer.ToString();
            //HẾT h thì báo thua cuộc
            if (lb_time.Text == "0")
            {
                timer2.Stop();
                MessageBox.Show("hết giờ, bạn đã ra về với số tiền : " + lb_money.Text);
                Resetchuongtrinh();
                selectQuestion.Clear();

                DoiMau();
            }

        }
        public void DoiMau()
        {
            btn_150000.BackColor = Color.Gray;
            btn_85000.BackColor = Color.Gray;
            btn_60000.BackColor = Color.Gray;
            btn_40000.BackColor = Color.Gray;
            btn_30000.BackColor = Color.Gray;
            btn_22000.BackColor = Color.Silver;
            btn_14000.BackColor = Color.Silver;
            btn_10000.BackColor = Color.Silver;
            btn_6000.BackColor = Color.Silver;
            btn_3000.BackColor = Color.Silver;
            btn_2000.BackColor = Color.Gainsboro;
            btn_1tr.BackColor = Color.Gainsboro;
            btn_600.BackColor = Color.Gainsboro;
            btn_400.BackColor = Color.Gainsboro;
            btn_200.BackColor = Color.Gainsboro;
        }
        
        private void GameForm_Load(object sender, EventArgs e)
        {
            // OpenFileDialog 
            ptb_BacHoc.Enabled = false;
            ptb_5050.Enabled = false;
            ptb_Viewer.Enabled = false;
            ptb_Change.Enabled = false;


            
            Sspl.Play();


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
