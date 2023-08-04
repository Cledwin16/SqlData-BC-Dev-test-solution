namespace NewClient
{
    partial class ContactsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.Label();
            this.CreateContact = new System.Windows.Forms.Button();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.BackToMain = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ContactsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Underline);
            this.Clients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clients.Location = new System.Drawing.Point(244, 9);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(298, 33);
            this.Clients.TabIndex = 11;
            this.Clients.Text = "Create New Contact";
            // 
            // CreateContact
            // 
            this.CreateContact.AccessibleDescription = "CreateNewClient";
            this.CreateContact.AccessibleName = "CreateNewClient";
            this.CreateContact.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreateContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateContact.Location = new System.Drawing.Point(258, 199);
            this.CreateContact.Name = "CreateContact";
            this.CreateContact.Size = new System.Drawing.Size(91, 23);
            this.CreateContact.TabIndex = 10;
            this.CreateContact.Text = "Create Contact";
            this.CreateContact.UseVisualStyleBackColor = false;
            this.CreateContact.Click += new System.EventHandler(this.CreateContact_Click);
            // 
            // SurnameTB
            // 
            this.SurnameTB.AccessibleDescription = "Surname";
            this.SurnameTB.AccessibleName = "SurnameTB";
            this.SurnameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SurnameTB.Location = new System.Drawing.Point(149, 108);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(200, 20);
            this.SurnameTB.TabIndex = 9;
            this.SurnameTB.TextChanged += new System.EventHandler(this.SurnameTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.AccessibleDescription = "Name";
            this.NameTB.AccessibleName = "NameTB";
            this.NameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTB.Location = new System.Drawing.Point(149, 71);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 20);
            this.NameTB.TabIndex = 8;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // BackToMain
            // 
            this.BackToMain.AutoSize = true;
            this.BackToMain.Location = new System.Drawing.Point(19, 416);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(95, 13);
            this.BackToMain.TabIndex = 14;
            this.BackToMain.TabStop = true;
            this.BackToMain.Text = "Back to MainPage";
            this.BackToMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToMain_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            // 
            // EmailTB
            // 
            this.EmailTB.AccessibleDescription = "";
            this.EmailTB.AccessibleName = "emailTB";
            this.EmailTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailTB.Location = new System.Drawing.Point(149, 151);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(200, 20);
            this.EmailTB.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "VIEW CONTACTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(583, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "link contact to client";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ContactsGridView
            // 
            this.ContactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGridView.Location = new System.Drawing.Point(386, 108);
            this.ContactsGridView.Name = "ContactsGridView";
            this.ContactsGridView.Size = new System.Drawing.Size(361, 294);
            this.ContactsGridView.TabIndex = 20;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContactsGridView);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.CreateContact);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.NameTB);
            this.HelpButton = true;
            this.Name = "ContactsForm";
            this.Text = "Contacts Tab";
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Button CreateContact;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.LinkLabel BackToMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView ContactsGridView;
    }
}