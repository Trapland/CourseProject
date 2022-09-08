
namespace WinFormsApp9
{
    partial class spisokDel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createDeloButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.showButton2 = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.pdfSaveButton = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDeloButton
            // 
            this.createDeloButton.Location = new System.Drawing.Point(40, 35);
            this.createDeloButton.Name = "createDeloButton";
            this.createDeloButton.Size = new System.Drawing.Size(75, 23);
            this.createDeloButton.TabIndex = 0;
            this.createDeloButton.Text = "Create delo";
            this.createDeloButton.UseVisualStyleBackColor = true;
            this.createDeloButton.Click += new System.EventHandler(this.createDeloButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(40, 89);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show for";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month"});
            this.dateBox.Location = new System.Drawing.Point(160, 89);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(75, 23);
            this.dateBox.TabIndex = 1;
            // 
            // showButton2
            // 
            this.showButton2.Location = new System.Drawing.Point(40, 137);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(75, 23);
            this.showButton2.TabIndex = 0;
            this.showButton2.Text = "Show by";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Priority",
            "Tags"});
            this.categoryBox.Location = new System.Drawing.Point(160, 137);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(75, 23);
            this.categoryBox.TabIndex = 1;
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(160, 233);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(75, 23);
            this.createProjectButton.TabIndex = 0;
            this.createProjectButton.Text = "Create proj";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // pdfSaveButton
            // 
            this.pdfSaveButton.Location = new System.Drawing.Point(40, 233);
            this.pdfSaveButton.Name = "pdfSaveButton";
            this.pdfSaveButton.Size = new System.Drawing.Size(75, 23);
            this.pdfSaveButton.TabIndex = 0;
            this.pdfSaveButton.Text = "Save in pdf";
            this.pdfSaveButton.UseVisualStyleBackColor = true;
            this.pdfSaveButton.Click += new System.EventHandler(this.pdfSaveButton_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(40, 192);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(195, 23);
            this.valueBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input value of chosen category:";
            // 
            // Dark
            // 
            this.Dark.Location = new System.Drawing.Point(160, 35);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(75, 23);
            this.Dark.TabIndex = 4;
            this.Dark.Text = "Dark mode";
            this.Dark.UseVisualStyleBackColor = true;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // spisokDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 277);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.pdfSaveButton);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.createDeloButton);
            this.Name = "spisokDel";
            this.Text = "Spisok del";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createDeloButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.Button showButton2;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button pdfSaveButton;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dark;
    }
}

