using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ThiTracNghiem
{
    public partial class TracNghiem : Form
    {

        List<Question> lstQuestion = new List<Question>();
        List<AnswerA> lstAnswerA = new List<AnswerA>();
        List<AnswerB> lstAnswerB = new List<AnswerB>();
        List<AnswerC> lstAnswerC = new List<AnswerC>();
        List<AnswerD> lstAnswerD = new List<AnswerD>();

        List<string> lstUserAnswer = new List<string>();

        const int total_Time = 2; // Người ra đề điều chỉnh thời gian thi tại đây        
        int minute;
        int second;

        int Index = 0;

        public TracNghiem()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();

            second--;

            if (second == 0)
            {
                if (minute > 0)
                {
                    minute--;
                    second = 60;
                }

                else
                {
                    minute = 0;
                    second = 0;
                }
            }

            if ((minute == 0) && (second == 0))
            {
                Timer_Countdown();
                this.timer1.Enabled = false;
                LuuBaiThi();
                MessageBox.Show("Bạn đã hết thời gian làm bài!");                
            }

            else
            {
                Timer_Countdown();
            }
        }

        private void Timer_Countdown()
        {
            string _minute;
            string _second;

            if (minute < 10)
                _minute = "0" + minute.ToString();
            _minute = minute.ToString();

            if (second < 10)
                _second = "0" + second.ToString();
            _second = second.ToString();

            txtTime.Text = _minute + ":" + _second;
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //Người dùng bắt buộc phải nhập tên và mã số, chọn chuyên ngành
            if (txtTen.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ tên và mã số ");
                this.timer1.Enabled = false;
            }    
            //Cho phép người dùng thực hiện bài thi 
            else
            {
                LoadQuestionListXML();
                LoadAnswerListXML();
                this.timer1.Enabled = true;
            }


            // Đếm ngược thời gian thực hiện bài thi
            minute = total_Time - 1;
            second = 59;
            Timer_Countdown();

            btn_Next.Enabled = true;
            rbtn_1.Enabled = true;
            rbtn_2.Enabled = true;
            rbtn_3.Enabled = true;
            rbtn_4.Enabled = true;

        }

        private void LoadAnswerListXML()
        {
            XmlReader reader = XmlReader.Create("Test.xml");
            while (reader.ReadToFollowing("Question"))
            {
                //Answer

                AnswerA answerA = new AnswerA();
                reader.ReadToFollowing("A");
                answerA.answer_A = reader.ReadElementContentAsString();
                lstAnswerA.Add(answerA);

                AnswerB answerB = new AnswerB();
                reader.ReadToFollowing("B");
                answerB.answer_B = reader.ReadElementContentAsString();
                lstAnswerB.Add(answerB);

                AnswerC answerC = new AnswerC();
                reader.ReadToFollowing("C");
                answerC.answer_C = reader.ReadElementContentAsString();
                lstAnswerC.Add(answerC);

                AnswerD answerD = new AnswerD();
                reader.ReadToFollowing("D");
                answerD.answer_D = reader.ReadElementContentAsString();
                lstAnswerD.Add(answerD);

            }
            reader.Close();

            rbtn_1.Text = lstAnswerA[0].ToString();
            rbtn_2.Text = lstAnswerB[0].ToString();
            rbtn_3.Text = lstAnswerC[0].ToString();
            rbtn_4.Text = lstAnswerD[0].ToString();
        }

        private void LoadQuestionListXML()
        {
            XmlReader reader = XmlReader.Create("Test.xml");
            while (reader.ReadToFollowing("Question"))
            {
                //Question
                
                Question quest = new Question();
                quest.ID = int.Parse(reader.GetAttribute("ID"));
                reader.ReadToFollowing("content");
                quest.question = reader.ReadElementContentAsString();

                lstQuestion.Add(quest);
            }
            reader.Close();

            txtQuestion.Text = lstQuestion[0].ToString();
        }

        private void TracNghiem_Load(object sender, EventArgs e)
        {
            
            btnStart.Enabled = true;
            btn_Next.Enabled = false;
            btn_Prev.Enabled = false;
            btn_Close.Enabled = false;
            rbtn_1.Enabled = false;
            rbtn_2.Enabled = false;
            rbtn_3.Enabled = false;
            rbtn_4.Enabled = false;
        }

        
        private void btn_Next_Click(object sender, EventArgs e)
        {
            
            Index++;
           
            if (Index < lstQuestion.Count)
            {
                txtQuestion.Text = lstQuestion[Index].ToString();
                rbtn_1.Text = lstAnswerA[Index].ToString();
                rbtn_2.Text = lstAnswerB[Index].ToString();
                rbtn_3.Text = lstAnswerC[Index].ToString();
                rbtn_4.Text = lstAnswerD[Index].ToString();
               
            }

            else
                Index = lstQuestion.Count -1;

            btnStart.Enabled = false;

            SaveAnswer();
            Reset_radioButton();
            
           
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            Index--;
            if (Index > -1)
            {
                txtQuestion.Text = lstQuestion[(Index)].ToString();
                rbtn_1.Text = lstAnswerA[(Index)].ToString();
                rbtn_2.Text = lstAnswerB[(Index)].ToString();
                rbtn_3.Text = lstAnswerC[(Index)].ToString();
                rbtn_4.Text = lstAnswerD[(Index)].ToString();
            }

            else
                Index = 0;
            
            //SaveAnswer();
            Reset_radioButton();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thí sinh đã hoàn thành baì thi!");
            LuuBaiThi();
            this.Close();
        }

        
        private void Reset_radioButton()
        {           
            rbtn_1.Checked = false;
            rbtn_2.Checked = false;
            rbtn_3.Checked = false;
            rbtn_4.Checked = false;

            rbtn_1.Enabled = true;
            rbtn_2.Enabled = true;
            rbtn_3.Enabled = true;
            rbtn_4.Enabled = true;


            btn_Next.Enabled = true;
            btn_Prev.Enabled = true;
            btn_Close.Enabled = true;
        }

        public void SaveAnswer()
        {            
            string ANS;
            if (rbtn_1.Checked)
                ANS = "A";

            else if (rbtn_2.Checked)

                ANS = "B";

            else if (rbtn_3.Checked)
                ANS = "C";


            else if (rbtn_4.Checked)
                ANS = "D";

            else
                ANS = "0";

            lstUserAnswer.Add(ANS);
        }


        private void LuuBaiThi()
        {
            SaveAnswer(); //Goi lan 2 de luu dap an cuoi cung

            XmlWriter writer = XmlWriter.Create("Result.xml", new XmlWriterSettings() { Indent = true });
            
            writer.WriteStartElement("test");
            
            writer.WriteStartElement("User");
           
            writer.WriteStartElement("Name");
            writer.WriteValue(txtTen.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("ID");
            writer.WriteValue(txtID.Text);
            writer.WriteEndElement();
           
                
            writer.WriteStartElement("Answer");
            writer.WriteValue(lstUserAnswer);
            writer.WriteEndElement();
            
            writer.WriteEndElement();
            
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
