using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
//using System.Linq;


namespace Start.Exam
{
    public partial class ConfiguratorForm : Form
    {
        public int tabcount;
        public TextBox[] TextBoxAns = new TextBox[8];
        public RadioButton[] RadioButton = new RadioButton[8];
        public TabPage myTabPage;
        public int CountAnswerInTest = 3; //Колличество ответов в тесте
        System.Xml.XmlReader xmlReader;

        string qw;     // вопрос

        // варианты ответа
        string[] answ = new string[3];

       // string pic;    // путь к файлу иллюстрации

        string fpath; // путь к файлу теста
        string fname; // файл теста
        //string ListPath = Directory.GetCurrentDirectory(); // путь к файлу списка
        //string ListXMLPath = "c:\\visual studio 2015\\exam\\exam\\Start.Exam\\bin\\Debug\\"; 
        string ListXMLPath = Directory.GetCurrentDirectory();
        //Directory.GetCurrentDirectory();

        string ListXMLName = "\\List.xml"; // файл списка
        int right; // правильный ответ (номер)
       // int otv;   // выбранный ответ (номер)
        //int n;     // количество правильных ответов
       // int nv;    // общее количество вопросов
       // int mode;  // состояние программы:
                   // 0 - начало работы;
                   // 1 - тестирование;
                   // 2 - завершение работы
                   // string LogStudent = @"\LogStudents.log";


        // конструктор формы
        // (см. также Program.cs )
        string[] XMLname = new string[500]; //при работе с Списком
        string[] Lname = new string[500];//при работе с Списком



        public ConfiguratorForm()
        {
            InitializeComponent();
            bt_addTabBox_Click(null,null);
            toolTip_NumberGoodAnswer.SetToolTip(textBox_NumberGoodAnswer, "Колличество правильных ответов для прохождения");
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txBoxDiscription.Text == "Описание теста") txBoxDiscription.Text = null;
            txBoxDiscription.ForeColor = Color.DarkGray;


        }


        private void txNameTest_Enter(object sender, EventArgs e)
        {
            if(txNameTest.Text == "Название предмета") txNameTest.Text = null;
            txNameTest.ForeColor = Color.DarkGray;
        }

        private void ConfiguratorForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button5;

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            //if (txBoxQuestion.Text == "Пишем вопрос тут") txBoxQuestion.Text = null;
            //txBoxQuestion.ForeColor = Color.DarkGray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
             //   if (txBoxAnswer1.Text == "Вариант ответа 1") txBoxAnswer1.Text = null;
            //txBoxAnswer1.ForeColor = Color.DarkGray;
        }

        private void txBoxAnswer2_Enter(object sender, EventArgs e)
        {
           // if (txBoxAnswer2.Text == "Вариант ответа 2") txBoxAnswer2.Text = null;
           // txBoxAnswer2.ForeColor = Color.DarkGray;
        }

        private void txBoxAnswer3_Enter(object sender, EventArgs e)
        {
           // if (txBoxAnswer3.Text == "Вариант ответа 3") txBoxAnswer3.Text = null;
           // txBoxAnswer3.ForeColor = Color.DarkGray;
        }

        private void rbAnswer1_Click(object sender, EventArgs e)
        {
            //rbAnswer2.Checked = false;
            //rbAnswer3.Checked = false;

        }

        private void rbAnswer2_Click(object sender, EventArgs e)
        {
           // rbAnswer1.Checked = false;
           // rbAnswer3.Checked = false;
        }

        private void rbAnswer3_Click(object sender, EventArgs e)
        {
           // rbAnswer2.Checked = false;
           // rbAnswer1.Checked = false;
        }

        private void textBox1_Enter_2(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.xml)|*.xml" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.xml)|*.xml" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void LoadXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {//Загрузка XML докента
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.xml)|*.xml" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
                this.button4_Click(null,e);

            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {//Выход
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {//Сохранение XML документа
            bt_saveXMLclick(sender, e);
        }

        private void bt_addTabBox_Click(object sender, EventArgs e)
        {

            //CountAnswerInTest = 3; //Колличество ответов в тесте
            string title = "Вопрос " + (tabControl1.TabCount + 1).ToString();
            //TabPage myTabPage = new TabPage(title);
            myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
            myTabPage.AutoScroll = true;

            myTabPage.BackColor = Color.FromArgb(47, 47, 47);
            tabcount = tabControl1.TabCount;
            //создаем 3 радиобуттана в новом табе
            TextBox TextBoxQuest = new TextBox();
            TextBoxQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            TextBoxQuest.ForeColor = System.Drawing.Color.DimGray;
            TextBoxQuest.Location = new System.Drawing.Point(27, 34);
            TextBoxQuest.Multiline = true;
            TextBoxQuest.Name = "txBoxQuestion" + tabcount;
            TextBoxQuest.Size = new System.Drawing.Size(528, 163);
            TextBoxQuest.TabIndex = 0;
            TextBoxQuest.Text = "Пишем вопрос тут " + tabcount + tabControl1.TabCount;
            TextBoxQuest.Tag = "TxBOXquery";
            TextBoxQuest.Enter += delegate {
                if (TextBoxQuest.Text == "Пишем вопрос тут") TextBoxQuest.Text = null;
                TextBoxQuest.ForeColor = Color.DarkGray;
            };

            myTabPage.Controls.Add(TextBoxQuest);
            for (int i = 0; i <= CountAnswerInTest-1; i++)
            {
                RadioButton[i] = new RadioButton();
                RadioButton[i].Name = "rbAnswer" + tabcount + i;
                RadioButton[i].Size = new System.Drawing.Size(14, 13);
               // RadioButton[i].Text = "";
                RadioButton[i].Location = new Point(36, 220 + (i * 30));
                RadioButton[i].Checked = false;
                RadioButton[i].Tag = "rbAnswer";
                myTabPage.Controls.Add(RadioButton[i]);
                
                TextBoxAns[i] = new TextBox();
                TextBoxAns[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
                TextBoxAns[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                TextBoxAns[i].ForeColor = System.Drawing.Color.DimGray;
                TextBoxAns[i].Location = new System.Drawing.Point(67, 218 + (i * 30));
                TextBoxAns[i].Name = "txBoxAnswer1" + tabcount + i;
                TextBoxAns[i].Size = new System.Drawing.Size(488, 20);
                TextBoxAns[i].TabIndex = 3;
                TextBoxAns[i].Text = "Ответ " + tabcount + i;
                TextBoxAns[i].ForeColor = Color.DarkGray;
                TextBoxAns[i].Enter += MyMethodCheckText;
                TextBoxAns[i].TextChanged += ChekWhatPress;
                TextBoxAns[i].KeyPress += ConfiguratorForm_KeyPress;
                TextBoxAns[i].Tag = "TxBOXAnswer";


                myTabPage.Controls.Add(TextBoxAns[i]);
            };

            //создаем 1 текстовое поле для вопроса
            
        }

        private void ConfiguratorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ChekWhatPress(object sender, EventArgs e)
        {
              
        
            var textbox = sender as TextBox;
          //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (textbox.Text.Length == 0 || textbox.Text == " " || textbox.Text == "" || textbox.Text == "   ")
             {
                 MessageBox.Show("Ошибка, поле не может быть пустым");
             }

        }

        private void MyMethodCheckText(object sender, EventArgs args)
        {
             var textbox = sender as TextBox;
                if (textbox != null && textbox.Text == "Ответ") textbox.Text = string.Empty;
           
        }

        private void chekTextBoxAns(int i)
        {
            
              //  if (TextBoxAns[i].Text == "Вариант ответа") TextBoxAns[i].Text = null;
              //  TextBoxAns[i].ForeColor = Color.DarkGray;
            
        }

        private void bt_delTabBox_Click(object sender, EventArgs e)
        {//удаление Таба
         // Removes the selected tab:
         // tabControl1.TabPages.Remove(tabControl1.TabIndex.);
         //this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);

            // Removes all the tabs:
            // tabControl1.TabPages.Clear();
           // TabPage myTabPage = new TabPage(title);
           // tabControl1.TabPages.Add(myTabPage);
           // tabControl1.SelectedTab = myTabPage;
            


            if (tabControl1 != null)
            {
                int tabcount = tabControl1.TabCount;

                if (tabcount <= 1)
                {
                    MessageBox.Show("Невозможно удалить последний вопрос");
                }
                else 
                    if (MessageBox.Show(string.Format("Вы уверены, что хотите удалить '{0}'?", tabControl1.SelectedTab.Text.ToString()),
                    "Удалить Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    TabPage selectedTab = tabControl1.SelectedTab;
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                    //tabControl1.TabPages.Remove.;
                    //tabControl1.TabPages.Remove(tabControl1.TabPages);
                    reindexTab();
                }

            }
            
            
        }
        public void reindexTab()
        {
            int Ntab = 1; // нумерация табов
            for (int i = 0;  i < tabControl1.TabCount; ++i)
            {
                
               tabControl1.TabPages[i].Text = "Вопрос " + Ntab++;
                
            };
           

        }

        private void bt_saveXMLclick(object sender, EventArgs e)
        {
            //сохраняем xml файл

            //раскоментировать когда буду готов
            /*
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файлы Excel (*.xml;) | *.xml;";
            saveFileDialog1.Title = "Save an Xml File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =(System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();

            }
            */
            
            
            
            int chTray; //проверяем. если есть пустые чекбоксы то не сохраняем.
            int chFileName;
            CheckCheckBox(out chTray);// запрашиваем у фу-ии
            if (chTray == 0)// проверяем что вернулось, если всё ок - выполняем.
            {
                CheckFileName(out chFileName);
                if (chFileName == 1)
                    CollectXMLFile(null, null);
                    AddToListEx(null, null);

            }

            DialogResult result;
            result = MessageBox.Show("Файл успешно сохранен! Хотите выйти из редактора?", "Оповещение", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void AddToListEx(object sender, EventArgs e)
        {
            LoadListXml();
        }
        private void CheckFileName(out int chFileName)
        {
            chFileName = 1;
            if (txBoxFileName.Text == "Название файла.xml" || txBoxFileName.Text == "" || txBoxFileName.Text == " " || txBoxFileName.Text == "  " || txBoxFileName.Text.Length == 0)
            {
                MessageBox.Show("Необходимо написать название файла!");
                chFileName = 0;
            }
            txBoxFileName.Text = System.Text.RegularExpressions.Regex.Replace(txBoxFileName.Text, @"\s+", "");
            txBoxFileName.Text = GetTranslit(txBoxFileName.Text);

        }
       

       
        public static string GetTranslit(string sourceText)
        {
            Dictionary<string, string> transliter = new Dictionary<string, string>();
            transliter.Add("а", "a");
            transliter.Add("б", "b");
            transliter.Add("в", "v");
            transliter.Add("г", "g");
            transliter.Add("д", "d");
            transliter.Add("е", "e");
            transliter.Add("ё", "yo");
            transliter.Add("ж", "zh");
            transliter.Add("з", "z");
            transliter.Add("и", "i");
            transliter.Add("й", "j");
            transliter.Add("к", "k");
            transliter.Add("л", "l");
            transliter.Add("м", "m");
            transliter.Add("н", "n");
            transliter.Add("о", "o");
            transliter.Add("п", "p");
            transliter.Add("р", "r");
            transliter.Add("с", "s");
            transliter.Add("т", "t");
            transliter.Add("у", "u");
            transliter.Add("ф", "f");
            transliter.Add("х", "h");
            transliter.Add("ц", "c");
            transliter.Add("ч", "ch");
            transliter.Add("ш", "sh");
            transliter.Add("щ", "sch");
            transliter.Add("ъ", "j");
            transliter.Add("ы", "i");
            transliter.Add("ь", "j");
            transliter.Add("э", "e");
            transliter.Add("ю", "yu");
            transliter.Add("я", "ya");
            transliter.Add("А", "A");
            transliter.Add("Б", "B");
            transliter.Add("В", "V");
            transliter.Add("Г", "G");
            transliter.Add("Д", "D");
            transliter.Add("Е", "E");
            transliter.Add("Ё", "Yo");
            transliter.Add("Ж", "Zh");
            transliter.Add("З", "Z");
            transliter.Add("И", "I");
            transliter.Add("Й", "J");
            transliter.Add("К", "K");
            transliter.Add("Л", "L");
            transliter.Add("М", "M");
            transliter.Add("Н", "N");
            transliter.Add("О", "O");
            transliter.Add("П", "P");
            transliter.Add("Р", "R");
            transliter.Add("С", "S");
            transliter.Add("Т", "T");
            transliter.Add("У", "U");
            transliter.Add("Ф", "F");
            transliter.Add("Х", "H");
            transliter.Add("Ц", "C");
            transliter.Add("Ч", "Ch");
            transliter.Add("Ш", "Sh");
            transliter.Add("Щ", "Sch");
            transliter.Add("Ъ", "J");
            transliter.Add("Ы", "I");
            transliter.Add("Ь", "J");
            transliter.Add("Э", "E");
            transliter.Add("Ю", "Yu");
            transliter.Add("Я", "Ya");

            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < sourceText.Length; i++)
            {
                if (transliter.ContainsKey(sourceText[i].ToString()))
                {
                    ans.Append(transliter[sourceText[i].ToString()]);
                }
                else
                {
                    ans.Append(sourceText[i].ToString());
                }
            }
            return ans.ToString();
        }
        private void bt_LoadXML_Click(object sender, EventArgs e)
        {
          
            //загрузка XML
            // System.Diagnostics.Debug.WriteLine(iBoxList1.SelectedIndices.ToString());
            //iBoxList1.SetSelected(3, true);

            /*string xmlPath;
            xmlPath = iBoxList1.SelectedItem.ToString();
            int idxml;
            idxml = iBoxList1.SelectedIndex;
            Debug.WriteLine(asd + idxml);
            Process.Start(ExamApp, XMLname[idxml]);
            this.Close();
            }
            */
            fpath = textBox1.Text; //путь к файлу закгрузки
            try
            {
                // получаем доступ к xml-документу
                xmlReader = new System.Xml.XmlTextReader(fpath);
                xmlReader.Read();

                // загрузить заголовок теста
                this.showHead();

                // загрузить описание теста
                this.showDescription();
            }

            catch (Exception exc) //если ошибка:
            {
                //   label1.Text = "Ошибка доступа к файлу  " +
                   MessageBox.Show("Ошибка доступа к файлу.\n" +
                    fpath  + "\n",
                    "Экзаменатор",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("Ошибка:" + exc);
           
            }

            //-End --------------
            
        }
        // читает вопрос из файла теста

        private Boolean getQwestionFromXml()
        {
            // считываем тэг <q>
            xmlReader.Read();

            if (xmlReader.Name == "q")
            {
                // здесь прочитан тэг <q>,
                // атрибут text которого содержит вопрос, а
                // атрибут src - имя файла иллюстрации.

                // извлекаем значение атрибутов:
                qw = xmlReader.GetAttribute("text");



                // входим внутрь узла
                xmlReader.Read();
                int i = 0;

                // считываем данные узла вопроса <q>
                while (xmlReader.Name != "q")
                {
                    xmlReader.Read();

                    // варианты ответа
                    if (xmlReader.Name == "a")
                    {
                        // запоминаем правильный ответ
                        if (xmlReader.GetAttribute("right") == "yes")
                            right = i;

                        // считываем вариант ответа
                        xmlReader.Read();
                        if (i < 3) answ[i] = xmlReader.Value;

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
        }



        // выводит название (заголовок) теста
        private void showHead()
        {
            // ищем узел <head>
            do xmlReader.Read();
            while (xmlReader.Name != "head");

            // считываем заголовок
            xmlReader.Read();

            // вывести название теста в заголовок окна
            txNameTest.Text = xmlReader.Value;

            // выходим из узла <head>
            xmlReader.Read();
        }

        // выводит описание теста
        private void showDescription()
        {
            // ищем узел <description>
            do
                xmlReader.Read();
            while (xmlReader.Name != "description");

            // считываем описание теста
            xmlReader.Read();

            // выводим описание теста
            // label1.Text = xmlReader.Value;
            txBoxDiscription.Text = xmlReader.Value;

            // выходим из узла <description>
            xmlReader.Read();

            // ищем узел вопросов <qw>
            do
                xmlReader.Read();
            while (xmlReader.Name != "qw");

            // входим внутрь узла
            xmlReader.Read();
        }
        private void CheckCheckBox(out int err)//проверем все ли чекбоксы выбраны
        {
            err = 0;
            string chekCk;
            string chekSt;

            for (int itab = 0; itab < tabControl1.TabCount; itab++)//перебираем табы
            {
                int allChek = 1;

                for (int i = 0; i <= CountAnswerInTest * 2; i++)//перебираем внутренние ответы
                {
                    chekSt = tabControl1.Controls[itab].Controls[i].Text;//собираем текст из полей
                    chekCk = tabControl1.Controls[itab].Controls[i].Tag.ToString(); //смотрим что это за поле
                    if (chekCk == "rbAnswer")//если равно rbAnswer то это поле с ответом
                        if (chekSt == "")//если текста нет, то скорее всего это радиобуттон\
                        {
                            Control ctrlb = tabControl1.Controls[itab].Controls[i]; //присваем чекбокс
                            if (Convert.ToString(ctrlb) == "System.Windows.Forms.RadioButton, Checked: True") //смотрим нажат или нет
                            {
                                Console.WriteLine("True");//debug
                                int ix = ++i;//убираем непонятные пустые поля
                                allChek++;
                            }
                            else //если чекбокс не нажат то пишем NO
                            {
                                int ix = ++i;//убираем непонятные пустые поля
                            }
                        }
                }
                if (allChek == 1)
                {
                    int Fitab = itab + 1;
                    MessageBox.Show("Не выбран чекбокс в вопросе: " + Fitab);
                    err = 1;
                    break;

                    // Console.WriteLine("Не выбран чекбокс в вопросе: " + tabControl1.Controls[itab]);
                }
            }
        }
        private void CollectXMLFile(object sender, EventArgs e)
        {


        //    string headXMLfile = "заменатор БГИ 2016"; //заголовок экзамена
        //    string descXMLfile; // описание экзамена
        //    string QtextXML; //вопрос
        //    string ansverXML1; //ответ 1
        //    string ansverXML2; //ответ 2
        //    string ansverXML3; //ответ 3
        //    string rightAnsverXML; //правильный ответ на вопрос
                                   //TextBox[] txQtextXML = new TextBox[8];
                                   // public TextBox[] TextBoxAns = new TextBox[8];
                                   //public RadioButton[] RadioButton = new RadioButton[8];


            //Собираем данные
            XDocument xdoc = new XDocument();
            XElement testXML = new XElement("test");//заголовок
            XElement headXML = new XElement("head", txNameTest.Text);//заголовок
            XElement discriptionXML = new XElement("description", txBoxDiscription.Text);//описание теста
            XElement qwXML = new XElement("qw");//начала вопросов
            //XElement questionXMLX = new XElement("q");// начало вопроса
           // XElement questionXMLAY = new XElement("a");// ответ
           // XElement questionXMLAN = new XElement("a");// ответ
           

            //XAttribute DiscriptionAttr = new XAttribute("text", "ПУСТО");//собираем текст
           // XAttribute questionXAttr = new XAttribute("text",null);//собираем текст
           // XAttribute questionSRCXAttr = new XAttribute("src", "ПУСТО");//собираем картинку
            XAttribute questionAAttrN = new XAttribute("right", "no");//собираем текст
            XAttribute questionAAttrY = new XAttribute("right", "yes");//собираем текст

            // TextBoxQuest.Tag = "TxBOXquery"; //Поле вопроса
            //RadioButton[i].Tag = "rbAnswer"; //Радиобуттон правильного ответа
            //TextBoxAns[i].Tag = "TxBOXAnswer";//Варианты ответа
            

            string ctrl = "";//собираем текст из полей
            string tagz = ""; //смотрим что это за поле
            int qcount = tabControl1.TabCount * (CountAnswerInTest * 2);

            for (int itab = 0; itab < tabControl1.TabCount; itab++)//перебираем табы
            {
                XElement questionXMLX = new XElement("q");// начало вопроса
                //questionXMLX.Add(questionXAttr);
                //questionXMLAN.Add(questionXAttr);
                for (int i = 0; i <= CountAnswerInTest * 2; i++)//перебираем внутренние ответы
                {
                   
                   
                    ctrl = tabControl1.Controls[itab].Controls[i].Text;//собираем текст из полей
                    tagz = tabControl1.Controls[itab].Controls[i].Tag.ToString(); //смотрим что это за поле
                    Console.WriteLine(tagz);//debug
                    if (tagz == "TxBOXquery") //если равно TxBOXquery то это поле с вопросом
                    {
                        Console.WriteLine(ctrl);//debug
                        Console.WriteLine(questionXMLX);//debug 
                                                        //  questionXMLX.Add("text",ctrl);//Добавляем его 
                        XAttribute questionXAttr = new XAttribute("text", ctrl);//собираем текст
                        XAttribute questionSRCXAttr = new XAttribute("src", "");
                        questionXMLX.Add(questionXAttr, questionSRCXAttr);
                                                                                // Console.WriteLine(questionXMLX);//debug


                        // questionXAttr = new XAttribute("text", ctrl);//собираем текст
                        // questionSRCXAttr = new XAttribute("src", "");//собираем картинку

                    }//пишем вопрос

                    if (tagz == "rbAnswer")//если равно rbAnswer то это поле с ответом
                        if (ctrl == "")//если текста нет, то скорее всего это радиобуттон\
                        {
                            string ctrlX;
                            

                            Control ctrlb = tabControl1.Controls[itab].Controls[i]; //присваем чекбокс
                            if (Convert.ToString(ctrlb) == "System.Windows.Forms.RadioButton, Checked: False") //смотрим нажат или нет
                            {
                                Console.WriteLine("False");//debug
                                                           // questionXMLA.Add(questionAAttrN);
                                int ix = ++i;//убираем непонятные пустые поля
                                 ctrlX = tabControl1.Controls[itab].Controls[ix].Text;//собираем текст из полей

                             
                                XElement questionXMLAN = new XElement("a", ctrlX);// ответ
                                
                                questionXMLAN.Add(questionAAttrN);
                                questionXMLX.Add(questionXMLAN, ctrl); //добавляем в xml

                            }
                            else //если чекбокс не нажат то пишем NO
                            {
                                int ix = ++i;//убираем непонятные пустые поля
                                 ctrlX = tabControl1.Controls[itab].Controls[ix].Text;//собираем текст из полей
                                Console.WriteLine("True");//debug
                                XElement questionXMLAY = new XElement("a", ctrlX);// ответ
                                questionXMLAY.Add(questionAAttrY);
                                questionXMLX.Add(questionXMLAY, ctrl);// добавляем в xml
                                    // questionXMLA.Add(questionAAttrY);

                                }
                        }
                    //   if (tagz == "TxBOXAnswer")
                    //  {
                    //       Console.WriteLine(ctrl);//debug
                    //                               // questionXAttr = new XAttribute("text", ctrl);//собираем текст
                    //    questionXMLX.Add(questionXMLAN, ctrl);
                    // questionSRCXAttr = new XAttribute("src", "");//собираем картинку
                    //   }//пишем вопрос


                    //  questionXMLA.Add(questionAAttr[i]);

                    //закончили перебирать внутренние поля



                 
                }
                
                qwXML.Add(questionXMLX);// добавляем всё в блок <qw>
                                        //qwXML.Add(questionXMLX);


            }//закончили перебирать табы
            XAttribute TLevelCountAAttr = new XAttribute("score", "1");
            XAttribute TLevelCountAAttr2 = new XAttribute("text", "Пройден");
            XElement TLevelsCount = new XElement("Levels");//задаем блок для оценок
            XElement TLevelCount = new XElement("Level", "1");//задаем блок для оценки 
            TLevelCount.Add(TLevelCountAAttr, TLevelCountAAttr2);
            TLevelsCount.Add(TLevelCount);

            testXML.Add(headXML);
            testXML.Add(discriptionXML);
            testXML.Add(qwXML);
            testXML.Add(TLevelsCount);
            xdoc.Add(testXML);

            xdoc.Save(txBoxFileName.Text+txLableXML.Text);
        }

        private void textBox_NumberGoodAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //запрет ввода текста кроме цифр
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar))) return;
            else
                e.Handled = true;
        }

        private void textBox_NumberGoodAnswer_Enter(object sender, EventArgs e)
        {
            if (textBox_NumberGoodAnswer.Text == "Колличество правильных ответов для прохождения теста") textBox_NumberGoodAnswer.Text = null;
            textBox_NumberGoodAnswer.ForeColor = Color.DarkGray;
            
        }

        private void toolTip_NumberGoodAnswer_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txNameTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfiguratorForm_Shown(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }
        private void LoadListXml()
        {
            try
            {
                // получаем доступ к xml-документу
                 FileStream stream = new FileStream(ListXMLPath + ListXMLName, FileMode.Open,
                            FileAccess.Read, FileShare.ReadWrite);
                string flist = ListXMLPath + ListXMLName;

                //readerSettings.CloseInput = true;
               // using (XmlReader reader = XmlReader.Create(new FileStream(archivePath, FileMode.Open), readerSettings)) 
                     
                     xmlReader = new System.Xml.XmlTextReader(stream);
                    xmlReader.Read();
                
                // загрузить заголовок теста
                this.showListToEditor();

                // загрузить описание теста
                // this.showDescription();
            }

            catch (Exception exc)
            {
                //   label1.Text = "Ошибка доступа к файлу  " +
//                MessageBox.Show(
 //               "Ошибка доступа к файлу  " + fpath + fname);

                MessageBox.Show("Ошибка доступа к файлу.\n" +
                    fpath + fname + "\n",
                    "Экзаменатор",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("Ошибка:" + exc);

            }

            //загружаем список
            LoadListToEditor();
            

        }
        private void showListToEditor()
        {

        }
        private Boolean LoadListToEditor()
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
                        if (i < 500)
                        {
                         
                              Lname[i] = xmlReader.Value;
                            //  listBox1.BeginUpdate(); // debug
                            //  listBox1.Items.Add(xmlReader.Value); // debug
                            //  listBox1.EndUpdate(); // debug
                            if (xmlReader.Value == txNameTest.Text)
                            {
                                DialogResult result;
                                result = MessageBox.Show("Такое имя уже существует! Заменить его?", "Предупреждение", MessageBoxButtons.YesNo);
                                if (result == System.Windows.Forms.DialogResult.No)
                                    break;
                                else
                                {
                                  
                                    xmlReader.Close();
                                    //Console.WriteLine("заменили xml!");
                                    var xDoc = new XmlDocument();
                                    xDoc.Load(ListXMLPath + ListXMLName);
                                    XmlNodeList adds = xDoc.GetElementsByTagName("a");
                                    foreach (XmlNode add in adds)
                                        if (add.InnerText == txNameTest.Text)
                                        {
                                            add.Attributes["right"].Value = txBoxFileName.Text;
                                            break;
                                        }
                                    xmlReader.Close();

                                    xDoc.Save(ListXMLPath + ListXMLName);
                                    return true;


                                }
                            }
                        }
                                                   // выходим из узла <a>
                                                    xmlReader.Read();
                        
                        i++;
                    }
                }

                /*          
                    XDocument doc = XDocument.Load(ListXMLPath + ListXMLName);
                    XElement List = new XElement("List",
                        new XElement("Llist",
                         new XElement("a",
                         new XAttribute("right", txBoxFileName.Text + txLableXML.Text), txNameTest)));
                    doc..Add(List);
                    doc.Save(ListXMLPath + ListXMLName);
                    */

                XDocument doc = XDocument.Load(ListXMLPath + ListXMLName);
                XNode xNodeTwo = doc.Root.FirstNode.NextNode;
                 XElement List = new XElement("a",
                     new XAttribute("right", txBoxFileName.Text + txLableXML.Text), txNameTest.Text);
                ((XElement)xNodeTwo).Element("a").AddBeforeSelf(List);
                doc.Save(ListXMLPath + ListXMLName);
                
                xmlReader.Close();
              

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

        private void ConfiguratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти?", "Тест БГИ", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
