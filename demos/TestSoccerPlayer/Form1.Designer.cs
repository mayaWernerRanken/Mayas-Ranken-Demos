namespace TestSoccerPlayer
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
            btnCreatePlayer = new Button();
            lblResult = new Label();
            lblResult2 = new Label();
            SuspendLayout();
            // 
            // btnCreatePlayer
            // 
            btnCreatePlayer.Location = new Point(289, 117);
            btnCreatePlayer.Margin = new Padding(3, 2, 3, 2);
            btnCreatePlayer.Name = "btnCreatePlayer";
            btnCreatePlayer.Size = new Size(82, 22);
            btnCreatePlayer.TabIndex = 0;
            btnCreatePlayer.Text = "create player";
            btnCreatePlayer.UseVisualStyleBackColor = true;
            btnCreatePlayer.Click += btnCreatePlayer_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(164, 221);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(411, 221);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(38, 15);
            lblResult2.TabIndex = 2;
            lblResult2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblResult2);
            Controls.Add(lblResult);
            Controls.Add(btnCreatePlayer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreatePlayer;
        private Label lblResult;
        private Label lblResult2;
    }
}