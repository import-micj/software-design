namespace lab6
{
	partial class Form1
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
            btnUpdateBook = new Button();
            label5 = new Label();
            txtBookID = new TextBox();
            label4 = new Label();
            btnShowBooks = new Button();
            label3 = new Label();
            listBoxBooks = new ListBox();
            label2 = new Label();
            label1 = new Label();
            btnAddBook = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            SuspendLayout();
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(112, 285);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 23;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 230);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 22;
            label5.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(86, 227);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(128, 23);
            txtBookID.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(109, 146);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 20;
            label4.Text = "Add Book";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(616, 260);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(118, 23);
            btnShowBooks.TabIndex = 19;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 142);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 18;
            label3.Text = "List of Books";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(571, 160);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(209, 94);
            listBoxBooks.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 201);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Book Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 177);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 15;
            label1.Text = "Author";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(112, 256);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 14;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(86, 198);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(128, 23);
            txtBookTitle.TabIndex = 13;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(86, 169);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(128, 23);
            txtAuthorName.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateBook);
            Controls.Add(label5);
            Controls.Add(txtBookID);
            Controls.Add(label4);
            Controls.Add(btnShowBooks);
            Controls.Add(label3);
            Controls.Add(listBoxBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateBook;
        private Label label5;
        private TextBox txtBookID;
        private Label label4;
        private Button btnShowBooks;
        private Label label3;
        private ListBox listBoxBooks;
        private Label label2;
        private Label label1;
        private Button btnAddBook;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
    }
}
