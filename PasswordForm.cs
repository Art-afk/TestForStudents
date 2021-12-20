using System;
using System.Windows.Forms;

namespace Start.Exam
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtPassword;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "3")
            {
                // The password is ok.
                this.DialogResult = DialogResult.OK;
                // Create a new instance of the Form2 class
                ConfiguratorForm ConfiguratorForm = new ConfiguratorForm();

                // Show the settings form
                ConfiguratorForm.Show();
                ConfiguratorForm.FormClosed += new FormClosedEventHandler(ConfiguratorForm_FormClosed);

                this.Hide();
                    
            }
            else
            {
                // The password is invalid.
                txtPassword.Clear();
                MessageBox.Show("Неправильный пароль");
                txtPassword.Focus();
            }
        }

        private void ConfiguratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
