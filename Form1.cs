using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin1
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        string third = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void yksi_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "1";
            Laskin.Text += userInput;
        }

        private void kaksi_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "2";
            Laskin.Text += userInput;
        }

        private void kolme_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "3";
            Laskin.Text += userInput;
        }

        private void neljä_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "4";
            Laskin.Text += userInput;
        }

        private void viisi_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "5";
            Laskin.Text += userInput;
        }

        private void kuusi_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "6";
            Laskin.Text += userInput;
        }

        private void seitsemän_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "7";
            Laskin.Text += userInput;
        }

        private void kahdeksan_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "8";
            Laskin.Text += userInput;
        }

        private void yhdeksän_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "9";
            Laskin.Text += userInput;
        }

        private void autoclear_Click(object sender, EventArgs e)
        {
            function = '\0';
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            Laskin.Text = "0";
        }

        private void jako_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";

        }

        private void kerto_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";

        }

        private void plussa_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void miinus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";

        }

        private void yhtäsuuri_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //Plussa
            if(function == '+')
            {
                result = firstNum + secondNum;
                Laskin.Text = result.ToString();
            }
            //Miinus
            else if(function == '-')
            {
                result = firstNum - secondNum;
                Laskin.Text = result.ToString();
            }
            //Jako
            else if(function == '/')
            {
                if(secondNum == '0')
                {
                    Laskin.Text = "Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    Laskin.Text = result.ToString();
                }
            }
            //Kerto
            else if(function == '*')
            {
                result = firstNum * secondNum;
                Laskin.Text = result.ToString();
            }
        }

        private void nolla_Click(object sender, EventArgs e)
        {
            Laskin.Text = "";
            userInput += "0";
            Laskin.Text += userInput;
        }

        private void desimaali_Click(object sender, EventArgs e)
        {
            Laskin.Text += ",";
            userInput += "0";
            Laskin.Text += userInput;
        }
    }
}
