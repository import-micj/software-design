namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            listBoxBooks = new ListBox();
            label3 = new Label();
            btnShowBooks = new Button();
            label4 = new Label();
            txtBookID = new TextBox();
            label5 = new Label();
            btnUpdateBook = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(94, 42);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(128, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(94, 71);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(128, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(120, 129);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Book Title";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(579, 33);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(209, 94);
            listBoxBooks.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 15);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "List of Books";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(624, 133);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(118, 23);
            btnShowBooks.TabIndex = 7;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(117, 19);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Add Book";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(94, 100);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(128, 23);
            txtBookID.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 103);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Book ID";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(120, 158);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 11;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
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
            Text = "gg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private ListBox listBoxBooks;
        private Label label3;
        private Button btnShowBooks;
        private Label label4;
        private TextBox txtBookID;
        private Label label5;
        private Button btnUpdateBook;
    }
}
