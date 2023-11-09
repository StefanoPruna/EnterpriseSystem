namespace View
{
    partial class FormDisplayUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayUsersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newLevelLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.originalLabel = new System.Windows.Forms.Label();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // displayUsersButton
            // 
            this.displayUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUsersButton.Location = new System.Drawing.Point(25, 425);
            this.displayUsersButton.Name = "displayUsersButton";
            this.displayUsersButton.Size = new System.Drawing.Size(175, 130);
            this.displayUsersButton.TabIndex = 1;
            this.displayUsersButton.Text = "Display All Users";
            this.displayUsersButton.UseVisualStyleBackColor = true;
            this.displayUsersButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(129, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 117);
            this.button2.TabIndex = 2;
            this.button2.Text = "Go to Books Table";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Info;
            this.backButton.Location = new System.Drawing.Point(468, 592);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 117);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Go Back to Login";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.adminLabel.Location = new System.Drawing.Point(438, 9);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(169, 25);
            this.adminLabel.TabIndex = 4;
            this.adminLabel.Text = "Admin Dashboard";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(938, 122);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 192);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(775, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 117);
            this.button1.TabIndex = 6;
            this.button1.Text = "Got to Category Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(296, 436);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(168, 109);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update User";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(557, 436);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(189, 109);
            this.addNewButton.TabIndex = 8;
            this.addNewButton.Text = "Add a New User";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(838, 436);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 109);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete User";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLabel.Location = new System.Drawing.Point(92, 74);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(146, 25);
            this.newUserLabel.TabIndex = 10;
            this.newUserLabel.Text = "New Username";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(92, 122);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(235, 25);
            this.newPasswordLabel.TabIndex = 11;
            this.newPasswordLabel.Text = "Create the new Password";
            // 
            // newLevelLabel
            // 
            this.newLevelLabel.AutoSize = true;
            this.newLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLevelLabel.Location = new System.Drawing.Point(92, 174);
            this.newLevelLabel.Name = "newLevelLabel";
            this.newLevelLabel.Size = new System.Drawing.Size(243, 25);
            this.newLevelLabel.TabIndex = 12;
            this.newLevelLabel.Text = "Insert the Level of the User";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(383, 79);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(176, 20);
            this.usernameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(383, 122);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(176, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(383, 174);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 20);
            this.levelTextBox.TabIndex = 15;
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(600, 79);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(370, 25);
            this.originalLabel.TabIndex = 16;
            this.originalLabel.Text = "Insert the User from the list to be changed";
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(676, 122);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(176, 20);
            this.originalTextBox.TabIndex = 17;
            // 
            // FormDisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 758);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.newLevelLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newUserLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.displayUsersButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDisplayUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisplayUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayUsersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label newLevelLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.TextBox originalTextBox;
    }
}