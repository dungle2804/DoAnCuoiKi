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

namespace SoanDeThi_ChamDiem
{
    public partial class SoanDe : Form
    {
        List<Question> lstQuestion = new List<Question>();
        List<String> lstRandomQuestion = new List<String>();
        List<String> lstSelectedQuestion = new List<String>();

        List<AnswerA> lstAnswerA = new List<AnswerA>();
        List<AnswerB> lstAnswerB = new List<AnswerB>();
        List<AnswerC> lstAnswerC = new List<AnswerC>();
        List<AnswerD> lstAnswerD = new List<AnswerD>();
        List<TrueAnswer> lsttrueAnswers = new List<TrueAnswer>();

        List<UserAnswer> lstuserAnswers = new List<UserAnswer>();

        List<int> numbers = new List<int>(); // Random numbers

        public SoanDe()
        {
            InitializeComponent();
            
            LoadFileQuestion();
            LoadFileAnswer();
            LoadFileUserAnswer();
            
        }
        private void SoanDe_Load(object sender, EventArgs e)
        {

        }

        private void LoadFileUserAnswer()
        {
            XmlReader reader = XmlReader.Create("Result.xml");
            while (reader.ReadToFollowing("User"))
            {
                UserAnswer userAnswer = new UserAnswer();
                
                reader.ReadToFollowing("Name");
                userAnswer.Name = reader.ReadElementContentAsString();

                reader.ReadToFollowing("ID");
                userAnswer.ID = reader.ReadElementContentAsInt();

                reader.ReadToFollowing("Answer");
                userAnswer.Answer = reader.ReadElementContentAsString();
                lstuserAnswers.Add(userAnswer);
            }

            reader.Close();
            lbUserAnswer.DataSource = lstuserAnswers;

        }

        private void LoadFileQuestion()
        {
            XmlReader reader = XmlReader.Create("DeThi.xml");
            while (reader.ReadToFollowing("Question"))
            {
                //Question

                Question quest = new Question();
                quest.ID = int.Parse(reader.GetAttribute("ID"));
                reader.ReadToFollowing("content");
                quest.content = reader.ReadElementContentAsString();

                lstQuestion.Add(quest);
            }
            reader.Close();

            lbQuestion.DataSource = lstQuestion;
        }

        private void LoadFileAnswer()
        {
            XmlReader reader = XmlReader.Create("DeThi.xml");
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

                TrueAnswer trueAnswer = new TrueAnswer();
                reader.ReadToFollowing("result");
                trueAnswer.answer_True = reader.ReadElementContentAsString();
                lsttrueAnswers.Add(trueAnswer);
            }
            reader.Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (txtSoCauHoi.Text == "")
                MessageBox.Show("Vui lòng điền số câu hỏi cần tạo");

            else
            {
                Random_Test();
                SaveFileRandomTest();
                MessageBox.Show("Đề đã được tạo thành công!");
            }
        }

        private void SaveFileRandomTest()
        {
            XmlWriter writer = XmlWriter.Create("Test.xml", new XmlWriterSettings() { Indent = true });
            writer.WriteStartElement("test");

            for (int i = 0; i < int.Parse(txtSoCauHoi.Text); i++)
            {
                int ID = i + 1;
                writer.WriteStartElement("Question");
                writer.WriteAttributeString("ID", ID.ToString());
               
                writer.WriteStartElement("content");
                writer.WriteValue(lstQuestion[numbers[i]].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("A");
                writer.WriteValue(lstAnswerA[numbers[i]].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("B");
                writer.WriteValue(lstAnswerB[numbers[i]].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("C");
                writer.WriteValue(lstAnswerC[numbers[i]].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("D");
                writer.WriteValue(lstAnswerD[numbers[i]].ToString());
                writer.WriteEndElement();


                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
        }

        private void Random_Test()
        {
            Random rand = new Random();

            for (int i = 0; i < lstQuestion.Count - 1; i++)
            {
                int number = rand.Next(0, lstQuestion.Count - 1);
                while (numbers.Contains(number))
                {
                    number = rand.Next(0, lstQuestion.Count - 1);
                }
                numbers.Add(number);
            }
            for (int i = 0; i < int.Parse(txtSoCauHoi.Text); i++)
            {
                lstRandomQuestion.Add(lbQuestion.Items[numbers[i]].ToString());              
            }      

            listBox1.DataSource = lstRandomQuestion;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                     
            int index = lbQuestion.SelectedIndex;
            string A = lbQuestion.Items[index].ToString();
            
            
            if (lbViewQuestion.Items.Contains(A))
            {
                MessageBox.Show("Câu hỏi đã được chọn. Vui lòng chọn câu hỏi khác! ");
            }

            else 
            {
                lbViewQuestion.Items.Add(A);
            }                 
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
