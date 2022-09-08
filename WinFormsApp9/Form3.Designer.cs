
namespace WinFormsApp9
{
    partial class spisok
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
            this.ListDel = new System.Windows.Forms.RichTextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListDel
            // 
            this.ListDel.Location = new System.Drawing.Point(0, 0);
            this.ListDel.Name = "ListDel";
            this.ListDel.ReadOnly = true;
            this.ListDel.Size = new System.Drawing.Size(493, 417);
            this.ListDel.TabIndex = 0;
            this.ListDel.Text = "";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(215, 423);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // spisok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ListDel);
            this.Name = "spisok";
            this.Text = "List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ListDel;
        private System.Windows.Forms.Button OK;
    }
}