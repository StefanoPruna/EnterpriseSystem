namespace View
{
    partial class FormDisplayBooks
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
            this.displayBooksButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.booksDashboard = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // displayBooksButton
            // 
            this.displayBooksButton.Location = new System.Drawing.Point(104, 391);
            this.displayBooksButton.Name = "displayBooksButton";
            this.displayBooksButton.Size = new System.Drawing.Size(138, 39);
            this.displayBooksButton.TabIndex = 1;
            this.displayBooksButton.Text = "Display All Books";
            this.displayBooksButton.UseVisualStyleBackColor = true;
            this.displayBooksButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(576, 77);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(212, 68);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search Book by Name or Publish Year";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(350, 391);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(128, 39);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go Back to Login";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(17, 82);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(164, 25);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search by Name:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(187, 77);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(382, 30);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(575, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // booksDashboard
            // 
            this.booksDashboard.AutoSize = true;
            this.booksDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksDashboard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.booksDashboard.Location = new System.Drawing.Point(277, 29);
            this.booksDashboard.Name = "booksDashboard";
            this.booksDashboard.Size = new System.Drawing.Size(230, 31);
            this.booksDashboard.TabIndex = 7;
            this.booksDashboard.Text = "Books Dashboard";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(187, 115);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(382, 30);
            this.yearTextBox.TabIndex = 9;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(17, 120);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(153, 25);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Search by Year:";
            // 
            // FormDisplayBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.booksDashboard);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.displayBooksButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDisplayBooks";
            this.Text = "FormDisplayBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayBooksButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label booksDashboard;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
    }
}