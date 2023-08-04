namespace NewClient
{
    partial class LandingPage
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
            this.createNewClient = new System.Windows.Forms.Button();
            this.createNewContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewClient
            // 
            this.createNewClient.Location = new System.Drawing.Point(136, 113);
            this.createNewClient.Name = "createNewClient";
            this.createNewClient.Size = new System.Drawing.Size(232, 225);
            this.createNewClient.TabIndex = 0;
            this.createNewClient.Text = "Create New Client";
            this.createNewClient.UseVisualStyleBackColor = true;
            this.createNewClient.Click += new System.EventHandler(this.createNewClient_Click);
            // 
            // createNewContact
            // 
            this.createNewContact.Location = new System.Drawing.Point(384, 113);
            this.createNewContact.Name = "createNewContact";
            this.createNewContact.Size = new System.Drawing.Size(232, 225);
            this.createNewContact.TabIndex = 1;
            this.createNewContact.Text = "Create New Contact";
            this.createNewContact.UseVisualStyleBackColor = true;
            this.createNewContact.Click += new System.EventHandler(this.createNewContact_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createNewContact);
            this.Controls.Add(this.createNewClient);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewClient;
        private System.Windows.Forms.Button createNewContact;
    }
}