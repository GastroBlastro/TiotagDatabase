namespace TiotagDatabase
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.IDListBox = new System.Windows.Forms.ListBox();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.nameSearchLabel = new System.Windows.Forms.Label();
            this.IdSearchLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.custom1Label = new System.Windows.Forms.Label();
            this.custom2Label = new System.Windows.Forms.Label();
            this.custom3Label = new System.Windows.Forms.Label();
            this.custom4Label = new System.Windows.Forms.Label();
            this.custom5Label = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.viewObjectLabel = new System.Windows.Forms.Label();
            this.editObjectLabel = new System.Windows.Forms.Label();
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.custom5BoxLabel = new System.Windows.Forms.Label();
            this.custom4BoxLabel = new System.Windows.Forms.Label();
            this.custom3BoxLabel = new System.Windows.Forms.Label();
            this.custom2BoxLabel = new System.Windows.Forms.Label();
            this.custom1BoxLabel = new System.Windows.Forms.Label();
            this.IDBoxLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.c5Box = new System.Windows.Forms.TextBox();
            this.c4Box = new System.Windows.Forms.TextBox();
            this.c3Box = new System.Windows.Forms.TextBox();
            this.c2Box = new System.Windows.Forms.TextBox();
            this.c1Box = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.imageButtonLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveDatabaseDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.nameLabelLabel = new System.Windows.Forms.Label();
            this.idLabelLabel = new System.Windows.Forms.Label();
            this.custom1LabelLabel = new System.Windows.Forms.Label();
            this.custom2LabelLabel = new System.Windows.Forms.Label();
            this.custom3LabelLabel = new System.Windows.Forms.Label();
            this.custom4LabelLabel = new System.Windows.Forms.Label();
            this.custom5LabelLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 14;
            this.nameListBox.Location = new System.Drawing.Point(273, 42);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(84, 438);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // IDListBox
            // 
            this.IDListBox.FormattingEnabled = true;
            this.IDListBox.ItemHeight = 14;
            this.IDListBox.Location = new System.Drawing.Point(360, 42);
            this.IDListBox.Name = "IDListBox";
            this.IDListBox.Size = new System.Drawing.Size(84, 438);
            this.IDListBox.TabIndex = 1;
            this.IDListBox.SelectedIndexChanged += new System.EventHandler(this.IDListBox_SelectedIndexChanged);
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(330, 7);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(45, 14);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Sort by:";
            // 
            // nameSearchLabel
            // 
            this.nameSearchLabel.AutoSize = true;
            this.nameSearchLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchLabel.Location = new System.Drawing.Point(291, 23);
            this.nameSearchLabel.Name = "nameSearchLabel";
            this.nameSearchLabel.Size = new System.Drawing.Size(48, 18);
            this.nameSearchLabel.TabIndex = 3;
            this.nameSearchLabel.Text = "Name";
            this.nameSearchLabel.Click += new System.EventHandler(this.nameSearchLabel_Click);
            // 
            // IdSearchLabel
            // 
            this.IdSearchLabel.AutoSize = true;
            this.IdSearchLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSearchLabel.Location = new System.Drawing.Point(387, 23);
            this.IdSearchLabel.Name = "IdSearchLabel";
            this.IdSearchLabel.Size = new System.Drawing.Size(31, 18);
            this.IdSearchLabel.TabIndex = 4;
            this.IdSearchLabel.Text = "ID#";
            this.IdSearchLabel.Click += new System.EventHandler(this.IdSearchLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(89, 261);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 14);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "nameLabel";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(89, 296);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 14);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "idLabel";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custom1Label
            // 
            this.custom1Label.AutoSize = true;
            this.custom1Label.Location = new System.Drawing.Point(89, 327);
            this.custom1Label.Name = "custom1Label";
            this.custom1Label.Size = new System.Drawing.Size(74, 14);
            this.custom1Label.TabIndex = 8;
            this.custom1Label.Text = "custom1Label";
            this.custom1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custom2Label
            // 
            this.custom2Label.AutoSize = true;
            this.custom2Label.Location = new System.Drawing.Point(89, 359);
            this.custom2Label.Name = "custom2Label";
            this.custom2Label.Size = new System.Drawing.Size(74, 14);
            this.custom2Label.TabIndex = 9;
            this.custom2Label.Text = "custom2Label";
            this.custom2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custom3Label
            // 
            this.custom3Label.AutoSize = true;
            this.custom3Label.Location = new System.Drawing.Point(89, 393);
            this.custom3Label.Name = "custom3Label";
            this.custom3Label.Size = new System.Drawing.Size(74, 14);
            this.custom3Label.TabIndex = 10;
            this.custom3Label.Text = "custom3Label";
            this.custom3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custom4Label
            // 
            this.custom4Label.AutoSize = true;
            this.custom4Label.Location = new System.Drawing.Point(89, 426);
            this.custom4Label.Name = "custom4Label";
            this.custom4Label.Size = new System.Drawing.Size(74, 14);
            this.custom4Label.TabIndex = 11;
            this.custom4Label.Text = "custom4Label";
            this.custom4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custom5Label
            // 
            this.custom5Label.AutoSize = true;
            this.custom5Label.Location = new System.Drawing.Point(89, 459);
            this.custom5Label.Name = "custom5Label";
            this.custom5Label.Size = new System.Drawing.Size(74, 14);
            this.custom5Label.TabIndex = 12;
            this.custom5Label.Text = "custom5Label";
            this.custom5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::TiotagDatabase.Properties.Resources.tiotag_logo;
            this.logoBox.Location = new System.Drawing.Point(476, 410);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(230, 70);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 13;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(21, 39);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(230, 209);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // viewObjectLabel
            // 
            this.viewObjectLabel.AutoSize = true;
            this.viewObjectLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewObjectLabel.Location = new System.Drawing.Point(88, 9);
            this.viewObjectLabel.Name = "viewObjectLabel";
            this.viewObjectLabel.Size = new System.Drawing.Size(99, 19);
            this.viewObjectLabel.TabIndex = 14;
            this.viewObjectLabel.Text = "View Object";
            // 
            // editObjectLabel
            // 
            this.editObjectLabel.AutoSize = true;
            this.editObjectLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editObjectLabel.Location = new System.Drawing.Point(540, 9);
            this.editObjectLabel.Name = "editObjectLabel";
            this.editObjectLabel.Size = new System.Drawing.Size(92, 19);
            this.editObjectLabel.TabIndex = 15;
            this.editObjectLabel.Text = "Edit Object";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Location = new System.Drawing.Point(478, 43);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(37, 14);
            this.nameBoxLabel.TabIndex = 16;
            this.nameBoxLabel.Text = "Name:";
            // 
            // custom5BoxLabel
            // 
            this.custom5BoxLabel.Location = new System.Drawing.Point(450, 258);
            this.custom5BoxLabel.Name = "custom5BoxLabel";
            this.custom5BoxLabel.Size = new System.Drawing.Size(65, 14);
            this.custom5BoxLabel.TabIndex = 17;
            this.custom5BoxLabel.Text = "Custom5:";
            this.custom5BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom4BoxLabel
            // 
            this.custom4BoxLabel.Location = new System.Drawing.Point(450, 220);
            this.custom4BoxLabel.Name = "custom4BoxLabel";
            this.custom4BoxLabel.Size = new System.Drawing.Size(65, 14);
            this.custom4BoxLabel.TabIndex = 18;
            this.custom4BoxLabel.Text = "Custom4:";
            this.custom4BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom3BoxLabel
            // 
            this.custom3BoxLabel.Location = new System.Drawing.Point(450, 183);
            this.custom3BoxLabel.Name = "custom3BoxLabel";
            this.custom3BoxLabel.Size = new System.Drawing.Size(65, 14);
            this.custom3BoxLabel.TabIndex = 19;
            this.custom3BoxLabel.Text = "Custom3:";
            this.custom3BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom2BoxLabel
            // 
            this.custom2BoxLabel.Location = new System.Drawing.Point(450, 147);
            this.custom2BoxLabel.Name = "custom2BoxLabel";
            this.custom2BoxLabel.Size = new System.Drawing.Size(65, 14);
            this.custom2BoxLabel.TabIndex = 20;
            this.custom2BoxLabel.Text = "Custom2:";
            this.custom2BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom1BoxLabel
            // 
            this.custom1BoxLabel.Location = new System.Drawing.Point(450, 113);
            this.custom1BoxLabel.Name = "custom1BoxLabel";
            this.custom1BoxLabel.Size = new System.Drawing.Size(65, 14);
            this.custom1BoxLabel.TabIndex = 21;
            this.custom1BoxLabel.Text = "Custom1:";
            this.custom1BoxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IDBoxLabel
            // 
            this.IDBoxLabel.AutoSize = true;
            this.IDBoxLabel.Location = new System.Drawing.Point(490, 80);
            this.IDBoxLabel.Name = "IDBoxLabel";
            this.IDBoxLabel.Size = new System.Drawing.Size(25, 14);
            this.IDBoxLabel.TabIndex = 22;
            this.IDBoxLabel.Text = "ID#:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(544, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(142, 20);
            this.nameBox.TabIndex = 23;
            // 
            // c5Box
            // 
            this.c5Box.Location = new System.Drawing.Point(544, 255);
            this.c5Box.Name = "c5Box";
            this.c5Box.Size = new System.Drawing.Size(142, 20);
            this.c5Box.TabIndex = 29;
            // 
            // c4Box
            // 
            this.c4Box.Location = new System.Drawing.Point(544, 217);
            this.c4Box.Name = "c4Box";
            this.c4Box.Size = new System.Drawing.Size(142, 20);
            this.c4Box.TabIndex = 28;
            // 
            // c3Box
            // 
            this.c3Box.Location = new System.Drawing.Point(544, 180);
            this.c3Box.Name = "c3Box";
            this.c3Box.Size = new System.Drawing.Size(142, 20);
            this.c3Box.TabIndex = 27;
            // 
            // c2Box
            // 
            this.c2Box.Location = new System.Drawing.Point(544, 144);
            this.c2Box.Name = "c2Box";
            this.c2Box.Size = new System.Drawing.Size(142, 20);
            this.c2Box.TabIndex = 26;
            // 
            // c1Box
            // 
            this.c1Box.Location = new System.Drawing.Point(544, 110);
            this.c1Box.Name = "c1Box";
            this.c1Box.Size = new System.Drawing.Size(142, 20);
            this.c1Box.TabIndex = 25;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(544, 77);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(142, 20);
            this.idBox.TabIndex = 24;
            // 
            // imageButtonLabel
            // 
            this.imageButtonLabel.AutoSize = true;
            this.imageButtonLabel.Location = new System.Drawing.Point(477, 296);
            this.imageButtonLabel.Name = "imageButtonLabel";
            this.imageButtonLabel.Size = new System.Drawing.Size(38, 14);
            this.imageButtonLabel.TabIndex = 31;
            this.imageButtonLabel.Text = "Image:";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(544, 292);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(142, 23);
            this.uploadButton.TabIndex = 30;
            this.uploadButton.Text = "Upload an Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.DefaultExt = "tiotag";
            this.loadFileDialog.Filter = "TIOTAG files (*.tiotag)|*.tiotag|XML files (*.xml)|*.xml";
            this.loadFileDialog.InitialDirectory = "c:Libraries/Documents";
            this.loadFileDialog.Title = "Load batabase (.tiotag)";
            this.loadFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadFileDialog_FileOk);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(471, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 41);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(635, 327);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 41);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(553, 327);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 41);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(591, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 26);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save Database";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveDatabaseDialog
            // 
            this.saveDatabaseDialog.DefaultExt = "tiotag";
            this.saveDatabaseDialog.Filter = "TIOTAG files (*.tiotag)|*.tiotag";
            this.saveDatabaseDialog.Title = "Save my database (.tiotag)";
            this.saveDatabaseDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDatabaseDialog_FileOk);
            // 
            // loadImageDialog
            // 
            this.loadImageDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|BMP file" +
    "s (*.bmp)|*.bmp";
            this.loadImageDialog.InitialDirectory = "c:Libraries/Pictures";
            this.loadImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadImageDialog_FileOk);
            // 
            // nameLabelLabel
            // 
            this.nameLabelLabel.AutoSize = true;
            this.nameLabelLabel.Location = new System.Drawing.Point(40, 261);
            this.nameLabelLabel.Name = "nameLabelLabel";
            this.nameLabelLabel.Size = new System.Drawing.Size(37, 14);
            this.nameLabelLabel.TabIndex = 35;
            this.nameLabelLabel.Text = "Name:";
            // 
            // idLabelLabel
            // 
            this.idLabelLabel.AutoSize = true;
            this.idLabelLabel.Location = new System.Drawing.Point(52, 296);
            this.idLabelLabel.Name = "idLabelLabel";
            this.idLabelLabel.Size = new System.Drawing.Size(25, 14);
            this.idLabelLabel.TabIndex = 36;
            this.idLabelLabel.Text = "ID#:";
            // 
            // custom1LabelLabel
            // 
            this.custom1LabelLabel.Location = new System.Drawing.Point(12, 327);
            this.custom1LabelLabel.Name = "custom1LabelLabel";
            this.custom1LabelLabel.Size = new System.Drawing.Size(65, 14);
            this.custom1LabelLabel.TabIndex = 37;
            this.custom1LabelLabel.Text = "Custom1:";
            this.custom1LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom2LabelLabel
            // 
            this.custom2LabelLabel.Location = new System.Drawing.Point(12, 359);
            this.custom2LabelLabel.Name = "custom2LabelLabel";
            this.custom2LabelLabel.Size = new System.Drawing.Size(65, 14);
            this.custom2LabelLabel.TabIndex = 38;
            this.custom2LabelLabel.Text = "Custom2:";
            this.custom2LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom3LabelLabel
            // 
            this.custom3LabelLabel.Location = new System.Drawing.Point(12, 393);
            this.custom3LabelLabel.Name = "custom3LabelLabel";
            this.custom3LabelLabel.Size = new System.Drawing.Size(65, 14);
            this.custom3LabelLabel.TabIndex = 39;
            this.custom3LabelLabel.Text = "Custom3:";
            this.custom3LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom4LabelLabel
            // 
            this.custom4LabelLabel.Location = new System.Drawing.Point(12, 426);
            this.custom4LabelLabel.Name = "custom4LabelLabel";
            this.custom4LabelLabel.Size = new System.Drawing.Size(65, 14);
            this.custom4LabelLabel.TabIndex = 40;
            this.custom4LabelLabel.Text = "Custom4:";
            this.custom4LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // custom5LabelLabel
            // 
            this.custom5LabelLabel.Location = new System.Drawing.Point(12, 459);
            this.custom5LabelLabel.Name = "custom5LabelLabel";
            this.custom5LabelLabel.Size = new System.Drawing.Size(65, 14);
            this.custom5LabelLabel.TabIndex = 41;
            this.custom5LabelLabel.Text = "Custom5:";
            this.custom5LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.Location = new System.Drawing.Point(698, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 24);
            this.helpButton.TabIndex = 42;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "Clear Selection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.custom5LabelLabel);
            this.Controls.Add(this.custom4LabelLabel);
            this.Controls.Add(this.custom3LabelLabel);
            this.Controls.Add(this.custom2LabelLabel);
            this.Controls.Add(this.custom1LabelLabel);
            this.Controls.Add(this.idLabelLabel);
            this.Controls.Add(this.nameLabelLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.imageButtonLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.c1Box);
            this.Controls.Add(this.c2Box);
            this.Controls.Add(this.c3Box);
            this.Controls.Add(this.c4Box);
            this.Controls.Add(this.c5Box);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IDBoxLabel);
            this.Controls.Add(this.custom1BoxLabel);
            this.Controls.Add(this.custom2BoxLabel);
            this.Controls.Add(this.custom3BoxLabel);
            this.Controls.Add(this.custom4BoxLabel);
            this.Controls.Add(this.custom5BoxLabel);
            this.Controls.Add(this.nameBoxLabel);
            this.Controls.Add(this.editObjectLabel);
            this.Controls.Add(this.viewObjectLabel);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.custom5Label);
            this.Controls.Add(this.custom4Label);
            this.Controls.Add(this.custom3Label);
            this.Controls.Add(this.custom2Label);
            this.Controls.Add(this.custom1Label);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.IdSearchLabel);
            this.Controls.Add(this.nameSearchLabel);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.IDListBox);
            this.Controls.Add(this.nameListBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "Tiotag Database - Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.Click += new System.EventHandler(this.Edit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.ListBox IDListBox;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Label nameSearchLabel;
        private System.Windows.Forms.Label IdSearchLabel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label custom1Label;
        private System.Windows.Forms.Label custom2Label;
        private System.Windows.Forms.Label custom3Label;
        private System.Windows.Forms.Label custom4Label;
        private System.Windows.Forms.Label custom5Label;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label viewObjectLabel;
        private System.Windows.Forms.Label editObjectLabel;
        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.Label custom5BoxLabel;
        private System.Windows.Forms.Label custom4BoxLabel;
        private System.Windows.Forms.Label custom3BoxLabel;
        private System.Windows.Forms.Label custom2BoxLabel;
        private System.Windows.Forms.Label custom1BoxLabel;
        private System.Windows.Forms.Label IDBoxLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox c5Box;
        private System.Windows.Forms.TextBox c4Box;
        private System.Windows.Forms.TextBox c3Box;
        private System.Windows.Forms.TextBox c2Box;
        private System.Windows.Forms.TextBox c1Box;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label imageButtonLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveDatabaseDialog;
        private System.Windows.Forms.OpenFileDialog loadImageDialog;
        private System.Windows.Forms.Label nameLabelLabel;
        private System.Windows.Forms.Label idLabelLabel;
        private System.Windows.Forms.Label custom1LabelLabel;
        private System.Windows.Forms.Label custom2LabelLabel;
        private System.Windows.Forms.Label custom3LabelLabel;
        private System.Windows.Forms.Label custom4LabelLabel;
        private System.Windows.Forms.Label custom5LabelLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button button1;
    }
}