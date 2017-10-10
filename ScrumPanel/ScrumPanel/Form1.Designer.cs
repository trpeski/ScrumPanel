namespace ScrumPanel
{
    partial class Form1
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
            this.todo_text = new System.Windows.Forms.Label();
            this.inprocess_text = new System.Windows.Forms.Label();
            this.test_text = new System.Windows.Forms.Label();
            this.release_text = new System.Windows.Forms.Label();
            this.todo_box = new System.Windows.Forms.CheckedListBox();
            this.in_process_box = new System.Windows.Forms.CheckedListBox();
            this.test_box = new System.Windows.Forms.CheckedListBox();
            this.release_box = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // todo_text
            // 
            this.todo_text.AutoSize = true;
            this.todo_text.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo_text.Location = new System.Drawing.Point(72, 44);
            this.todo_text.Name = "todo_text";
            this.todo_text.Size = new System.Drawing.Size(64, 22);
            this.todo_text.TabIndex = 1;
            this.todo_text.Text = "TO DO";
            // 
            // inprocess_text
            // 
            this.inprocess_text.AutoSize = true;
            this.inprocess_text.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inprocess_text.Location = new System.Drawing.Point(297, 44);
            this.inprocess_text.Name = "inprocess_text";
            this.inprocess_text.Size = new System.Drawing.Size(85, 22);
            this.inprocess_text.TabIndex = 2;
            this.inprocess_text.Text = "In Process";
            // 
            // test_text
            // 
            this.test_text.AutoSize = true;
            this.test_text.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_text.Location = new System.Drawing.Point(530, 44);
            this.test_text.Name = "test_text";
            this.test_text.Size = new System.Drawing.Size(41, 22);
            this.test_text.TabIndex = 3;
            this.test_text.Text = "Test";
            this.test_text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // release_text
            // 
            this.release_text.AutoSize = true;
            this.release_text.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.release_text.Location = new System.Drawing.Point(746, 44);
            this.release_text.Name = "release_text";
            this.release_text.Size = new System.Drawing.Size(65, 22);
            this.release_text.TabIndex = 4;
            this.release_text.Text = "Release";
            // 
            // todo_box
            // 
            this.todo_box.FormattingEnabled = true;
            this.todo_box.HorizontalScrollbar = true;
            this.todo_box.Items.AddRange(new object[] {
            "--- end ---"});
            this.todo_box.Location = new System.Drawing.Point(12, 69);
            this.todo_box.Name = "todo_box";
            this.todo_box.Size = new System.Drawing.Size(206, 454);
            this.todo_box.TabIndex = 5;
            this.todo_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemChecked);
            // 
            // in_process_box
            // 
            this.in_process_box.FormattingEnabled = true;
            this.in_process_box.HorizontalScrollbar = true;
            this.in_process_box.Items.AddRange(new object[] {
            "--- end ---"});
            this.in_process_box.Location = new System.Drawing.Point(224, 69);
            this.in_process_box.Name = "in_process_box";
            this.in_process_box.Size = new System.Drawing.Size(211, 454);
            this.in_process_box.TabIndex = 6;
            this.in_process_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.onCheked);
            // 
            // test_box
            // 
            this.test_box.FormattingEnabled = true;
            this.test_box.HorizontalScrollbar = true;
            this.test_box.Items.AddRange(new object[] {
            "--- end ---"});
            this.test_box.Location = new System.Drawing.Point(441, 69);
            this.test_box.Name = "test_box";
            this.test_box.Size = new System.Drawing.Size(219, 454);
            this.test_box.TabIndex = 7;
            this.test_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.onCheck);
            // 
            // release_box
            // 
            this.release_box.FormattingEnabled = true;
            this.release_box.HorizontalScrollbar = true;
            this.release_box.Items.AddRange(new object[] {
            "--- end ---"});
            this.release_box.Location = new System.Drawing.Point(666, 69);
            this.release_box.Name = "release_box";
            this.release_box.Size = new System.Drawing.Size(220, 454);
            this.release_box.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(611, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Task +";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 523);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.release_box);
            this.Controls.Add(this.test_box);
            this.Controls.Add(this.in_process_box);
            this.Controls.Add(this.todo_box);
            this.Controls.Add(this.release_text);
            this.Controls.Add(this.test_text);
            this.Controls.Add(this.inprocess_text);
            this.Controls.Add(this.todo_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label todo_text;
        private System.Windows.Forms.Label inprocess_text;
        private System.Windows.Forms.Label test_text;
        private System.Windows.Forms.Label release_text;
        private System.Windows.Forms.CheckedListBox todo_box;
        private System.Windows.Forms.CheckedListBox in_process_box;
        private System.Windows.Forms.CheckedListBox test_box;
        private System.Windows.Forms.CheckedListBox release_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

