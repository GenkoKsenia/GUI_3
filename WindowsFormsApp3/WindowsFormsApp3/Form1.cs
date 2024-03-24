using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = this.textBox1.Text;
                Properties.Settings.Default.str = str;
                Properties.Settings.Default.Save();
                MessageBox.Show(Logic.NumLet(str), "Ответ");
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }                    
        }
    }


    public class Logic
    {
        public static string NumLet(string str)
        {
            {
                string outMessage = "Одинаковых букв в предложении: ";
                char letter = str[0];
                int quantity = 0;

                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == letter)
                    {
                        quantity++;
                        letter = str[i];
                    }
                    else if (str[i] == ' ')
                    {

                    }
                    else letter = str[i];
                }

                outMessage += quantity;
                return outMessage;
            }
        }
    }
}
