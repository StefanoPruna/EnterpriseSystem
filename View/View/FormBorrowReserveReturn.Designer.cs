namespace View
{
    partial class FormBorrowReserveReturn
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
            this.borrowDashboardLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.borrowDateLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.reserveLabel = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.borrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reserveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reserveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.isbnComboBox = new System.Windows.Forms.ComboBox();
            this.showBorrowedBooks = new System.Windows.Forms.Button();
            this.showReservedBooks = new System.Windows.Forms.Button();
            this.uidComboBox = new System.Windows.Forms.ComboBox();
            this.bookNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteReserveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowDashboardLabel
            // 
            this.borrowDashboardLabel.AutoSize = true;
            this.borrowDashboardLabel.BackColor = System.Drawing.Color.Lime;
            this.borrowDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDashboardLabel.Location = new System.Drawing.Point(188, 48);
            this.borrowDashboardLabel.Name = "borrowDashboardLabel";
            this.borrowDashboardLabel.Size = new System.Drawing.Size(433, 31);
            this.borrowDashboardLabel.TabIndex = 0;
            this.borrowDashboardLabel.Text = "Borrow Reserve and Return Books";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(287, 105);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(97, 24);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(913, 81);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(109, 24);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Name";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLabel.Location = new System.Drawing.Point(11, 279);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(113, 24);
            this.borrowDateLabel.TabIndex = 3;
            this.borrowDateLabel.Text = "Borrow Date";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(12, 407);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(109, 24);
            this.returnLabel.TabIndex = 4;
            this.returnLabel.Text = "Return Date";
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.Location = new System.Drawing.Point(11, 342);
            this.reserveLabel.Name = "reserveLabel";
            this.reserveLabel.Size = new System.Drawing.Size(123, 24);
            this.reserveLabel.TabIndex = 5;
            this.reserveLabel.Text = "Reserve Date";
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.borrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.ForeColor = System.Drawing.Color.Green;
            this.borrowButton.Location = new System.Drawing.Point(495, 278);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(258, 35);
            this.borrowButton.TabIndex = 8;
            this.borrowButton.Text = "BORROW THE BOOK TODAY";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Enabled = false;
            this.borrowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateTimePicker.Location = new System.Drawing.Point(142, 278);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(327, 30);
            this.borrowDateTimePicker.TabIndex = 9;
            // 
            // reserveDateTimePicker
            // 
            this.reserveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveDateTimePicker.Location = new System.Drawing.Point(140, 342);
            this.reserveDateTimePicker.Name = "reserveDateTimePicker";
            this.reserveDateTimePicker.Size = new System.Drawing.Size(329, 30);
            this.reserveDateTimePicker.TabIndex = 10;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateTimePicker.Location = new System.Drawing.Point(142, 407);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(329, 30);
            this.returnDateTimePicker.TabIndex = 11;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.Green;
            this.reserveButton.Location = new System.Drawing.Point(495, 342);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(258, 36);
            this.reserveButton.TabIndex = 12;
            this.reserveButton.Text = "SELECT A DATE TO RESERVE THE BOOK";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Green;
            this.returnButton.Location = new System.Drawing.Point(495, 407);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(258, 34);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "SELECT A DATE TO RETURN THE BOOK";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(401, 483);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 88);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Go Back to Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Green;
            this.exitButton.Location = new System.Drawing.Point(577, 483);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 88);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit from the program";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.Yellow;
            this.usersButton.Location = new System.Drawing.Point(68, 132);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(151, 112);
            this.usersButton.TabIndex = 20;
            this.usersButton.Text = "Click here to Display all Users";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.ForeColor = System.Drawing.Color.Yellow;
            this.booksButton.Location = new System.Drawing.Point(621, 132);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(183, 74);
            this.booksButton.TabIndex = 18;
            this.booksButton.Text = "Click here to Display all Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(773, 279);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(476, 213);
            this.dataGridView3.TabIndex = 25;
            // 
            // userComboBox
            // 
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(250, 132);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(179, 33);
            this.userComboBox.TabIndex = 26;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // isbnComboBox
            // 
            this.isbnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnComboBox.FormattingEnabled = true;
            this.isbnComboBox.ItemHeight = 25;
            this.isbnComboBox.Location = new System.Drawing.Point(862, 211);
            this.isbnComboBox.Name = "isbnComboBox";
            this.isbnComboBox.Size = new System.Drawing.Size(224, 33);
            this.isbnComboBox.TabIndex = 27;
            // 
            // showBorrowedBooks
            // 
            this.showBorrowedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBorrowedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showBorrowedBooks.Location = new System.Drawing.Point(43, 483);
            this.showBorrowedBooks.Name = "showBorrowedBooks";
            this.showBorrowedBooks.Size = new System.Drawing.Size(138, 88);
            this.showBorrowedBooks.TabIndex = 28;
            this.showBorrowedBooks.Text = "Show the books that are Borrowed";
            this.showBorrowedBooks.UseVisualStyleBackColor = false;
            this.showBorrowedBooks.Click += new System.EventHandler(this.showBorrowedBooks_Click);
            // 
            // showReservedBooks
            // 
            this.showReservedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showReservedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showReservedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showReservedBooks.Location = new System.Drawing.Point(225, 483);
            this.showReservedBooks.Name = "showReservedBooks";
            this.showReservedBooks.Size = new System.Drawing.Size(138, 88);
            this.showReservedBooks.TabIndex = 29;
            this.showReservedBooks.Text = "Show the books that are Reserved";
            this.showReservedBooks.UseVisualStyleBackColor = false;
            this.showReservedBooks.Click += new System.EventHandler(this.showReservedBooks_Click);
            // 
            // uidComboBox
            // 
            this.uidComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidComboBox.FormattingEnabled = true;
            this.uidComboBox.Location = new System.Drawing.Point(250, 211);
            this.uidComboBox.Name = "uidComboBox";
            this.uidComboBox.Size = new System.Drawing.Size(179, 33);
            this.uidComboBox.TabIndex = 30;
            // 
            // bookNameComboBox
            // 
            this.bookNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameComboBox.FormattingEnabled = true;
            this.bookNameComboBox.ItemHeight = 25;
            this.bookNameComboBox.Location = new System.Drawing.Point(862, 118);
            this.bookNameComboBox.Name = "bookNameComboBox";
            this.bookNameComboBox.Size = new System.Drawing.Size(224, 33);
            this.bookNameComboBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Book ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "UID";
            // 
            // deleteReserveButton
            // 
            this.deleteReserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteReserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReserveButton.ForeColor = System.Drawing.Color.Green;
            this.deleteReserveButton.Location = new System.Drawing.Point(773, 498);
            this.deleteReserveButton.Name = "deleteReserveButton";
            this.deleteReserveButton.Size = new System.Drawing.Size(164, 73);
            this.deleteReserveButton.TabIndex = 34;
            this.deleteReserveButton.Text = "Delete Reserved Book";
            this.deleteReserveButton.UseVisualStyleBackColor = false;
            this.deleteReserveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBorrowReserveReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 598);
            this.Controls.Add(this.deleteReserveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookNameComboBox);
            this.Controls.Add(this.uidComboBox);
            this.Controls.Add(this.showReservedBooks);
            this.Controls.Add(this.showBorrowedBooks);
            this.Controls.Add(this.isbnComboBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.reserveDateTimePicker);
            this.Controls.Add(this.borrowDateTimePicker);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.reserveLabel);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.borrowDateLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.borrowDashboardLabel);
            this.Name = "FormBorrowReserveReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBorrowReserveReturn";
            this.Load += new System.EventHandler(this.FormBorrowReserveReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borrowDashboardLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label borrowDateLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label reserveLabel;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.DateTimePicker borrowDateTimePicker;
        private System.Windows.Forms.DateTimePicker reserveDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox isbnComboBox;
        private System.Windows.Forms.Button showBorrowedBooks;
        private System.Windows.Forms.Button showReservedBooks;
        private System.Windows.Forms.ComboBox uidComboBox;
        private System.Windows.Forms.ComboBox bookNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteReserveButton;
    }
}