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
            this.updateCidTextBox = new System.Windows.Forms.TextBox();
            this.updateCidLabel = new System.Windows.Forms.Label();
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.updateNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(12, 83);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(212, 16);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Category Name/Update the Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(247, 77);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.categoryNameTextBox.TabIndex = 1;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(284, 287);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 66);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(432, 284);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 69);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Add Rows";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(564, 284);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 69);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cidTextBox
            // 
            this.cidTextBox.Location = new System.Drawing.Point(162, 35);
            this.cidTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.Size = new System.Drawing.Size(233, 22);
            this.cidTextBox.TabIndex = 6;
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.Location = new System.Drawing.Point(92, 39);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(29, 16);
            this.cidLabel.TabIndex = 5;
            this.cidLabel.Text = "CID";
            // 
            // showCategorybutton
            // 
            this.showCategorybutton.Location = new System.Drawing.Point(67, 284);
            this.showCategorybutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCategorybutton.Name = "showCategorybutton";
            this.showCategorybutton.Size = new System.Drawing.Size(175, 71);
            this.showCategorybutton.TabIndex = 7;
            this.showCategorybutton.Text = "Show the Categories";
            this.showCategorybutton.UseVisualStyleBackColor = true;
            this.showCategorybutton.Click += new System.EventHandler(this.showCategorybutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(737, 135);
            this.dataGridView1.TabIndex = 8;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(696, 287);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 66);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Go Back to Admin";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // updateCidTextBox
            // 
            this.updateCidTextBox.Location = new System.Drawing.Point(598, 35);
            this.updateCidTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateCidTextBox.Name = "updateCidTextBox";
            this.updateCidTextBox.Size = new System.Drawing.Size(233, 22);
            this.updateCidTextBox.TabIndex = 13;
            // 
            // updateCidLabel
            // 
            this.updateCidLabel.AutoSize = true;
            this.updateCidLabel.Location = new System.Drawing.Point(421, 35);
            this.updateCidLabel.Name = "updateCidLabel";
            this.updateCidLabel.Size = new System.Drawing.Size(154, 16);
            this.updateCidLabel.TabIndex = 12;
            this.updateCidLabel.Text = "Insert the CID from the list";
            this.updateCidLabel.Click += new System.EventHandler(this.updateCidLabel_Click);
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(667, 77);
            this.updateNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.updateNameTextBox.TabIndex = 11;
            // 
            // updateNameLabel
            // 
            this.updateNameLabel.AutoSize = true;
            this.updateNameLabel.Location = new System.Drawing.Point(421, 83);
            this.updateNameLabel.Name = "updateNameLabel";
            this.updateNameLabel.Size = new System.Drawing.Size(222, 16);
            this.updateNameLabel.TabIndex = 10;
            this.updateNameLabel.Text = "Insert its Category Name from the list";
            // 
            // FormCategoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 390);
            this.Controls.Add(this.updateCidTextBox);
            this.Controls.Add(this.updateCidLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox updateCidTextBox;
        private System.Windows.Forms.Label updateCidLabel;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.Label updateNameLabel;
    }
}