using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CPTool_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.TagName1;
            textBox2.Text = Properties.Settings.Default.TagName2;
            textBox3.Text = Properties.Settings.Default.TagName3;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TagName1 = textBox1.Text;
            Properties.Settings.Default.TagName2 = textBox2.Text;
            Properties.Settings.Default.TagName3 = textBox3.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
