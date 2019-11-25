using System;
using System.IO;
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

            string name1 = textBox1.Text; // text box 1
            string name2 = textBox2.Text; // text box 2
            string name3 = textBox3.Text;
            string name4 = textBox5.Text;

            int Numpgs = 0;
            int s = 0;
            int i = 0;

            Int32.TryParse(textBox4.Text, out Numpgs);

            if (textBox1.Text == "")
            {
                MessageBox.Show("No first page name specificed");

            }
            else if (textBox3.Text == "")
            {
                s = 2;
            }
            else if (textBox5.Text == "")
            {
                s = 3;
            }
            else
                s = 4;


            using (StreamWriter sw = new StreamWriter(@"C:\Users\Sumptons\Desktop\Test.txt", true))
            {
           
                sw.WriteLine(name1); // name of page 1
                sw.WriteLine("-----");

                for ( i = 1; i <= Numpgs; i += s) // Page 1
                {

                    sw.Write(i + ",");
                   
                }
                sw.WriteLine(Environment.NewLine); // add new line
                sw.WriteLine(name2); //name of page 2
                sw.WriteLine("-----");

                for ( i = 2; i <= Numpgs; i += s) // Page 2
                {

                    sw.Write(i + ",");

                }

                if (s == 3 | s == 4)
                {
                    sw.WriteLine(Environment.NewLine); // add new line
                    sw.WriteLine(name3); // name of page 3
                    sw.WriteLine("-----");

                    for (i = 3; i <= Numpgs; i += s) // Page 3
                    {
                        sw.Write(i + ",");

                    }
                }

                if (s == 4)
                {
                    sw.WriteLine(Environment.NewLine);// add new line
                    sw.WriteLine(name4); // name of page 4
                    sw.WriteLine("-----");
                    i = 0;

                    for (i = 4; i <= Numpgs; i += s) // Page 3
                    {
                        sw.Write(i + ",");

                    }
                }





            }


            MessageBox.Show("Complete");



        }
    }
}
