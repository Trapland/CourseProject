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
    public partial class Project : Form
    {
        static Random r = new Random();
        List<RichTextBox> l;
        string dark = "0";
        string file_name = "Project" + r.Next().ToString() + ".txt";
        public Project()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("Dark.txt", Encoding.UTF8))
            {
                dark = sr.ReadLine();
                if (dark == "1")
                {
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.Gray;

                    tabControl.TabPages[0].BackColor = Color.Black;
                    tabControl.TabPages[0].ForeColor = Color.Gray;

                    addButton.BackColor = Color.Black;
                    addButton.ForeColor = Color.Gray;

                    closeButton.BackColor = Color.Black;
                    closeButton.ForeColor = Color.Gray;
                }
            }
            l = new List<RichTextBox>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Projects.txt", true))
            {
                sw.WriteLine(file_name);
            }
            createDeloProj c = new createDeloProj();
            if (c.ShowDialog() == DialogResult.Cancel)
            {
                RichTextBox r = new RichTextBox();
                r.ReadOnly = true;
                r.Location = new Point(0, 0);
                r.Size = new Size(500, 500);
                r.AllowDrop = true;
                if (dark == "1")
                {
                    r.BackColor = Color.Black;
                    r.ForeColor = Color.Gray;
                }
                l.Add(r);
                using (StreamReader sr = new StreamReader(file_name, Encoding.UTF8))
                {
                    if (l.Count > 1)
                        tabControl.TabPages.Add("Delo");
                    for (int i = 0; i < l.Count; i++)
                    {
                        tabControl.TabPages[i].Controls.Add(l[i]);
                        l[i].Show();
                        l[i].Text = sr.ReadLine() + "\n";
                        l[i].Text += sr.ReadLine() + "\n";
                        l[i].Text += sr.ReadLine() + "\n";
                        l[i].Text += sr.ReadLine() + "\n";
                        l[i].Text += sr.ReadLine() + "\n";
                        l[i].Text += sr.ReadLine() + "\n";
                    }
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (dark == "1")
                        {
                            tabControl.TabPages[i].BackColor = Color.Black;
                            tabControl.TabPages[i].ForeColor = Color.Gray;
                        }
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            tabControl.AllowDrop = true;
        }

        private void Project_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Project_DragDrop(object sender, DragEventArgs e)
        {
            string s = (string) e.Data.GetData(DataFormats.StringFormat);
            l[tabControl.SelectedIndex].Text = s;
        }

        private void tabControl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TabPage)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void tabControl_DragDrop(object sender, DragEventArgs e)
        {
            string s = (string)e.Data.GetData(DataFormats.StringFormat);
            l[tabControl.SelectedIndex].Text = s;
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tabControl.DoDragDrop(l[tabControl.SelectedIndex].Text, DragDropEffects.All);
            }
        }
    }
}
