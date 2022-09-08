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
    public partial class spisok : Form
    {
        public spisok()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("Dark.txt", Encoding.UTF8))
            {
                if (sr.ReadLine() == "1")
                {
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.Gray;

                    ListDel.BackColor = Color.Black;
                    ListDel.ForeColor = Color.Gray;

                    OK.BackColor = Color.Black;
                    OK.ForeColor = Color.Gray;
                }
            }
            using (StreamReader sr = new StreamReader("showlist.txt", Encoding.UTF8))
            {
                while (sr.Peek() != -1)
                {
                    ListDel.Text += sr.ReadLine() + '\n';
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
