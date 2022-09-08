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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace WinFormsApp9
{
    public partial class spisokDel : Form
    {
        string spisok = "Spisok_Del.txt";
        string dark = "0";
        
        public spisokDel()
        {
            InitializeComponent();
            using (StreamWriter sw = new StreamWriter("Dark.txt", false))
            {
                sw.WriteLine(dark);
            }
            dateBox.SelectedIndex = 0;
            categoryBox.SelectedIndex = 0;
        }

        private void createDeloButton_Click(object sender, EventArgs e)
        {
            create c = new create();
            c.Show();
        }

        private void pdfSaveButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(spisok, Encoding.UTF8))
            {
                string newFile = "Spisok_Del.pdf";
                // open the reader
                Document document = new Document();
                // open the writer
                FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();
                while (sr.Peek() != -1)
                {
                    Paragraph p = new Paragraph(sr.ReadLine());
                    document.Add(p);
                }
                // close the streams
                document.Close();
                fs.Close();
                writer.Close();
            }

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Show();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("showlist.txt", false))
            {
                using (StreamReader sr = new StreamReader(spisok, Encoding.UTF8))
                {
                    while (sr.Peek() != -1)
                    {
                        string date = sr.ReadLine();
                        string time = sr.ReadLine();
                        string priority = sr.ReadLine();
                        string tag = sr.ReadLine();
                        string comment = sr.ReadLine();
                        string attFile = sr.ReadLine();
                        if (dateBox.Text == "Day")
                        {
                            if (Convert.ToInt32(date[0].ToString() + date[1].ToString()) == DateTime.Now.Day)
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                        else if (dateBox.Text == "Week")
                        {
                            if (Convert.ToInt32(date[0].ToString() + date[1].ToString()) <= DateTime.Now.Day + 7 && Convert.ToInt32(date[0].ToString() + date[1].ToString()) >= DateTime.Now.Day)
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                        else if (dateBox.Text == "Month")
                        {
                            if (Convert.ToInt32(date[3].ToString() + date[4].ToString()) == DateTime.Now.Month)
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                    }
                }
            }
            spisok s = new spisok();
            s.Show();
        }

        private void showButton2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("showlist.txt", false))
            {
                using (StreamReader sr = new StreamReader(spisok, Encoding.UTF8))
                {
                    while (sr.Peek() != -1)
                    {
                        string date = sr.ReadLine();
                        string time = sr.ReadLine();
                        string priority = sr.ReadLine();
                        string tag = sr.ReadLine();
                        string comment = sr.ReadLine();
                        string attFile = sr.ReadLine();
                        if (categoryBox.Text == "Date")
                        {
                            if (date.Contains(valueBox.Text))
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                        else if (categoryBox.Text == "Time")
                        {
                            if (time.Contains(valueBox.Text))
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                        else if (categoryBox.Text == "Priority")
                        {
                            if (priority.Contains(valueBox.Text))
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                        else if (categoryBox.Text == "Tags")
                        {
                            if (tag.Contains(valueBox.Text))
                            {
                                sw.WriteLine(date);
                                sw.WriteLine(time);
                                sw.WriteLine(priority);
                                sw.WriteLine(tag);
                                sw.WriteLine(comment);
                                sw.WriteLine(attFile);
                            }
                        }
                    }
                }
            }
            spisok s = new spisok();
            s.Show();
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            if(dark == "1")
            {
                dark = "0";
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                createDeloButton.BackColor = Color.White;
                createDeloButton.ForeColor = Color.Black;

                createProjectButton.BackColor = Color.White;
                createProjectButton.ForeColor = Color.Black;

                pdfSaveButton.BackColor = Color.White;
                pdfSaveButton.ForeColor = Color.Black;

                showButton.BackColor = Color.White;
                showButton.ForeColor = Color.Black;

                showButton2.BackColor = Color.White;
                showButton2.ForeColor = Color.Black;

                Dark.BackColor = Color.White;
                Dark.ForeColor = Color.Black;

                dateBox.BackColor = Color.White;
                dateBox.ForeColor = Color.Black;

                categoryBox.BackColor = Color.White;
                categoryBox.ForeColor = Color.Black;

                valueBox.BackColor = Color.White;
                valueBox.ForeColor = Color.Black;
            }
            else if(dark == "0")
            {
                dark = "1";
                this.BackColor = Color.Black;
                this.ForeColor = Color.Gray;
                createDeloButton.BackColor = Color.Black;
                createDeloButton.ForeColor = Color.Gray;

                createProjectButton.BackColor = Color.Black;
                createProjectButton.ForeColor = Color.Gray;

                pdfSaveButton.BackColor = Color.Black;
                pdfSaveButton.ForeColor = Color.Gray;

                showButton.BackColor = Color.Black;
                showButton.ForeColor = Color.Gray;

                showButton2.BackColor = Color.Black;
                showButton2.ForeColor = Color.Gray;

                Dark.BackColor = Color.Black;
                Dark.ForeColor = Color.Gray;

                dateBox.BackColor = Color.Black;
                dateBox.ForeColor = Color.Gray;

                categoryBox.BackColor = Color.Black;
                categoryBox.ForeColor = Color.Gray;

                valueBox.BackColor = Color.Black;
                valueBox.ForeColor = Color.Gray;

            }
            using (StreamWriter sw = new StreamWriter("Dark.txt", false))
            {
                sw.WriteLine(dark);
            }
        }
    }
}
