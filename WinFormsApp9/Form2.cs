using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp9
{
    public partial class create : Form
    {
        string spisok = "Spisok_Del.txt";
        string attachedFileName;
        public create()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("Dark.txt", Encoding.UTF8))
            {
                if (sr.ReadLine() == "1")
                {
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.Gray;

                    dateTimePicker.CalendarForeColor = Color.Gray;
                    dateTimePicker.CalendarTitleBackColor = Color.Black;
                    dateTimePicker.CalendarTitleForeColor = Color.Gray;
                    dateTimePicker.CalendarTrailingForeColor = Color.Gray;
                    dateTimePicker.CalendarMonthBackground = Color.Black;
                    // календарь цвет не меняет увы :(

                    timeBox.BackColor = Color.Black;
                    timeBox.ForeColor = Color.Gray;

                    priorityBox.BackColor = Color.Black;
                    priorityBox.ForeColor = Color.Gray;

                    tagBox.BackColor = Color.Black;
                    tagBox.ForeColor = Color.Gray;

                    commentBox.BackColor = Color.Black;
                    commentBox.ForeColor = Color.Gray;

                    attachedFileBox.BackColor = Color.Black;
                    attachedFileBox.ForeColor = Color.Gray;

                    fileAttachButton.BackColor = Color.Black;
                    fileAttachButton.ForeColor = Color.Gray;

                    label1.BackColor = Color.Black;
                    label1.ForeColor = Color.Gray;

                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.Gray;

                    label3.BackColor = Color.Black;
                    label3.ForeColor = Color.Gray;

                    label4.BackColor = Color.Black;
                    label4.ForeColor = Color.Gray;

                    label5.BackColor = Color.Black;
                    label5.ForeColor = Color.Gray;

                    label6.BackColor = Color.Black;
                    label6.ForeColor = Color.Gray;

                    CreateDelo.BackColor = Color.Black;
                    CreateDelo.ForeColor = Color.Gray;
                }
            }
            priorityBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
        }

        private void fileAttachButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            attachedFileName = openFileDialog1.FileName;
            attachedFileBox.Text = attachedFileName;
        }

        private void CreateDelo_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter(spisok,true))
            {
                sw.WriteLine(dateTimePicker.Text);
                sw.WriteLine(timeBox.Text);
                sw.WriteLine(priorityBox.SelectedItem.ToString());
                sw.WriteLine(tagBox.Text);
                sw.WriteLine(commentBox.Text);
                sw.WriteLine(attachedFileBox.Text);
            }

            this.Close();
        }
    }
}
