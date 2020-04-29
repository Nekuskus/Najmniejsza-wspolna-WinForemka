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

namespace Najmniejsza_wspólna_WinForemka
{
    public partial class Form1 : Form
    {
        Regex digitExpression = new Regex(@"[0-9]+");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(digitExpression.IsMatch(textBox1.Text))
            {
                Vars.var1 = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(digitExpression.IsMatch(textBox2.Text))
            {
                Vars.var2 = Convert.ToInt32(textBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Vars.var1 != 0 && Vars.var2 != 0)
            {
                List<int> wiel1 = new List<int>();
                List<int> wiel2 = new List<int>();
                button1.Enabled = false;
                LiczenieLabel.Visible = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                for(int i = 1; true; i++)
                {
                    wiel1.Add(Vars.var1 * i);
                    wiel2.Add(Vars.var2 * i);
                    foreach(var item in wiel1)
                    {
                        foreach(var item2 in wiel2)
                        {
                            if(item == item2)
                            {
                                Vars.Result = item;
                                textBox3.Text = Convert.ToString(Vars.Result);
                                goto koniec;
                            }
                        }
                    }
                }
                koniec:
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                LiczenieLabel.Visible = false;
                button1.Enabled = true;
            }
        }
    }
}
