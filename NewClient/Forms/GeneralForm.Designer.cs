namespace NewClient
{
    partial class GeneralTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralTab));
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CreateNewClient = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientCodeTB = new System.Windows.Forms.TextBox();
            this.BackToMain = new System.Windows.Forms.LinkLabel();
            this.GeneralDataGridView = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            resources.ApplyResources(this.NameTB, "NameTB");
            this.NameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTB.Name = "NameTB";
            // 
            // CreateNewClient
            // 
            resources.ApplyResources(this.CreateNewClient, "CreateNewClient");
            this.CreateNewClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreateNewClient.Name = "CreateNewClient";
            this.CreateNewClient.UseVisualStyleBackColor = false;
            this.CreateNewClient.Click += new System.EventHandler(this.CreateNewClient_Click);
            // 
            // Clients
            // 
            resources.ApplyResources(this.Clients, "Clients");
            this.Clients.Name = "Clients";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ClientCodeTB
            // 
            resources.ApplyResources(this.ClientCodeTB, "ClientCodeTB");
            this.ClientCodeTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientCodeTB.Name = "ClientCodeTB";
            this.ClientCodeTB.TextChanged += new System.EventHandler(this.ClientCodeTB_TextChanged);
            // 
            // BackToMain
            // 
            resources.ApplyResources(this.BackToMain, "BackToMain");
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.TabStop = true;
            this.BackToMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToMain_LinkClicked);
            // 
            // GeneralDataGridView
            // 
            this.GeneralDataGridView.AllowUserToAddRows = false;
            this.GeneralDataGridView.AllowUserToDeleteRows = false;
            this.GeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.GeneralDataGridView, "GeneralDataGridView");
            this.GeneralDataGridView.Name = "GeneralDataGridView";
            this.GeneralDataGridView.ReadOnly = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // ViewButton
            // 
            resources.ApplyResources(this.ViewButton, "ViewButton");
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // GeneralTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.GeneralDataGridView);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientCodeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.CreateNewClient);
            this.Controls.Add(this.NameTB);
            this.Name = "GeneralTab";
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button CreateNewClient;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientCodeTB;
        private System.Windows.Forms.LinkLabel BackToMain;
        private System.Windows.Forms.DataGridView GeneralDataGridView;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ViewButton;
    }
}

