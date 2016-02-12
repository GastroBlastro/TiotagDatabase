namespace TiotagDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createLabel = new System.Windows.Forms.Label();
            this.createSubLabel = new System.Windows.Forms.Label();
            this.createBackLabel = new System.Windows.Forms.Label();
            this.loadSubLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.loadBackLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TiotagDatabase.Properties.Resources.tiotaggif;
            this.pictureBox1.Location = new System.Drawing.Point(59, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(13, 14);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(63, 14);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(220, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // createLabel
            // 
            this.createLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.Location = new System.Drawing.Point(96, 222);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(122, 25);
            this.createLabel.TabIndex = 3;
            this.createLabel.Text = "Create New";
            this.createLabel.Click += new System.EventHandler(this.createLabel_Click);
            this.createLabel.MouseLeave += new System.EventHandler(this.createLabel_MouseLeave);
            this.createLabel.MouseHover += new System.EventHandler(this.createLabel_MouseHover);
            // 
            // createSubLabel
            // 
            this.createSubLabel.AutoSize = true;
            this.createSubLabel.Location = new System.Drawing.Point(91, 247);
            this.createSubLabel.Name = "createSubLabel";
            this.createSubLabel.Size = new System.Drawing.Size(131, 28);
            this.createSubLabel.TabIndex = 4;
            this.createSubLabel.Text = "Create a new customized\r\ndatabase from scratch";
            this.createSubLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createSubLabel.Click += new System.EventHandler(this.createSubLabel_Click);
            this.createSubLabel.MouseLeave += new System.EventHandler(this.createSubLabel_MouseLeave);
            this.createSubLabel.MouseHover += new System.EventHandler(this.createSubLabel_MouseHover);
            // 
            // createBackLabel
            // 
            this.createBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createBackLabel.Location = new System.Drawing.Point(74, 208);
            this.createBackLabel.Name = "createBackLabel";
            this.createBackLabel.Size = new System.Drawing.Size(165, 83);
            this.createBackLabel.TabIndex = 5;
            this.createBackLabel.Click += new System.EventHandler(this.createBackLabel_Click);
            this.createBackLabel.MouseLeave += new System.EventHandler(this.createBackLabel_MouseLeave);
            this.createBackLabel.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // loadSubLabel
            // 
            this.loadSubLabel.AutoSize = true;
            this.loadSubLabel.Location = new System.Drawing.Point(301, 249);
            this.loadSubLabel.Name = "loadSubLabel";
            this.loadSubLabel.Size = new System.Drawing.Size(139, 28);
            this.loadSubLabel.TabIndex = 7;
            this.loadSubLabel.Text = "Open and edit a previously \r\ncreated database.";
            this.loadSubLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadSubLabel.Click += new System.EventHandler(this.loadSubLabel_Click);
            this.loadSubLabel.MouseLeave += new System.EventHandler(this.loadSubLabel_MouseLeave);
            this.loadSubLabel.MouseHover += new System.EventHandler(this.loadSubLabel_MouseHover);
            // 
            // loadLabel
            // 
            this.loadLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(303, 222);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(136, 25);
            this.loadLabel.TabIndex = 6;
            this.loadLabel.Text = "Load Existing";
            this.loadLabel.Click += new System.EventHandler(this.loadLabel_Click);
            this.loadLabel.MouseLeave += new System.EventHandler(this.loadLabel_MouseLeave);
            this.loadLabel.MouseHover += new System.EventHandler(this.loadLabel_MouseHover);
            // 
            // loadBackLabel
            // 
            this.loadBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadBackLabel.Location = new System.Drawing.Point(288, 208);
            this.loadBackLabel.Name = "loadBackLabel";
            this.loadBackLabel.Size = new System.Drawing.Size(165, 83);
            this.loadBackLabel.TabIndex = 8;
            this.loadBackLabel.Click += new System.EventHandler(this.loadBackLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 338);
            this.Controls.Add(this.loadSubLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.createSubLabel);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createBackLabel);
            this.Controls.Add(this.loadBackLabel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tiotag Database - Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label createSubLabel;
        private System.Windows.Forms.Label createBackLabel;
        private System.Windows.Forms.Label loadSubLabel;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label loadBackLabel;


    }
}

