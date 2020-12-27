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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Properties.Settings.Default.ButtonKind = 0;
            InitializeComponent();
        }

        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 0)
            {
                button11.BackColor = Color.DarkBlue;
                button12.BackColor = Color.DarkGray;
                button13.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title0;
                button1.Text = Properties.Settings.Default.Title1;
                button1.Text = Properties.Settings.Default.Title2;
                button1.Text = Properties.Settings.Default.Title3;
                button1.Text = Properties.Settings.Default.Title4;
                button1.Text = Properties.Settings.Default.Title5;
                button1.Text = Properties.Settings.Default.Title6;
                button1.Text = Properties.Settings.Default.Title7;
                button1.Text = Properties.Settings.Default.Title8;
                button1.Text = Properties.Settings.Default.Title9;
            }
            else if (Properties.Settings.Default.ButtonKind == 1)
            {
                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DarkBlue;
                button13.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title10;
                button1.Text = Properties.Settings.Default.Title11;
                button1.Text = Properties.Settings.Default.Title12;
                button1.Text = Properties.Settings.Default.Title13;
                button1.Text = Properties.Settings.Default.Title14;
                button1.Text = Properties.Settings.Default.Title15;
                button1.Text = Properties.Settings.Default.Title16;
                button1.Text = Properties.Settings.Default.Title17;
                button1.Text = Properties.Settings.Default.Title18;
                button1.Text = Properties.Settings.Default.Title19;
            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                button11.BackColor = Color.DarkGray;
                button12.BackColor = Color.DarkGray;
                button13.BackColor = Color.DarkBlue;

                button1.Text = Properties.Settings.Default.Title20;
                button1.Text = Properties.Settings.Default.Title21;
                button1.Text = Properties.Settings.Default.Title22;
                button1.Text = Properties.Settings.Default.Title23;
                button1.Text = Properties.Settings.Default.Title24;
                button1.Text = Properties.Settings.Default.Title25;
                button1.Text = Properties.Settings.Default.Title26;
                button1.Text = Properties.Settings.Default.Title27;
                button1.Text = Properties.Settings.Default.Title28;
                button1.Text = Properties.Settings.Default.Title29;
            }
            button11.Text = Properties.Settings.Default.TagName0;
            button12.Text = Properties.Settings.Default.TagName1;
            button13.Text = Properties.Settings.Default.TagName2;
        }


    }
}