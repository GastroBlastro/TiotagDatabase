//TioTag Database
//Created By Gibson J. MacMillan
//January 2015
//Mr. T - ICS4U

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TiotagDatabase
{
    public partial class Create_New : Form
    {
        public Create_New()
        {
            InitializeComponent();
            custom1Box.Focus();
        }

        public static string custom1, custom2, custom3, custom4, custom5;


        public void button1_Click(object sender, EventArgs e)
        {
            if (custom1Box.Text == "" || custom2Box.Text == "" || custom3Box.Text == "" || custom4Box.Text == "" || custom5Box.Text == "")
            {
                MessageBox.Show("You must fill in all boxes.", "You are missing some info. . .");
            }
            else
            {
                custom1 = custom1Box.Text; custom2 = custom2Box.Text; custom3 = custom3Box.Text;
                custom4 = custom4Box.Text; custom5 = custom5Box.Text;

                Edit eform = new Edit();
                eform.Show();
                this.Close();
            }
                
        }

        public void cancelButton_Click(object sender, EventArgs e)
        {
            Form1 wForm = new Form1();
            wForm.Show();
            this.Close();
        }
    }
}
