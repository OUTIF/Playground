using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singletonwin_mywork
{
    public partial class Form1 : Form
    {
        Logger mylogger;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mylogger = Logger.Instant;
            mylogger.Info("Form1 have been loaded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            mylogger.Info("ADD Button have been clicked");
            try
            {
                int result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                mylogger.Info("Addition opperation have been done with a value of:" +result);
                label1.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("An error have been occur","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mylogger.Error("An error have been occured via addition opperation");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
