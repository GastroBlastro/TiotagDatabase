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

namespace TiotagDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Edit eform = new Edit();

        #region Mouse Hover
        #region Create Button
        private void label3_MouseHover(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.SteelBlue;
            createLabel.BackColor = Color.SteelBlue;
            createSubLabel.BackColor = Color.SteelBlue;
        }

        private void createLabel_MouseHover(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.SteelBlue;
            createLabel.BackColor = Color.SteelBlue;
            createSubLabel.BackColor = Color.SteelBlue;
        }

        private void createSubLabel_MouseHover(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.SteelBlue;
            createLabel.BackColor = Color.SteelBlue;
            createSubLabel.BackColor = Color.SteelBlue;
        }

        private void createBackLabel_MouseLeave(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.White;
            createLabel.BackColor = Color.White;
            createSubLabel.BackColor = Color.White;
        }

        private void createLabel_MouseLeave(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.White;
            createLabel.BackColor = Color.White;
            createSubLabel.BackColor = Color.White;
        }

        private void createSubLabel_MouseLeave(object sender, EventArgs e)
        {
            createBackLabel.BackColor = Color.White;
            createLabel.BackColor = Color.White;
            createSubLabel.BackColor = Color.White;
        }
        #endregion

        #region Load Button
        private void label6_MouseHover(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.SteelBlue;
            loadLabel.BackColor = Color.SteelBlue;
            loadSubLabel.BackColor = Color.SteelBlue;
        }

        private void loadSubLabel_MouseHover(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.SteelBlue;
            loadLabel.BackColor = Color.SteelBlue;
            loadSubLabel.BackColor = Color.SteelBlue;
        }

        private void loadLabel_MouseHover(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.SteelBlue;
            loadLabel.BackColor = Color.SteelBlue;
            loadSubLabel.BackColor = Color.SteelBlue;
        }

        private void loadLabel_MouseLeave(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.White;
            loadLabel.BackColor = Color.White;
            loadSubLabel.BackColor = Color.White;
        }

        private void loadBackLabel_MouseLeave(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.White;
            loadLabel.BackColor = Color.White;
            loadSubLabel.BackColor = Color.White;
        }

        private void loadSubLabel_MouseLeave(object sender, EventArgs e)
        {
            loadBackLabel.BackColor = Color.White;
            loadLabel.BackColor = Color.White;
            loadSubLabel.BackColor = Color.White;
        }
        #endregion

        #endregion

        #region Create Click
        private void createBackLabel_Click(object sender, EventArgs e)
        {
            showCreationForm();
        }

        private void createSubLabel_Click(object sender, EventArgs e)
        {
            showCreationForm();
        }

        private void createLabel_Click(object sender, EventArgs e)
        {
            showCreationForm();
        }

        private void showCreationForm()
        {
            Create_New cform = new Create_New();
            cform.Show();
            this.Hide();
        }

        #endregion

        #region Load Click
        private void loadSubLabel_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        private void loadLabel_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        private void loadBackLabel_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        private void loadFile()
        {
            eform.Show();
            eform.loadFile();
            this.Hide();
        }

        #endregion

    }
}
