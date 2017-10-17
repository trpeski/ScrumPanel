using System;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;

namespace ScrumPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void move_item(CheckedListBox from, CheckedListBox to, ItemCheckEventArgs e)
        {

            if (from.Items[e.Index] != "--- end ---")
            {
                if (to.Items.Count <= from.Items.Count)
                {
                    if (!to.Items.Contains(from.Items[e.Index]))
                    {
                        to.Items.Insert(0, from.Items[e.Index]);
                    }
                }
                else { to.Items.Insert(0, from.Items[e.Index]); }

                from.Items.Remove(from.Items[e.Index]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (todo_box.Items.Count > 1)
            {
                if (!todo_box.Items.Contains(textBox1.Text))
                {
                    todo_box.Items.Insert(0, textBox1.Text);
                    textBox1.Clear();
                }
            }
            else { todo_box.Items.Insert(0, textBox1.Text); textBox1.Clear(); }
        }

        private void in_to_in_process_from_todo(object sender, ItemCheckEventArgs e)
        {
            move_item(todo_box, in_process_box, e);
        }

        private void in_to_test_from_in_process(object sender, ItemCheckEventArgs e)
        {
            move_item(in_process_box, test_box, e);
        }

        private void in_to_release_from_test(object sender, ItemCheckEventArgs e)
        {
            move_item(test_box, release_box, e);
        }

     

        private void key_down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                button1_Click(null, null);
            }
        }

        private void Close_save(object sender, FormClosedEventArgs e)
        {
            FileStream file = File.Open("data.xml", FileMode.Create);
            file.Close();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<root></root>");
        

            XmlNode node = doc.DocumentElement;
           
            for (int i = todo_box.Items.Count - 2; i > -1; i--)
            {
                XmlElement xtodo = doc.CreateElement("todo");
                xtodo.InnerText = todo_box.Items[i].ToString();
                node.AppendChild(xtodo);
            }


            for (int i = in_process_box.Items.Count - 2; i > -1; i--)
            {
                XmlElement xtodo = doc.CreateElement("in_process");
                xtodo.InnerText = in_process_box.Items[i].ToString();
                node.AppendChild(xtodo);
            }


            for (int i = test_box.Items.Count - 2; i > -1; i--)
            {
                XmlElement xtodo = doc.CreateElement("test");
                xtodo.InnerText = test_box.Items[i].ToString();
                node.AppendChild(xtodo);
            }


            for (int i = release_box.Items.Count - 2; i > -1; i--)
            {
                XmlElement xtodo = doc.CreateElement("release");
                xtodo.InnerText = release_box.Items[i].ToString();
                node.AppendChild(xtodo);
            }





            doc.Save("data.xml");

            
        }

        private void Load_Data(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("data.xml");

                foreach (XmlElement text in doc.GetElementsByTagName("todo"))
                {
                    todo_box.Items.Insert(0, text.InnerText);
                }

                foreach (XmlElement text in doc.GetElementsByTagName("in_process"))
                {
                    in_process_box.Items.Insert(0, text.InnerText);
                }

                foreach (XmlElement text in doc.GetElementsByTagName("test"))
                {
                    test_box.Items.Insert(0, text.InnerText);
                }

                foreach (XmlElement text in doc.GetElementsByTagName("release"))
                {
                    release_box.Items.Insert(0, text.InnerText);
                }
            }
            catch (Exception)
            {
                // file does not exist but no problem it will be created when the app gets closed
            }
        }
            
    }
}
