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
            this.label3 = new System.Windows.Forms.Label();
            this.deleteBorrowedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowDashboardLabel
            // 
            this.borrowDashboardLabel.AutoSize = true;
            this.borrowDashboardLabel.BackColor = System.Drawing.Color.Lime;
            this.borrowDashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDashboardLabel.Location = new System.Drawing.Point(251, 59);
            this.borrowDashboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowDashboardLabel.Name = "borrowDashboardLabel";
            this.borrowDashboardLabel.Size = new System.Drawing.Size(542, 39);
            this.borrowDashboardLabel.TabIndex = 0;
            this.borrowDashboardLabel.Text = "Borrow Reserve and Return Books";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(383, 129);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(124, 29);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(1217, 100);
            this.bookNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(140, 29);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Name";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.BackColor = System.Drawing.Color.Gold;
            this.borrowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLabel.ForeColor = System.Drawing.Color.Coral;
            this.borrowDateLabel.Location = new System.Drawing.Point(15, 343);
            this.borrowDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(180, 36);
            this.borrowDateLabel.TabIndex = 3;
            this.borrowDateLabel.Text = "Borrow Date";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.BackColor = System.Drawing.Color.Coral;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.returnLabel.Location = new System.Drawing.Point(16, 416);
            this.returnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(174, 36);
            this.returnLabel.TabIndex = 4;
            this.returnLabel.Text = "Return Date";
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reserveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.ForeColor = System.Drawing.Color.Yellow;
            this.reserveLabel.Location = new System.Drawing.Point(17, 519);
            this.reserveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reserveLabel.Name = "reserveLabel";
            this.reserveLabel.Size = new System.Drawing.Size(194, 36);
            this.reserveLabel.TabIndex = 5;
            this.reserveLabel.Text = "Reserve Date";
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.borrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.ForeColor = System.Drawing.Color.Green;
            this.borrowButton.Location = new System.Drawing.Point(660, 331);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(4);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(344, 54);
            this.borrowButton.TabIndex = 8;
            this.borrowButton.Text = "BORROW THE BOOK TODAY";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Enabled = false;
            this.borrowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateTimePicker.Location = new System.Drawing.Point(223, 342);
            this.borrowDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(332, 36);
            this.borrowDateTimePicker.TabIndex = 9;
            // 
            // reserveDateTimePicker
            // 
            this.reserveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveDateTimePicker.Location = new System.Drawing.Point(258, 519);
            this.reserveDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.reserveDateTimePicker.Name = "reserveDateTimePicker";
            this.reserveDateTimePicker.Size = new System.Drawing.Size(334, 36);
            this.reserveDateTimePicker.TabIndex = 10;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateTimePicker.Location = new System.Drawing.Point(221, 418);
            this.returnDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(334, 36);
            this.returnDateTimePicker.TabIndex = 11;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Green;
            this.reserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.reserveButton.Location = new System.Drawing.Point(660, 519);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(4);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(344, 56);
            this.reserveButton.TabIndex = 12;
            this.reserveButton.Text = "SELECT A DATE TO RESERVE THE BOOK";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(1051, 615);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(184, 108);
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
            this.exitButton.Location = new System.Drawing.Point(1285, 615);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 108);
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
            this.usersButton.Location = new System.Drawing.Point(91, 162);
            this.usersButton.Margin = new System.Windows.Forms.Padding(4);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(201, 138);
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
            this.booksButton.Location = new System.Drawing.Point(828, 162);
            this.booksButton.Margin = new System.Windows.Forms.Padding(4);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(244, 91);
            this.booksButton.TabIndex = 18;
            this.booksButton.Text = "Click here to Display all Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1031, 343);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(635, 262);
            this.dataGridView3.TabIndex = 25;
            // 
            // userComboBox
            // 
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(333, 162);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(237, 37);
            this.userComboBox.TabIndex = 26;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // isbnComboBox
            // 
            this.isbnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnComboBox.FormattingEnabled = true;
            this.isbnComboBox.ItemHeight = 29;
            this.isbnComboBox.Location = new System.Drawing.Point(1149, 260);
            this.isbnComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.isbnComboBox.Name = "isbnComboBox";
            this.isbnComboBox.Size = new System.Drawing.Size(297, 37);
            this.isbnComboBox.TabIndex = 27;
            this.isbnComboBox.SelectedIndexChanged += new System.EventHandler(this.isbnComboBox_SelectedIndexChanged);
            // 
            // showBorrowedBooks
            // 
            this.showBorrowedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBorrowedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showBorrowedBooks.Location = new System.Drawing.Point(57, 594);
            this.showBorrowedBooks.Margin = new System.Windows.Forms.Padding(4);
            this.showBorrowedBooks.Name = "showBorrowedBooks";
            this.showBorrowedBooks.Size = new System.Drawing.Size(184, 108);
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
            this.showReservedBooks.Location = new System.Drawing.Point(609, 594);
            this.showReservedBooks.Margin = new System.Windows.Forms.Padding(4);
            this.showReservedBooks.Name = "showReservedBooks";
            this.showReservedBooks.Size = new System.Drawing.Size(184, 108);
            this.showReservedBooks.TabIndex = 29;
            this.showReservedBooks.Text = "Show the books that are Reserved";
            this.showReservedBooks.UseVisualStyleBackColor = false;
            this.showReservedBooks.Click += new System.EventHandler(this.showReservedBooks_Click);
            // 
            // uidComboBox
            // 
            this.uidComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidComboBox.FormattingEnabled = true;
            this.uidComboBox.Location = new System.Drawing.Point(333, 260);
            this.uidComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uidComboBox.Name = "uidComboBox";
            this.uidComboBox.Size = new System.Drawing.Size(237, 37);
            this.uidComboBox.TabIndex = 30;
            // 
            // bookNameComboBox
            // 
            this.bookNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameComboBox.FormattingEnabled = true;
            this.bookNameComboBox.ItemHeight = 29;
            this.bookNameComboBox.Location = new System.Drawing.Point(1149, 145);
            this.bookNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameComboBox.Name = "bookNameComboBox";
            this.bookNameComboBox.Size = new System.Drawing.Size(297, 37);
            this.bookNameComboBox.TabIndex = 31;
            this.bookNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bookNameComboBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1217, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Book ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "UID";
            // 
            // deleteReserveButton
            // 
            this.deleteReserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteReserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReserveButton.ForeColor = System.Drawing.Color.Green;
            this.deleteReserveButton.Location = new System.Drawing.Point(801, 594);
            this.deleteReserveButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteReserveButton.Name = "deleteReserveButton";
            this.deleteReserveButton.Size = new System.Drawing.Size(186, 108);
            this.deleteReserveButton.TabIndex = 34;
            this.deleteReserveButton.Text = "Delete Reserved Book";
            this.deleteReserveButton.UseVisualStyleBackColor = false;
            this.deleteReserveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(607, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "SELECT A DATE TO RETURN THE BOOK";
            // 
            // deleteBorrowedButton
            // 
            this.deleteBorrowedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBorrowedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBorrowedButton.ForeColor = System.Drawing.Color.Green;
            this.deleteBorrowedButton.Location = new System.Drawing.Point(270, 594);
            this.deleteBorrowedButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBorrowedButton.Name = "deleteBorrowedButton";
            this.deleteBorrowedButton.Size = new System.Drawing.Size(198, 108);
            this.deleteBorrowedButton.TabIndex = 36;
            this.deleteBorrowedButton.Text = "Delete Borrowed Book";
            this.deleteBorrowedButton.UseVisualStyleBackColor = false;
            this.deleteBorrowedButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormBorrowReserveReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 736);
            this.Controls.Add(this.deleteBorrowedButton);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteBorrowedButton;
    }
}