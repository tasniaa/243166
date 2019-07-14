namespace MobileHandsetFormsApp
{
    partial class IndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SaveMobileHandsetButton = new System.Windows.Forms.Button();
            this.SearchbyPriceButton = new System.Windows.Forms.Button();
            this.SearchbyImeiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index";
            // 
            // SaveMobileHandsetButton
            // 
            this.SaveMobileHandsetButton.Location = new System.Drawing.Point(253, 151);
            this.SaveMobileHandsetButton.Name = "SaveMobileHandsetButton";
            this.SaveMobileHandsetButton.Size = new System.Drawing.Size(279, 23);
            this.SaveMobileHandsetButton.TabIndex = 1;
            this.SaveMobileHandsetButton.Text = "Save Mobile Handset Information";
            this.SaveMobileHandsetButton.UseVisualStyleBackColor = true;
            this.SaveMobileHandsetButton.Click += new System.EventHandler(this.SaveMobileHandsetButton_Click_1);
            // 
            // SearchbyPriceButton
            // 
            this.SearchbyPriceButton.Location = new System.Drawing.Point(253, 193);
            this.SearchbyPriceButton.Name = "SearchbyPriceButton";
            this.SearchbyPriceButton.Size = new System.Drawing.Size(279, 23);
            this.SearchbyPriceButton.TabIndex = 1;
            this.SearchbyPriceButton.Text = "Search Mobile Handset by Price Range";
            this.SearchbyPriceButton.UseVisualStyleBackColor = true;
            this.SearchbyPriceButton.Click += new System.EventHandler(this.SearchbyPriceButton_Click_1);
            // 
            // SearchbyImeiButton
            // 
            this.SearchbyImeiButton.Location = new System.Drawing.Point(253, 242);
            this.SearchbyImeiButton.Name = "SearchbyImeiButton";
            this.SearchbyImeiButton.Size = new System.Drawing.Size(279, 23);
            this.SearchbyImeiButton.TabIndex = 1;
            this.SearchbyImeiButton.Text = "Search Mobile Handset by IMEI";
            this.SearchbyImeiButton.UseVisualStyleBackColor = true;
            this.SearchbyImeiButton.Click += new System.EventHandler(this.SearchbyImeiButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchbyImeiButton);
            this.Controls.Add(this.SearchbyPriceButton);
            this.Controls.Add(this.SaveMobileHandsetButton);
            this.Controls.Add(this.label1);
            this.Name = "IndexForm";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveMobileHandsetButton;
        private System.Windows.Forms.Button SearchbyPriceButton;
        private System.Windows.Forms.Button SearchbyImeiButton;
    }
}

