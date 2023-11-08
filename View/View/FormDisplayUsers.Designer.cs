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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // displayUsersButton
            // 
            this.displayUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUsersButton.Location = new System.Drawing.Point(112, 347);
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
            this.button2.Location = new System.Drawing.Point(340, 347);
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
            this.backButton.Location = new System.Drawing.Point(569, 347);
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
            this.adminLabel.Location = new System.Drawing.Point(441, 43);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(169, 25);
            this.adminLabel.TabIndex = 4;
            this.adminLabel.Text = "Admin Dashboard";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(911, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 117);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(737, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 117);
            this.button1.TabIndex = 6;
            this.button1.Text = "Got to Category Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormDisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 489);
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
    }
}