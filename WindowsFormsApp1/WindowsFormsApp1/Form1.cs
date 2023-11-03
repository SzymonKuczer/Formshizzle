using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string dir = @"C:\Users\A2210275\Documents\trainer";

        public Form1()
        {
            InitializeComponent();
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            Injector injector = new Injector();
            injector.Show();  
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
