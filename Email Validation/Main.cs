using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Email_Validation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = "^([^+]+)[+]+([^+]+)@gmail.com";
            if (textBox1.Text.Length > 0)
            {
                string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
                   @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
                   @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
                System.Text.RegularExpressions.Match match =
                    Regex.Match(textBox1.Text.Trim(), pattern, RegexOptions.IgnoreCase);

                if (match.Success)
                {

                    MessageBox.Show("Email Address is correct");
                }
                else
                {
                    textBox1.Focus();
                    MessageBox.Show("Incorrect Email Address");
                }
            }
            else
                MessageBox.Show("No Email Address Entered, Please try again");
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail dl = new Detail();
            dl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail dl = new Detail();
            dl.Show();
        }
    }
}
