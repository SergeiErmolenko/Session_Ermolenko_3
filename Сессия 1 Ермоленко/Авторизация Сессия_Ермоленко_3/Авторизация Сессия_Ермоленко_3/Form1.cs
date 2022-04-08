using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Session_Ermolenko_3_Sign_in : Form
    {
        public Session_Ermolenko_3_Sign_in()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "pass")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин", "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
