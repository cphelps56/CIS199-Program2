namespace Program_2
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.gradeGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioBtn = new System.Windows.Forms.RadioButton();
            this.juniorRadioBtn = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioBtn = new System.Windows.Forms.RadioButton();
            this.freshmanRadioBtn = new System.Windows.Forms.RadioButton();
            this.registrationTimeBtn = new System.Windows.Forms.Button();
            this.regTimeLabel = new System.Windows.Forms.Label();
            this.gradeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(197, 188);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(79, 192);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(111, 17);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Enter last name:";
            // 
            // gradeGroupBox
            // 
            this.gradeGroupBox.Controls.Add(this.seniorRadioBtn);
            this.gradeGroupBox.Controls.Add(this.juniorRadioBtn);
            this.gradeGroupBox.Controls.Add(this.sophomoreRadioBtn);
            this.gradeGroupBox.Controls.Add(this.freshmanRadioBtn);
            this.gradeGroupBox.Location = new System.Drawing.Point(83, 15);
            this.gradeGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeGroupBox.Name = "gradeGroupBox";
            this.gradeGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeGroupBox.Size = new System.Drawing.Size(224, 155);
            this.gradeGroupBox.TabIndex = 0;
            this.gradeGroupBox.TabStop = false;
            this.gradeGroupBox.Text = "Select a grade level";
            // 
            // seniorRadioBtn
            // 
            this.seniorRadioBtn.AutoSize = true;
            this.seniorRadioBtn.Location = new System.Drawing.Point(15, 114);
            this.seniorRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seniorRadioBtn.Name = "seniorRadioBtn";
            this.seniorRadioBtn.Size = new System.Drawing.Size(70, 21);
            this.seniorRadioBtn.TabIndex = 3;
            this.seniorRadioBtn.TabStop = true;
            this.seniorRadioBtn.Text = "Senior";
            this.seniorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // juniorRadioBtn
            // 
            this.juniorRadioBtn.AutoSize = true;
            this.juniorRadioBtn.Location = new System.Drawing.Point(15, 86);
            this.juniorRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.juniorRadioBtn.Name = "juniorRadioBtn";
            this.juniorRadioBtn.Size = new System.Drawing.Size(68, 21);
            this.juniorRadioBtn.TabIndex = 2;
            this.juniorRadioBtn.TabStop = true;
            this.juniorRadioBtn.Text = "Junior";
            this.juniorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioBtn
            // 
            this.sophomoreRadioBtn.AutoSize = true;
            this.sophomoreRadioBtn.Location = new System.Drawing.Point(15, 58);
            this.sophomoreRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sophomoreRadioBtn.Name = "sophomoreRadioBtn";
            this.sophomoreRadioBtn.Size = new System.Drawing.Size(102, 21);
            this.sophomoreRadioBtn.TabIndex = 1;
            this.sophomoreRadioBtn.TabStop = true;
            this.sophomoreRadioBtn.Text = "Sophomore";
            this.sophomoreRadioBtn.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioBtn
            // 
            this.freshmanRadioBtn.AutoSize = true;
            this.freshmanRadioBtn.Checked = true;
            this.freshmanRadioBtn.Location = new System.Drawing.Point(15, 30);
            this.freshmanRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freshmanRadioBtn.Name = "freshmanRadioBtn";
            this.freshmanRadioBtn.Size = new System.Drawing.Size(92, 21);
            this.freshmanRadioBtn.TabIndex = 0;
            this.freshmanRadioBtn.TabStop = true;
            this.freshmanRadioBtn.Text = "Freshman";
            this.freshmanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // registrationTimeBtn
            // 
            this.registrationTimeBtn.Location = new System.Drawing.Point(109, 321);
            this.registrationTimeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrationTimeBtn.Name = "registrationTimeBtn";
            this.registrationTimeBtn.Size = new System.Drawing.Size(163, 28);
            this.registrationTimeBtn.TabIndex = 2;
            this.registrationTimeBtn.Text = "Find Registration Time";
            this.registrationTimeBtn.UseVisualStyleBackColor = true;
            this.registrationTimeBtn.Click += new System.EventHandler(this.registrationTimeBtn_Click);
            // 
            // regTimeLabel
            // 
            this.regTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regTimeLabel.Location = new System.Drawing.Point(57, 241);
            this.regTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regTimeLabel.Name = "regTimeLabel";
            this.regTimeLabel.Size = new System.Drawing.Size(273, 56);
            this.regTimeLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 364);
            this.Controls.Add(this.regTimeLabel);
            this.Controls.Add(this.registrationTimeBtn);
            this.Controls.Add(this.gradeGroupBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Registration Schedule Application";
            this.gradeGroupBox.ResumeLayout(false);
            this.gradeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.GroupBox gradeGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioBtn;
        private System.Windows.Forms.RadioButton juniorRadioBtn;
        private System.Windows.Forms.RadioButton sophomoreRadioBtn;
        private System.Windows.Forms.RadioButton freshmanRadioBtn;
        private System.Windows.Forms.Button registrationTimeBtn;
        private System.Windows.Forms.Label regTimeLabel;
    }
}

