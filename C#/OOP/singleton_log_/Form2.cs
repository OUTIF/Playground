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
    public partial class Form2 : Form
    {
        Logger newlogger;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newlogger.Info("an opperation have been done inside form2"); ;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            newlogger = Logger.Instant;
            newlogger.Info("Form2 have been loadded");
        }
    }
}
