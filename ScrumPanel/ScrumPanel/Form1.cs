﻿using System;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ScrumPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TodoGroup_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void itemChecked(object sender, ItemCheckEventArgs e)
        {
            if (todo_box.Items[e.Index] != "--- end ---")
            {
                if (in_process_box.Items.Count <= todo_box.Items.Count)
                {
                    if (!in_process_box.Items.Contains(todo_box.Items[e.Index]))
                    {
                        in_process_box.Items.Insert(0, todo_box.Items[e.Index]);
                    }
                }
                else { in_process_box.Items.Insert(0, todo_box.Items[e.Index]); }

                todo_box.Items.Remove(todo_box.Items[e.Index]);
            }
        }

        private void onCheked(object sender, ItemCheckEventArgs e)
        {
            if (in_process_box.Items[e.Index] != "--- end ---")
            {
                if (test_box.Items.Count <= in_process_box.Items.Count)
                {
                    if (!test_box.Items.Contains(in_process_box.Items[e.Index]))
                    {
                        test_box.Items.Insert(0, in_process_box.Items[e.Index]);
                    }
                }
                else { test_box.Items.Insert(0, todo_box.Items[e.Index]); }

                in_process_box.Items.Remove(in_process_box.Items[e.Index]);
            }

        }

        private void onCheck(object sender, ItemCheckEventArgs e)
        {
            if (test_box.Items[e.Index] != "--- end ---")
            {
                if (release_box.Items.Count <= test_box.Items.Count)
                {
                    if (!release_box.Items.Contains(test_box.Items[e.Index]))
                    {
                        release_box.Items.Insert(0, test_box.Items[e.Index]);
                    }
                }
                else { release_box.Items.Insert(0, todo_box.Items[e.Index]); }

                test_box.Items.Remove(test_box.Items[e.Index]);
            }
        }

     

        private void key_down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
