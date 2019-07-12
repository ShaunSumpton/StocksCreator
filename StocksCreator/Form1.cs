using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            string name3 = textBox3.Text;

            int Numpgs = 0;
            int s = 0;

            Int32.TryParse(textBox4.Text, out Numpgs);

            if (textBox1.Text == "")
            {
                MessageBox.Show("No first page name specificed");

            }
            else if (textBox3.Text == "")
            {
                s = 2;
            }
            else
            {
                s = 3;
            }


            using (StreamWriter sw = new StreamWriter(@"C:\Users\Sumptons\Desktop\Test.txt", append: true))
            {
           
                sw.WriteLine(name1);
                sw.WriteLine("-----");

                for (int i = 1; i < Numpgs; i += 3) // Page 1
                {

                    sw.Write(i + ", ");
                   
                }

                sw.WriteLine(name2);
                sw.WriteLine("-----");

                for (int i = 2; i < Numpgs; i += 3) // Page 2
                {

                    sw.Write(i + ", ");

                }

                if (s == 3)
                {
                    sw.WriteLine(name3);
                    sw.WriteLine("-----");

                    for (int i = 3; i < Numpgs; i += 3) // Page 3
                    {
                        sw.Write(i + ", ");

                    }
                }


                MessageBox.Show("Complete");



            }
            





        }
    }
}
