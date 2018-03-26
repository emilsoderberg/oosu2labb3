namespace Lab3WinForm
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.AbilitiesList = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.AddJobBtn = new System.Windows.Forms.Button();
            this.JobList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 279);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heroes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add hero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Hero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(391, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 129);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete Hero";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AbilitiesList
            // 
            this.AbilitiesList.LabelWrap = false;
            this.AbilitiesList.Location = new System.Drawing.Point(718, 29);
            this.AbilitiesList.Name = "AbilitiesList";
            this.AbilitiesList.Size = new System.Drawing.Size(284, 104);
            this.AbilitiesList.TabIndex = 13;
            this.AbilitiesList.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Abilites:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.Location = new System.Drawing.Point(651, 152);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(61, 25);
            this.JobLabel.TabIndex = 16;
            this.JobLabel.Text = "Jobs:";
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.Location = new System.Drawing.Point(472, 348);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.Size = new System.Drawing.Size(148, 37);
            this.AddJobBtn.TabIndex = 17;
            this.AddJobBtn.Text = "Add Job";
            this.AddJobBtn.UseVisualStyleBackColor = true;
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click);
            // 
            // JobList
            // 
            this.JobList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobList.FormattingEnabled = true;
            this.JobList.ItemHeight = 25;
            this.JobList.Location = new System.Drawing.Point(718, 156);
            this.JobList.Name = "JobList";
            this.JobList.Size = new System.Drawing.Size(215, 129);
            this.JobList.TabIndex = 19;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1019, 415);
            this.Controls.Add(this.JobList);
            this.Controls.Add(this.AddJobBtn);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AbilitiesList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView AbilitiesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Button AddJobBtn;
        private System.Windows.Forms.ListBox JobList;
    }
}

