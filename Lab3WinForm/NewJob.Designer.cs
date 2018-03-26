namespace Lab3WinForm
{
    partial class NewJob
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
            this.JobLabel = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeroCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddJobBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.StartDateBox = new System.Windows.Forms.TextBox();
            this.EndDateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(350, 9);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(70, 20);
            this.JobLabel.TabIndex = 0;
            this.JobLabel.Text = "New Job";
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(25, 57);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(100, 26);
            this.LocationBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date: (YYYY/MM/DD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date: (YYYY/MM/DD)";
            // 
            // HeroCheckedListBox
            // 
            this.HeroCheckedListBox.FormattingEnabled = true;
            this.HeroCheckedListBox.Location = new System.Drawing.Point(492, 69);
            this.HeroCheckedListBox.Name = "HeroCheckedListBox";
            this.HeroCheckedListBox.Size = new System.Drawing.Size(266, 130);
            this.HeroCheckedListBox.TabIndex = 7;
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.Location = new System.Drawing.Point(25, 272);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.Size = new System.Drawing.Size(138, 45);
            this.AddJobBtn.TabIndex = 8;
            this.AddJobBtn.Text = "Create";
            this.AddJobBtn.UseVisualStyleBackColor = true;
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(169, 272);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(138, 45);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(25, 122);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(100, 26);
            this.StartDateBox.TabIndex = 21;
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(25, 177);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(100, 26);
            this.EndDateBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Heroes:";
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndDateBox);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddJobBtn);
            this.Controls.Add(this.HeroCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.JobLabel);
            this.Name = "NewJob";
            this.Text = "NewJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox HeroCheckedListBox;
        private System.Windows.Forms.Button AddJobBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox StartDateBox;
        private System.Windows.Forms.TextBox EndDateBox;
        private System.Windows.Forms.Label label4;
    }
}