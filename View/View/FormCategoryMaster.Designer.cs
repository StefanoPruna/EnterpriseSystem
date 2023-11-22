namespace View
{
    partial class FormCategoryMaster
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
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cidTextBox = new System.Windows.Forms.TextBox();
            this.cidLabel = new System.Windows.Forms.Label();
            this.showCategorybutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goBackButton = new System.Windows.Forms.Button();
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.updateNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(47, 68);
            this.categoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(240, 13);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Category Name to be Updated, Added or Deleted";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(300, 61);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.categoryNameTextBox.TabIndex = 1;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(204, 392);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 54);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update Category";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(315, 390);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 56);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Add New Category";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(414, 390);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 56);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete a Category";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cidTextBox
            // 
            this.cidTextBox.Location = new System.Drawing.Point(300, 29);
            this.cidTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.Size = new System.Drawing.Size(74, 20);
            this.cidTextBox.TabIndex = 6;
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.Location = new System.Drawing.Point(11, 32);
            this.cidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(285, 13);
            this.cidLabel.TabIndex = 5;
            this.cidLabel.Text = "Insert the CID for the Name to be changed or to be deleted";
            // 
            // showCategorybutton
            // 
            this.showCategorybutton.Location = new System.Drawing.Point(41, 390);
            this.showCategorybutton.Name = "showCategorybutton";
            this.showCategorybutton.Size = new System.Drawing.Size(131, 58);
            this.showCategorybutton.TabIndex = 7;
            this.showCategorybutton.Text = "Show the Categories";
            this.showCategorybutton.UseVisualStyleBackColor = true;
            this.showCategorybutton.Click += new System.EventHandler(this.showCategorybutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(589, 264);
            this.dataGridView1.TabIndex = 8;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(513, 392);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 54);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Go Back to Admin";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(670, 26);
            this.updateNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.updateNameTextBox.TabIndex = 11;
            // 
            // updateNameLabel
            // 
            this.updateNameLabel.AutoSize = true;
            this.updateNameLabel.Location = new System.Drawing.Point(398, 29);
            this.updateNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateNameLabel.Name = "updateNameLabel";
            this.updateNameLabel.Size = new System.Drawing.Size(255, 13);
            this.updateNameLabel.TabIndex = 10;
            this.updateNameLabel.Text = "Insert the Category Name from the list to be changed";
            // 
            // FormCategoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 486);
            this.Controls.Add(this.updateNameTextBox);
            this.Controls.Add(this.updateNameLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showCategorybutton);
            this.Controls.Add(this.cidTextBox);
            this.Controls.Add(this.cidLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategoryMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoryMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox cidTextBox;
        private System.Windows.Forms.Label cidLabel;
        private System.Windows.Forms.Button showCategorybutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.Label updateNameLabel;
    }
}