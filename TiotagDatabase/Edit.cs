//TioTag Database
//Created By Gibson J. MacMillan
//January 2015
//Mr. T - ICS4U

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Imaging;

namespace TiotagDatabase
{
    public partial class Edit : Form
    {
        Create_New cform = new Create_New();
        string image = "";
        int current = 0;

        string fileName, custom1 = Create_New.custom1, custom2 = Create_New.custom2, custom3 = Create_New.custom3,
            custom4 = Create_New.custom4, custom5 = Create_New.custom5;

        int selectedIndex = 0;

        //bool sortName, sortNameUp, sortId, sortIdUp;

        public Edit()
        {
            InitializeComponent();
            custom1BoxLabel.Text = custom1 + ":";
            custom2BoxLabel.Text = custom2 + ":";
            custom3BoxLabel.Text = custom3 + ":";
            custom4BoxLabel.Text = custom4 + ":";
            custom5BoxLabel.Text = custom5 + ":";
            custom1LabelLabel.Text = custom1 + ":";
            custom2LabelLabel.Text = custom2 + ":";
            custom3LabelLabel.Text = custom3 + ":";
            custom4LabelLabel.Text = custom4 + ":";
            custom5LabelLabel.Text = custom5 + ":";
            nameBox.Focus();
        }

        public static List<dbObject> objectDB = new List<dbObject>();

        public void loadFile()
        {
            //show load file dialog
            loadFileDialog.ShowDialog();
        }

        private void loadFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = loadFileDialog.FileName;

            XmlTextReader reader = new XmlTextReader(fileName);
            int counter = 0; int elementCounter = 0;
            string name, id, c1, c2, c3, c4, c5;
            name = id = c1 = c2 = c3 = c4 = c5 = "";

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // If the currently read item is correct info then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (counter == 0)
                    {
                        name = reader.Value;
                        counter++;
                    }
                    else if (counter == 1)
                    {
                        id = reader.Value;
                        counter++;
                    }
                    else if (counter == 2)
                    {
                        c1 = reader.Value;
                        counter++;
                    }
                    else if (counter == 3)
                    {
                        c2 = reader.Value;
                        counter++;
                    }
                    else if (counter == 4)
                    {
                        c3 = reader.Value;
                        counter++;
                    }
                    else if (counter == 5)
                    {
                        c4 = reader.Value;
                        counter++;
                    }
                    else if (counter == 6)
                    {
                        c5 = reader.Value;
                        counter++;
                    }
                    else if (counter == 7)
                    {
                        image = reader.Value;

                        dbObject newObject = new dbObject(name, id, c1, c2, c3, c4, c5, image);
                        objectDB.Add(newObject);
                        counter = 0;
                    }
                }

                // If the currently read item is element name then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Element && elementCounter == 8)
                {
                    custom1BoxLabel.Text = custom1LabelLabel.Text = reader.Name + ":";
                    
                    elementCounter++;
                }

                else if (reader.NodeType == XmlNodeType.Element && elementCounter == 11)
                {
                    custom2BoxLabel.Text = custom2LabelLabel.Text = reader.Name + ":";
                    elementCounter++;
                }

                else if (reader.NodeType == XmlNodeType.Element && elementCounter == 14)
                {
                    custom3BoxLabel.Text = custom3LabelLabel.Text = reader.Name + ":";
                    elementCounter++;
                }

                else if (reader.NodeType == XmlNodeType.Element && elementCounter == 17)
                {
                    custom4BoxLabel.Text = custom4LabelLabel.Text = reader.Name + ":";
                    elementCounter++;
                }

                else if (reader.NodeType == XmlNodeType.Element && elementCounter == 20)
                {
                    custom5BoxLabel.Text = custom5LabelLabel.Text = reader.Name + ":";
                    elementCounter = 0;
                }
                else
                {
                    elementCounter++;
                }
            }
            // When done reading the file close it
            reader.Close();

            //set to 1st object
            nameLabel.Text = objectDB[0].name;
            idLabel.Text = objectDB[0].id;
            custom1Label.Text = objectDB[0].c1;
            custom2Label.Text = objectDB[0].c2;
            custom3Label.Text = objectDB[0].c3;
            custom4Label.Text = objectDB[0].c4;
            custom5Label.Text = objectDB[0].c5;

            if (image != "")
            {
                imageBox.Image = Image.FromFile(objectDB[0].img);
                image = "";
            }

            nameListBox.Items.Clear();
            IDListBox.Items.Clear();



            //display items on name/ID search list
            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                nameListBox.Items.Add(objectDB[i].name);
            }

            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                IDListBox.Items.Add(objectDB[i].id);
            }

            nameListBox.SelectedIndex = IDListBox.SelectedIndex = 0;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //show load file dialog
            loadImageDialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show save file dialog
            saveDatabaseDialog.ShowDialog();
        }

        private void saveDatabaseDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = saveDatabaseDialog.FileName;
            //creates and saves file
            writeTIOTAG();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //sets strings to user input
            string name = nameBox.Text, id = idBox.Text, c1 = c1Box.Text, c2 = c2Box.Text,
                c3 = c3Box.Text, c4 = c4Box.Text, c5 = c5Box.Text;

            try
            {
                Convert.ToInt16(idBox.Text);
                Convert.ToString(idBox.Text);
            }
            catch
            {
                MessageBox.Show("The entry into 'ID#' must be a number.  Please re-enter this as a number and try adding again.", "ID# Error");
                return;
                
            }

            //adds object to list
            dbObject newObject = new dbObject(name, id, c1, c2, c3, c4, c5, image);
            objectDB.Add(newObject);

            nameLabel.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].name);
            idLabel.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].id);
            custom1Label.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].c1);
            custom2Label.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].c2);
            custom3Label.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].c3);
            custom4Label.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].c4);
            custom5Label.Text = Convert.ToString(objectDB[Convert.ToInt16(objectDB.Count()) - 1].c5);
            if (image != "")
            {
                imageBox.Image = Image.FromFile(objectDB[objectDB.Count() - 1].img);
                image = "";
            }

            if (nameSearchLabel.ForeColor == Color.Blue)
            {
                objectDB.Sort();
            }
            
            nameListBox.Items.Clear();
            IDListBox.Items.Clear();

            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                nameListBox.Items.Add(objectDB[i].name);
            }

            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                IDListBox.Items.Add(objectDB[i].id);
            }

            nameBox.Text = idBox.Text = c1Box.Text = c2Box.Text = c3Box.Text = c4Box.Text = c5Box.Text = image = "";

            cform.Close();

        }

        //creates and saves TIOTAG File
        void writeTIOTAG()
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, null);

            //Write the "class" element
            writer.WriteStartElement("database");

            //Write sub-elements
            for (int i = 0; i < objectDB.Count(); i++)
            {
                //Start "student" element
                writer.WriteStartElement("object");

                writer.WriteElementString("Name", objectDB[i].name);
                writer.WriteElementString("ID", objectDB[i].id);
                writer.WriteElementString(custom1, objectDB[i].c1);
                writer.WriteElementString(custom2, objectDB[i].c2);
                writer.WriteElementString(custom3, objectDB[i].c3);
                writer.WriteElementString(custom4, objectDB[i].c4);
                writer.WriteElementString(custom5, objectDB[i].c5);
                writer.WriteElementString("Image", objectDB[i].img);

                // end the "object" element
                writer.WriteEndElement();
            }

            // end the "database" element
            writer.WriteEndElement();

            //close the writer
            writer.Close();

            MessageBox.Show("Your file was successfully saved!", "Save Successful");
        }

        private void loadImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            //loads image
            image = loadImageDialog.FileName;
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if nothing selected, do nothing
            if (nameListBox.SelectedIndex < 0)
            {
            }

            else
            {
                current = nameListBox.SelectedIndex;
                nameLabel.Text = nameBox.Text = objectDB[nameListBox.SelectedIndex].name;
                idLabel.Text = idBox.Text = objectDB[nameListBox.SelectedIndex].id;
                custom1Label.Text = c1Box.Text = objectDB[nameListBox.SelectedIndex].c1;
                custom2Label.Text = c2Box.Text = objectDB[nameListBox.SelectedIndex].c2;
                custom3Label.Text = c3Box.Text = objectDB[nameListBox.SelectedIndex].c3;
                custom4Label.Text = c4Box.Text = objectDB[nameListBox.SelectedIndex].c4;
                custom5Label.Text = c5Box.Text = objectDB[nameListBox.SelectedIndex].c5;
                image = objectDB[nameListBox.SelectedIndex].img;
                if (image != "")
                {
                    imageBox.Image = Image.FromFile(image);
                    image = "";
                }

                IDListBox.SelectedIndex = nameListBox.SelectedIndex;
                selectedIndex = nameListBox.SelectedIndex;
            }

        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nameBox.Text = idBox.Text = c1Box.Text = c2Box.Text = c3Box.Text = c4Box.Text = c5Box.Text = image = "";
        }

        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nameBox.Text = idBox.Text = c1Box.Text = c2Box.Text = c3Box.Text = c4Box.Text = c5Box.Text = image = "";
           // nameListBox.Select
        }

        private void nameSearchLabel_Click(object sender, EventArgs e)
        {
            IdSearchLabel.ForeColor = Color.Gray;
            nameSearchLabel.ForeColor = Color.Black;
            nameListBox.Sorted = true;
            IDListBox.Sorted = false;
        }

        private void IdSearchLabel_Click(object sender, EventArgs e)
        {
            IdSearchLabel.ForeColor = Color.Black;
            nameSearchLabel.ForeColor = Color.Gray;
            nameListBox.Sorted = false;
            IDListBox.Sorted = true;

            //sortName = false;
            //nameSearchLabel.Text = "Name";
            //sortId = true;

            //if (IdSearchLabel.Text == "ID#")
            //{
            //    IdSearchLabel.Text += " ↑";
            //    sortIdUp = true;
            //}
            //else if (IdSearchLabel.Text == "ID# ↑")
            //{
            //    IdSearchLabel.Text = "ID# ↓";
            //    sortIdUp = false;
            //}
            //else if (IdSearchLabel.Text == "ID# ↓")
            //{
            //    IdSearchLabel.Text = "ID#";
            //    sortId = false;
            //}
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            objectDB[current].name = nameBox.Text;
            objectDB[current].id = idBox.Text;
            objectDB[current].c1 = c1Box.Text;
            objectDB[current].c2 = c2Box.Text;
            objectDB[current].c3 = c3Box.Text;
            objectDB[current].c4 = c4Box.Text;
            objectDB[current].c5 = c5Box.Text;

            //changes item
            if (objectDB[current].img != "")
            {
                imageBox.Image = Image.FromFile(objectDB[current].img);
            }

            nameListBox.Items.Clear();
            IDListBox.Items.Clear();

            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                nameListBox.Items.Add(objectDB[i].name);
            }

            for (int i = 0; i <= objectDB.Count() - 1; i++)
            {
                IDListBox.Items.Add(objectDB[i].id);
            }

            nameBox.Text = idBox.Text = c1Box.Text = c2Box.Text = c3Box.Text = c4Box.Text = c5Box.Text = image = "";
            nameListBox.SelectedIndex = IDListBox.SelectedIndex = selectedIndex;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //checks if there are objects, if not doesn't allow delete
            if (nameListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must first create items in order to delete them.", "No Items");
            }
            else
            {
                //checks to see if user wants to delete
                if (MessageBox.Show("Are you sure that you want to delete: '" + nameListBox.SelectedItems.ToString() + "'?\nThis item may not be recovered once deleted!", "Deleting Object. . .", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //deletes
                    objectDB.RemoveAt(nameListBox.SelectedIndex);
                    nameListBox.Items.RemoveAt(nameListBox.SelectedIndex);
                    IDListBox.Items.RemoveAt(IDListBox.SelectedIndex);
                    if (nameListBox.SelectedIndex > 0)
                    {
                        nameListBox.SelectedIndex = IDListBox.SelectedIndex = 0;
                    }
                    else
                    {
                        nameListBox.SelectedIndex = IDListBox.SelectedIndex = -1;
                    }

                }
            }
        }

        private void IDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if nothing selected do nothing
            if (IDListBox.SelectedIndex < 0)
            {
            }

            else
            {
                current = IDListBox.SelectedIndex;
                nameLabel.Text = nameBox.Text = objectDB[IDListBox.SelectedIndex].name;
                idLabel.Text = idBox.Text = objectDB[IDListBox.SelectedIndex].id;
                custom1Label.Text = c1Box.Text = objectDB[IDListBox.SelectedIndex].c1;
                custom2Label.Text = c2Box.Text = objectDB[IDListBox.SelectedIndex].c2;
                custom3Label.Text = c3Box.Text = objectDB[IDListBox.SelectedIndex].c3;
                custom4Label.Text = c4Box.Text = objectDB[IDListBox.SelectedIndex].c4;
                custom5Label.Text = c5Box.Text = objectDB[IDListBox.SelectedIndex].c5;
                image = objectDB[IDListBox.SelectedIndex].img;
                if (image != "")
                {
                    imageBox.Image = Image.FromFile(image);
                    image = "";
                }

                nameListBox.SelectedIndex = IDListBox.SelectedIndex;
                selectedIndex = nameListBox.SelectedIndex;
            }
            

        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //assures user wants to close
            DialogResult dr = MessageBox.Show("Are you sure that you want to exit Tiotag Database: '" + fileName + "'?\nAll unsaved changes will be lost!", "Exiting Tiotag. . .", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                //if not, cancel
                e.Cancel = true;
                new CancelEventArgs().Cancel = true;
            }
            else
            {   
                //if so, close the entire app (hiding Form1) *see Edit_FormClosed        
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //shows about box
            AboutBox1 aBox = new AboutBox1();
            aBox.Show();
        }
    }
}
