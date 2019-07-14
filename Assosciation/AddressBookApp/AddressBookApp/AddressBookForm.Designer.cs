namespace AddressBookApp
{
    partial class AddressBookForm
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
            this.personalInfoBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editEmailextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.editEmailLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.searchPhoneLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPhoneTextBox = new System.Windows.Forms.TextBox();
            this.searchEmailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchEmailLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameSearchLabel = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.messageLabel = new System.Windows.Forms.Label();
            this.personalInfoBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInfoBox
            // 
            this.personalInfoBox.Controls.Add(this.saveButton);
            this.personalInfoBox.Controls.Add(this.phoneNoTextBox);
            this.personalInfoBox.Controls.Add(this.emailTextBox);
            this.personalInfoBox.Controls.Add(this.lastNameTextBox);
            this.personalInfoBox.Controls.Add(this.firstNameTextBox);
            this.personalInfoBox.Controls.Add(this.phoneNoLabel);
            this.personalInfoBox.Controls.Add(this.emailLabel);
            this.personalInfoBox.Controls.Add(this.lastNameLabel);
            this.personalInfoBox.Controls.Add(this.firstNameLabel);
            this.personalInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoBox.Location = new System.Drawing.Point(12, 24);
            this.personalInfoBox.Name = "personalInfoBox";
            this.personalInfoBox.Size = new System.Drawing.Size(361, 292);
            this.personalInfoBox.TabIndex = 0;
            this.personalInfoBox.TabStop = false;
            this.personalInfoBox.Text = "Personal Info";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(250, 217);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(133, 158);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(192, 22);
            this.phoneNoTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(133, 118);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(192, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(133, 76);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(133, 37);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Location = new System.Drawing.Point(25, 161);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(80, 16);
            this.phoneNoLabel.TabIndex = 0;
            this.phoneNoLabel.Text = "Phone No.";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(25, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 16);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(25, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(82, 16);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(83, 16);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editEmailextBox);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.editEmailLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Info";
            // 
            // editEmailextBox
            // 
            this.editEmailextBox.Location = new System.Drawing.Point(127, 34);
            this.editEmailextBox.Name = "editEmailextBox";
            this.editEmailextBox.Size = new System.Drawing.Size(192, 22);
            this.editEmailextBox.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(223, 77);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editEmailLabel
            // 
            this.editEmailLabel.AutoSize = true;
            this.editEmailLabel.Location = new System.Drawing.Point(36, 40);
            this.editEmailLabel.Name = "editEmailLabel";
            this.editEmailLabel.Size = new System.Drawing.Size(47, 16);
            this.editEmailLabel.TabIndex = 0;
            this.editEmailLabel.Text = "Email";
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.searchPhoneLabel);
            this.searchBox.Controls.Add(this.searchButton);
            this.searchBox.Controls.Add(this.searchPhoneTextBox);
            this.searchBox.Controls.Add(this.searchEmailTextBox);
            this.searchBox.Controls.Add(this.lastNameSearchTextBox);
            this.searchBox.Controls.Add(this.searchEmailLabel);
            this.searchBox.Controls.Add(this.label7);
            this.searchBox.Controls.Add(this.lastNameSearchLabel);
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(408, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(380, 224);
            this.searchBox.TabIndex = 1;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search Option";
            // 
            // searchPhoneLabel
            // 
            this.searchPhoneLabel.AutoSize = true;
            this.searchPhoneLabel.Location = new System.Drawing.Point(36, 137);
            this.searchPhoneLabel.Name = "searchPhoneLabel";
            this.searchPhoneLabel.Size = new System.Drawing.Size(80, 16);
            this.searchPhoneLabel.TabIndex = 3;
            this.searchPhoneLabel.Text = "Phone No.";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(244, 173);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPhoneTextBox
            // 
            this.searchPhoneTextBox.Location = new System.Drawing.Point(139, 130);
            this.searchPhoneTextBox.Name = "searchPhoneTextBox";
            this.searchPhoneTextBox.Size = new System.Drawing.Size(180, 22);
            this.searchPhoneTextBox.TabIndex = 1;
            // 
            // searchEmailTextBox
            // 
            this.searchEmailTextBox.Location = new System.Drawing.Point(139, 88);
            this.searchEmailTextBox.Name = "searchEmailTextBox";
            this.searchEmailTextBox.Size = new System.Drawing.Size(180, 22);
            this.searchEmailTextBox.TabIndex = 1;
            // 
            // lastNameSearchTextBox
            // 
            this.lastNameSearchTextBox.Location = new System.Drawing.Point(139, 42);
            this.lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            this.lastNameSearchTextBox.Size = new System.Drawing.Size(180, 22);
            this.lastNameSearchTextBox.TabIndex = 1;
            // 
            // searchEmailLabel
            // 
            this.searchEmailLabel.AutoSize = true;
            this.searchEmailLabel.Location = new System.Drawing.Point(36, 88);
            this.searchEmailLabel.Name = "searchEmailLabel";
            this.searchEmailLabel.Size = new System.Drawing.Size(47, 16);
            this.searchEmailLabel.TabIndex = 0;
            this.searchEmailLabel.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // lastNameSearchLabel
            // 
            this.lastNameSearchLabel.AutoSize = true;
            this.lastNameSearchLabel.Location = new System.Drawing.Point(36, 49);
            this.lastNameSearchLabel.Name = "lastNameSearchLabel";
            this.lastNameSearchLabel.Size = new System.Drawing.Size(82, 16);
            this.lastNameSearchLabel.TabIndex = 0;
            this.lastNameSearchLabel.Text = "Last Name";
            // 
            // showDataGridView
            // 
            this.showDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(422, 284);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(380, 179);
            this.showDataGridView.TabIndex = 2;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(444, 251);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 0;
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(839, 475);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.personalInfoBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "AddressBookForm";
            this.Text = "Address Book Form";
            this.personalInfoBox.ResumeLayout(false);
            this.personalInfoBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInfoBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label editEmailLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchPhoneTextBox;
        private System.Windows.Forms.TextBox searchEmailTextBox;
        private System.Windows.Forms.TextBox lastNameSearchTextBox;
        private System.Windows.Forms.Label searchEmailLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lastNameSearchLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label searchPhoneLabel;
        private System.Windows.Forms.TextBox editEmailextBox;
    }
}

