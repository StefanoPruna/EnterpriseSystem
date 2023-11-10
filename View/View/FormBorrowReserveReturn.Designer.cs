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
            this.usernameComboBox = new System.Windows.Forms.ComboBox();
            this.bookNameComboBox = new System.Windows.Forms.ComboBox();
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
            this.UsernameLabel.Location = new System.Drawing.Point(75, 127);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(97, 24);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(76, 183);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(109, 24);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Name";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLabel.Location = new System.Drawing.Point(77, 250);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(113, 24);
            this.borrowDateLabel.TabIndex = 3;
            this.borrowDateLabel.Text = "Borrow Date";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(77, 371);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(109, 24);
            this.returnLabel.TabIndex = 4;
            this.returnLabel.Text = "Return Date";
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.Location = new System.Drawing.Point(76, 313);
            this.reserveLabel.Name = "reserveLabel";
            this.reserveLabel.Size = new System.Drawing.Size(123, 24);
            this.reserveLabel.TabIndex = 5;
            this.reserveLabel.Text = "Reserve Date";
            // 
            // usernameComboBox
            // 
            this.usernameComboBox.FormattingEnabled = true;
            this.usernameComboBox.Location = new System.Drawing.Point(270, 129);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(121, 21);
            this.usernameComboBox.TabIndex = 6;
            this.usernameComboBox.SelectedIndexChanged += new System.EventHandler(this.usernameComboBox_SelectedIndexChanged);
            // 
            // bookNameComboBox
            // 
            this.bookNameComboBox.FormattingEnabled = true;
            this.bookNameComboBox.Location = new System.Drawing.Point(270, 186);
            this.bookNameComboBox.Name = "bookNameComboBox";
            this.bookNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bookNameComboBox.TabIndex = 7;
            this.bookNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bookNameComboBox_SelectedIndexChanged);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(530, 252);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(258, 23);
            this.borrowButton.TabIndex = 8;
            this.borrowButton.Text = "BORROW THE BOOK TODAY";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Enabled = false;
            this.borrowDateTimePicker.Location = new System.Drawing.Point(270, 255);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.borrowDateTimePicker.TabIndex = 9;
            // 
            // reserveDateTimePicker
            // 
            this.reserveDateTimePicker.Location = new System.Drawing.Point(270, 317);
            this.reserveDateTimePicker.Name = "reserveDateTimePicker";
            this.reserveDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reserveDateTimePicker.TabIndex = 10;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(270, 371);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDateTimePicker.TabIndex = 11;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(530, 316);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(258, 23);
            this.reserveButton.TabIndex = 12;
            this.reserveButton.Text = "SELECT A DATE TO RESERVE THE BOOK";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(530, 371);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(258, 26);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "SELECT A DATE TO RETURN THE BOOK";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(598, 113);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 110);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Go Back to Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 113);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 110);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit from the program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(444, 120);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 37);
            this.usersButton.TabIndex = 17;
            this.usersButton.Text = "Display all Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(444, 186);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(75, 37);
            this.booksButton.TabIndex = 18;
            this.booksButton.Text = "Display all Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // FormBorrowReserveReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 454);
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
            this.Controls.Add(this.bookNameComboBox);
            this.Controls.Add(this.usernameComboBox);
            this.Controls.Add(this.reserveLabel);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.borrowDateLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.borrowDashboardLabel);
            this.Name = "FormBorrowReserveReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBorrowReserveReturn";
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
        private System.Windows.Forms.ComboBox usernameComboBox;
        private System.Windows.Forms.ComboBox bookNameComboBox;
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
    }
}