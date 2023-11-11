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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.insertUserLabel = new System.Windows.Forms.Label();
            this.insertBookLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.bookNameLabel.Location = new System.Drawing.Point(705, 127);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(109, 24);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book Name";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLabel.Location = new System.Drawing.Point(635, 265);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(113, 24);
            this.borrowDateLabel.TabIndex = 3;
            this.borrowDateLabel.Text = "Borrow Date";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(635, 386);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(109, 24);
            this.returnLabel.TabIndex = 4;
            this.returnLabel.Text = "Return Date";
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.Location = new System.Drawing.Point(634, 328);
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
            this.borrowButton.Location = new System.Drawing.Point(1043, 261);
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
            this.borrowDateTimePicker.Location = new System.Drawing.Point(783, 264);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.borrowDateTimePicker.TabIndex = 9;
            // 
            // reserveDateTimePicker
            // 
            this.reserveDateTimePicker.Location = new System.Drawing.Point(783, 326);
            this.reserveDateTimePicker.Name = "reserveDateTimePicker";
            this.reserveDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reserveDateTimePicker.TabIndex = 10;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(783, 380);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDateTimePicker.TabIndex = 11;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.Green;
            this.reserveButton.Location = new System.Drawing.Point(1043, 325);
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
            this.returnButton.Location = new System.Drawing.Point(1043, 380);
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
            this.loginButton.Location = new System.Drawing.Point(91, 453);
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
            this.exitButton.Location = new System.Drawing.Point(322, 453);
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
            this.usersButton.ForeColor = System.Drawing.Color.Yellow;
            this.usersButton.Location = new System.Drawing.Point(79, 170);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(77, 46);
            this.usersButton.TabIndex = 17;
            this.usersButton.Text = "Display all Users";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booksButton.ForeColor = System.Drawing.Color.Yellow;
            this.booksButton.Location = new System.Drawing.Point(709, 170);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(92, 46);
            this.booksButton.TabIndex = 18;
            this.booksButton.Text = "Display all Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 127);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(832, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(476, 127);
            this.dataGridView2.TabIndex = 20;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(322, 277);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(233, 20);
            this.usernameTextBox.TabIndex = 21;
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(322, 343);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(233, 20);
            this.bookTextBox.TabIndex = 22;
            // 
            // insertUserLabel
            // 
            this.insertUserLabel.AutoSize = true;
            this.insertUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertUserLabel.Location = new System.Drawing.Point(87, 272);
            this.insertUserLabel.Name = "insertUserLabel";
            this.insertUserLabel.Size = new System.Drawing.Size(187, 24);
            this.insertUserLabel.TabIndex = 23;
            this.insertUserLabel.Text = "Insert your username";
            // 
            // insertBookLabel
            // 
            this.insertBookLabel.AutoSize = true;
            this.insertBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBookLabel.Location = new System.Drawing.Point(87, 339);
            this.insertBookLabel.Name = "insertBookLabel";
            this.insertBookLabel.Size = new System.Drawing.Size(217, 24);
            this.insertBookLabel.TabIndex = 24;
            this.insertBookLabel.Text = "Insert the book to borrow";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(783, 431);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(476, 127);
            this.dataGridView3.TabIndex = 25;
            // 
            // FormBorrowReserveReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 598);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.insertBookLabel);
            this.Controls.Add(this.insertUserLabel);
            this.Controls.Add(this.bookTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.Label insertUserLabel;
        private System.Windows.Forms.Label insertBookLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}