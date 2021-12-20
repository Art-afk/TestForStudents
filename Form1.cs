using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Start.Exam
{
    public partial class Form1 : Form
    {
        // путь к файлу теста
        // string fpath = "c:\\visual studio 2015\\exam\\exam\\Start.Exam\\bin\\Debug\\";
        // string BDpath = "c:\\visual studio 2015\\exam\\exam\\exam\\bin\\Debug\\";
        // string ExamApp = "c:\\visual studio 2015\\exam\\exam\\exam\\bin\\Debug\\exam.exe";  
        //Directory.GetCurrentDirectory();;
        //string fpath = "c:\\visual studio 2015\\exam\\exam\\Start.Exam\\bin\\Debug\\";
        string fpath = Directory.GetCurrentDirectory();
        string BDpath = Directory.GetCurrentDirectory();
         string ExamApp = Directory.GetCurrentDirectory() + "\\exam.exe";  
       

        string fname = "\\List.xml"; // файл теста

        // XmlReader обеспечивает чтение данных xml-файла
        System.Xml.XmlReader xmlReader;

        //string qw;     // вопрос
        //string srcq;    // путь к файлу иллюстрации
        string[] Lname = new string[500];
        string[] XMLname = new string[500];
        //int right; // правильный ответ (номер)


        public Form1()
        {

            InitializeComponent();
            
           LoadList();
            
        }
        private void LoadList()
        {
            try
            {
                // получаем доступ к xml-документу
                xmlReader = new System.Xml.XmlTextReader(fpath + fname);
                xmlReader.Read();



                // загрузить заголовок теста
                this.showHead();

                // загрузить описание теста
                // this.showDescription();
            }

            catch (Exception exc)
            {
                //   label1.Text = "Ошибка доступа к файлу  " +
                label1.Text = "Ошибка доступа к файлу  " +
                fpath + fname;

                MessageBox.Show("Ошибка доступа к файлу.\n" +
                    fpath + fname + "\n",
                    "Экзаменатор",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("Ошибка:" + exc);

            }

            //загружаем список
            getQw();
        }

        private void showHead()
        {
            // ищем узел <head>
            do xmlReader.Read();
            while (xmlReader.Name != "head");

            // считываем заголовок
            xmlReader.Read();

            // вывести название теста в заголовок окна
            this.Text = xmlReader.Value;

            // выходим из узла <head>
            xmlReader.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(iBoxList1.SelectedIndices.ToString());
            //iBoxList1.SetSelected(3, true);
            
            string asd;
            asd = iBoxList1.SelectedItem.ToString();
            int idxml;
            idxml = iBoxList1.SelectedIndex;
            Debug.WriteLine(asd + idxml);
            Process.Start(ExamApp, XMLname[idxml]);
            this.Close();


        }

        // читает вопрос из файла теста
        private Boolean getQw()
        {
            do
                xmlReader.Read();
            while (xmlReader.Name != "Llist");
         
            
            //-----------------
            if (xmlReader.Name == "Llist")
            {

                // входим внутрь узла Llist
                xmlReader.Read();
                int i = 0;

                // считываем данные узла вопроса <q>
                while (xmlReader.Name != "Llist")
                {
                    xmlReader.Read();

                    // предметы
                    if (xmlReader.Name == "a")
                    {
                        // считываем файлы предметов
                        if (i < 500)
                        {
                            XMLname[i] = xmlReader.GetAttribute("right");
                            if (!XMLname[i].Equals(string.Empty)) XMLname[i] = XMLname[i];

                        }
                        
                        // считываем названия предметов
                        xmlReader.Read();
                        if (i < 500) {
                         //   XMLname[i] = xmlReader.GetAttribute("right");
                           // if (!XMLname[i].Equals(string.Empty)) XMLname[i] = fpath + XMLname[i];
                            Lname[i] = xmlReader.Value;
                            iBoxList1.BeginUpdate();
                            iBoxList1.Items.Add(xmlReader.Value);
                            iBoxList1.EndUpdate();
                        }
                     

                        // выходим из узла <a>
                        xmlReader.Read();

                        i++;
                    }
                }

                // выходим из узла вопроса <q>
                xmlReader.Read();

                return true;
            }
            // если считанный тэг не является
            // тэгом вопроса <q>
            else
                return false;
            //---------------








        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            PasswordForm PasswordForm = new PasswordForm();
            // Application.Run(new PasswordForm());

            PasswordForm.StartPosition = FormStartPosition.CenterScreen;

            // Show the settings form
            PasswordForm.Show();

            PasswordForm.FormClosed += new FormClosedEventHandler(PasswordForm_FormClosed);

            xmlReader.Close();
            this.Hide();
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            xmlReader.Close();
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //iBoxList1.BeginUpdate();
        //iBoxList1.Items.Add(qw);
        //iBoxList1.EndUpdate();



    } //class Form1
} //namespace
