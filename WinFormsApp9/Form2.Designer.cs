
namespace WinFormsApp9
{
    partial class create
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.attachedFileBox = new System.Windows.Forms.TextBox();
            this.fileAttachButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CreateDelo = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Priority:";
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.priorityBox.Location = new System.Drawing.Point(95, 110);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(121, 23);
            this.priorityBox.TabIndex = 1;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(95, 57);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(121, 23);
            this.timeBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tags:";
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(95, 155);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(303, 23);
            this.tagBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comment:";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(95, 207);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(303, 76);
            this.commentBox.TabIndex = 4;
            this.commentBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "File:";
            // 
            // attachedFileBox
            // 
            this.attachedFileBox.Location = new System.Drawing.Point(95, 306);
            this.attachedFileBox.Name = "attachedFileBox";
            this.attachedFileBox.Size = new System.Drawing.Size(254, 23);
            this.attachedFileBox.TabIndex = 3;
            // 
            // fileAttachButton
            // 
            this.fileAttachButton.Location = new System.Drawing.Point(355, 306);
            this.fileAttachButton.Name = "fileAttachButton";
            this.fileAttachButton.Size = new System.Drawing.Size(43, 23);
            this.fileAttachButton.TabIndex = 5;
            this.fileAttachButton.Text = "...";
            this.fileAttachButton.UseVisualStyleBackColor = true;
            this.fileAttachButton.Click += new System.EventHandler(this.fileAttachButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateDelo
            // 
            this.CreateDelo.Location = new System.Drawing.Point(160, 349);
            this.CreateDelo.Name = "CreateDelo";
            this.CreateDelo.Size = new System.Drawing.Size(111, 38);
            this.CreateDelo.TabIndex = 6;
            this.CreateDelo.Text = "Create";
            this.CreateDelo.UseVisualStyleBackColor = true;
            this.CreateDelo.Click += new System.EventHandler(this.CreateDelo_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(95, 12);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 7, 17, 51, 31, 0);
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 399);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CreateDelo);
            this.Controls.Add(this.fileAttachButton);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.attachedFileBox);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "create";
            this.Text = "Create delo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attachedFileBox;
        private System.Windows.Forms.Button fileAttachButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CreateDelo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}