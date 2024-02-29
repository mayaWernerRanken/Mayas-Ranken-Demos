namespace MoviesDemo
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
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            lblResult = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMovieName = new TextBox();
            txtMovieYear = new TextBox();
            txtMovieDescription = new TextBox();
            btnAdd = new Button();
            lblAddResult = new Label();
            grpUpdate = new GroupBox();
            lblUpdateResult = new Label();
            btnUpdate = new Button();
            label5 = new Label();
            txtUpdateDescription = new TextBox();
            label6 = new Label();
            txtUpdateYear = new TextBox();
            label7 = new Label();
            txtUpdateName = new TextBox();
            grpUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(668, 9);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 76);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 39);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 1;
            label1.Text = "Search for a movie by title:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(522, 37);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 23);
            txtSearch.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(343, 87);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(476, 108);
            lblResult.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Movie Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 64);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Movie Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 86);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 6;
            label4.Text = "Movie Description:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(143, 37);
            txtMovieName.Margin = new Padding(3, 2, 3, 2);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(185, 23);
            txtMovieName.TabIndex = 7;
            // 
            // txtMovieYear
            // 
            txtMovieYear.Location = new Point(143, 62);
            txtMovieYear.Margin = new Padding(3, 2, 3, 2);
            txtMovieYear.Name = "txtMovieYear";
            txtMovieYear.Size = new Size(185, 23);
            txtMovieYear.TabIndex = 8;
            // 
            // txtMovieDescription
            // 
            txtMovieDescription.BackColor = Color.White;
            txtMovieDescription.Location = new Point(143, 86);
            txtMovieDescription.Margin = new Padding(3, 2, 3, 2);
            txtMovieDescription.Multiline = true;
            txtMovieDescription.Name = "txtMovieDescription";
            txtMovieDescription.Size = new Size(185, 110);
            txtMovieDescription.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 110);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 85);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAddResult
            // 
            lblAddResult.AutoSize = true;
            lblAddResult.Location = new Point(143, 197);
            lblAddResult.Name = "lblAddResult";
            lblAddResult.Size = new Size(0, 15);
            lblAddResult.TabIndex = 11;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(lblUpdateResult);
            grpUpdate.Controls.Add(btnUpdate);
            grpUpdate.Controls.Add(label5);
            grpUpdate.Controls.Add(txtUpdateDescription);
            grpUpdate.Controls.Add(label6);
            grpUpdate.Controls.Add(txtUpdateYear);
            grpUpdate.Controls.Add(label7);
            grpUpdate.Controls.Add(txtUpdateName);
            grpUpdate.Location = new Point(343, 197);
            grpUpdate.Margin = new Padding(3, 2, 3, 2);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Padding = new Padding(3, 2, 3, 2);
            grpUpdate.Size = new Size(476, 218);
            grpUpdate.TabIndex = 12;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Update Movie:";
            grpUpdate.Visible = false;
            // 
            // lblUpdateResult
            // 
            lblUpdateResult.AutoSize = true;
            lblUpdateResult.Location = new Point(26, 174);
            lblUpdateResult.Name = "lblUpdateResult";
            lblUpdateResult.Size = new Size(0, 15);
            lblUpdateResult.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(26, 123);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 28);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 81);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 15;
            label5.Text = "Movie Description:";
            // 
            // txtUpdateDescription
            // 
            txtUpdateDescription.BackColor = Color.White;
            txtUpdateDescription.Location = new Point(178, 79);
            txtUpdateDescription.Margin = new Padding(3, 2, 3, 2);
            txtUpdateDescription.Multiline = true;
            txtUpdateDescription.Name = "txtUpdateDescription";
            txtUpdateDescription.Size = new Size(273, 110);
            txtUpdateDescription.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 58);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 14;
            label6.Text = "Movie Year:";
            // 
            // txtUpdateYear
            // 
            txtUpdateYear.Location = new Point(178, 54);
            txtUpdateYear.Margin = new Padding(3, 2, 3, 2);
            txtUpdateYear.Name = "txtUpdateYear";
            txtUpdateYear.Size = new Size(273, 23);
            txtUpdateYear.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 32);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 13;
            label7.Text = "Movie Name:";
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(178, 29);
            txtUpdateName.Margin = new Padding(3, 2, 3, 2);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(273, 23);
            txtUpdateName.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(830, 424);
            Controls.Add(grpUpdate);
            Controls.Add(lblAddResult);
            Controls.Add(btnAdd);
            Controls.Add(txtMovieDescription);
            Controls.Add(txtMovieYear);
            Controls.Add(txtMovieName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private TextBox txtSearch;
        private Label lblResult;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMovieName;
        private TextBox txtMovieYear;
        private TextBox txtMovieDescription;
        private Button btnAdd;
        private Label lblAddResult;
        private GroupBox grpUpdate;
        private Label label5;
        private TextBox txtUpdateDescription;
        private Label label6;
        private TextBox txtUpdateYear;
        private Label label7;
        private TextBox txtUpdateName;
        private Button btnUpdate;
        private Label lblUpdateResult;
    }
}