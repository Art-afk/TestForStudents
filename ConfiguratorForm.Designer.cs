namespace Start.Exam
{
    partial class ConfiguratorForm
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
            this.txBoxDiscription = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txNameTest = new System.Windows.Forms.TextBox();
            this.bt_addTabBox = new System.Windows.Forms.Button();
            this.bt_delTabBox = new System.Windows.Forms.Button();
            this.bt_saveXML = new System.Windows.Forms.Button();
            this.bt_LoadXML = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_NumberGoodAnswer = new System.Windows.Forms.TextBox();
            this.toolTip_NumberGoodAnswer = new System.Windows.Forms.ToolTip(this.components);
            this.txBoxFileName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txLableXML = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txBoxDiscription
            // 
            this.txBoxDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txBoxDiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBoxDiscription.ForeColor = System.Drawing.Color.DimGray;
            this.txBoxDiscription.Location = new System.Drawing.Point(274, 81);
            this.txBoxDiscription.Name = "txBoxDiscription";
            this.txBoxDiscription.Size = new System.Drawing.Size(352, 20);
            this.txBoxDiscription.TabIndex = 0;
            this.txBoxDiscription.Text = "Описание теста";
            this.txBoxDiscription.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(145, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // txNameTest
            // 
            this.txNameTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txNameTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNameTest.ForeColor = System.Drawing.Color.DimGray;
            this.txNameTest.Location = new System.Drawing.Point(274, 53);
            this.txNameTest.Name = "txNameTest";
            this.txNameTest.Size = new System.Drawing.Size(352, 20);
            this.txNameTest.TabIndex = 2;
            this.txNameTest.Text = "Название предмета";
            this.txNameTest.TextChanged += new System.EventHandler(this.txNameTest_TextChanged);
            this.txNameTest.Enter += new System.EventHandler(this.txNameTest_Enter);
            // 
            // bt_addTabBox
            // 
            this.bt_addTabBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_addTabBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_addTabBox.ForeColor = System.Drawing.Color.White;
            this.bt_addTabBox.Location = new System.Drawing.Point(504, 522);
            this.bt_addTabBox.Name = "bt_addTabBox";
            this.bt_addTabBox.Size = new System.Drawing.Size(122, 23);
            this.bt_addTabBox.TabIndex = 3;
            this.bt_addTabBox.Text = "Добавить вопрос";
            this.bt_addTabBox.UseVisualStyleBackColor = false;
            this.bt_addTabBox.Click += new System.EventHandler(this.bt_addTabBox_Click);
            // 
            // bt_delTabBox
            // 
            this.bt_delTabBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_delTabBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_delTabBox.ForeColor = System.Drawing.Color.White;
            this.bt_delTabBox.Location = new System.Drawing.Point(655, 522);
            this.bt_delTabBox.Name = "bt_delTabBox";
            this.bt_delTabBox.Size = new System.Drawing.Size(126, 23);
            this.bt_delTabBox.TabIndex = 4;
            this.bt_delTabBox.Text = "Удалить вопрос";
            this.bt_delTabBox.UseVisualStyleBackColor = false;
            this.bt_delTabBox.Click += new System.EventHandler(this.bt_delTabBox_Click);
            // 
            // bt_saveXML
            // 
            this.bt_saveXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_saveXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_saveXML.ForeColor = System.Drawing.Color.White;
            this.bt_saveXML.Location = new System.Drawing.Point(145, 533);
            this.bt_saveXML.Name = "bt_saveXML";
            this.bt_saveXML.Size = new System.Drawing.Size(75, 23);
            this.bt_saveXML.TabIndex = 5;
            this.bt_saveXML.Text = "Сохранить";
            this.bt_saveXML.UseVisualStyleBackColor = false;
            this.bt_saveXML.Visible = false;
            this.bt_saveXML.Click += new System.EventHandler(this.bt_saveXMLclick);
            // 
            // bt_LoadXML
            // 
            this.bt_LoadXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_LoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LoadXML.ForeColor = System.Drawing.Color.White;
            this.bt_LoadXML.Location = new System.Drawing.Point(28, 81);
            this.bt_LoadXML.Name = "bt_LoadXML";
            this.bt_LoadXML.Size = new System.Drawing.Size(75, 23);
            this.bt_LoadXML.TabIndex = 6;
            this.bt_LoadXML.Text = "Загрузить";
            this.bt_LoadXML.UseVisualStyleBackColor = false;
            this.bt_LoadXML.Visible = false;
            this.bt_LoadXML.Click += new System.EventHandler(this.bt_LoadXML_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(124, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Выбрать";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(19, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Выбрать файл";
            this.textBox1.Visible = false;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadXmlToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.менюToolStripMenuItem.Text = "Файл";
            // 
            // LoadXmlToolStripMenuItem
            // 
            this.LoadXmlToolStripMenuItem.Name = "LoadXmlToolStripMenuItem";
            this.LoadXmlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadXmlToolStripMenuItem.Text = "Загрузить...";
            this.LoadXmlToolStripMenuItem.Visible = false;
            this.LoadXmlToolStripMenuItem.Click += new System.EventHandler(this.LoadXmlToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить...";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // textBox_NumberGoodAnswer
            // 
            this.textBox_NumberGoodAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox_NumberGoodAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NumberGoodAnswer.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_NumberGoodAnswer.Location = new System.Drawing.Point(145, 507);
            this.textBox_NumberGoodAnswer.Name = "textBox_NumberGoodAnswer";
            this.textBox_NumberGoodAnswer.Size = new System.Drawing.Size(104, 20);
            this.textBox_NumberGoodAnswer.TabIndex = 9;
            this.textBox_NumberGoodAnswer.Text = "Проходной бал";
            this.textBox_NumberGoodAnswer.Visible = false;
            this.textBox_NumberGoodAnswer.Enter += new System.EventHandler(this.textBox_NumberGoodAnswer_Enter);
            this.textBox_NumberGoodAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberGoodAnswer_KeyPress);
            // 
            // toolTip_NumberGoodAnswer
            // 
            this.toolTip_NumberGoodAnswer.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_NumberGoodAnswer_Popup);
            // 
            // txBoxFileName
            // 
            this.txBoxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBoxFileName.ForeColor = System.Drawing.Color.DimGray;
            this.txBoxFileName.Location = new System.Drawing.Point(274, 27);
            this.txBoxFileName.Name = "txBoxFileName";
            this.txBoxFileName.Size = new System.Drawing.Size(182, 20);
            this.txBoxFileName.TabIndex = 10;
            this.txBoxFileName.Text = "Название файла";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(112, 368);
            this.listBox1.TabIndex = 11;
            this.listBox1.Visible = false;
            // 
            // txLableXML
            // 
            this.txLableXML.AutoSize = true;
            this.txLableXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txLableXML.ForeColor = System.Drawing.Color.DimGray;
            this.txLableXML.Location = new System.Drawing.Point(462, 29);
            this.txLableXML.Name = "txLableXML";
            this.txLableXML.Size = new System.Drawing.Size(32, 17);
            this.txLableXML.TabIndex = 12;
            this.txLableXML.Text = ".xml";
            // 
            // ConfiguratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(793, 557);
            this.Controls.Add(this.txLableXML);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txBoxFileName);
            this.Controls.Add(this.textBox_NumberGoodAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_LoadXML);
            this.Controls.Add(this.bt_saveXML);
            this.Controls.Add(this.bt_delTabBox);
            this.Controls.Add(this.bt_addTabBox);
            this.Controls.Add(this.txNameTest);
            this.Controls.Add(this.txBoxDiscription);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConfiguratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguratorForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfiguratorForm_Load);
            this.Shown += new System.EventHandler(this.ConfiguratorForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBoxDiscription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txNameTest;
        private System.Windows.Forms.Button bt_addTabBox;
        private System.Windows.Forms.Button bt_delTabBox;
        private System.Windows.Forms.Button bt_saveXML;
        private System.Windows.Forms.Button bt_LoadXML;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_NumberGoodAnswer;
        private System.Windows.Forms.ToolTip toolTip_NumberGoodAnswer;
        private System.Windows.Forms.TextBox txBoxFileName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txLableXML;
    }
}