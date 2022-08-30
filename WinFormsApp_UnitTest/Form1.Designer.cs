
namespace WinFormsApp_UnitTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.second_num = new System.Windows.Forms.NumericUpDown();
            this.SecodNumber = new System.Windows.Forms.Label();
            this.first_num = new System.Windows.Forms.NumericUpDown();
            this.FirstNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addperson = new System.Windows.Forms.Button();
            this.Firstname = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.lastameinput = new System.Windows.Forms.TextBox();
            this.firstnameinput = new System.Windows.Forms.TextBox();
            this.Users = new System.Windows.Forms.Label();
            this.usersDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.resultText);
            this.groupBox1.Controls.Add(this.Results);
            this.groupBox1.Controls.Add(this.Divide);
            this.groupBox1.Controls.Add(this.Multiply);
            this.groupBox1.Controls.Add(this.Substract);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.second_num);
            this.groupBox1.Controls.Add(this.SecodNumber);
            this.groupBox1.Controls.Add(this.first_num);
            this.groupBox1.Controls.Add(this.FirstNumber);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(119, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(313, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate  Section";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultText.Location = new System.Drawing.Point(165, 189);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(135, 31);
            this.resultText.TabIndex = 9;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Results.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Results.Location = new System.Drawing.Point(189, 161);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(72, 25);
            this.Results.TabIndex = 8;
            this.Results.Text = "Results";
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Divide.FlatAppearance.BorderSize = 3;
            this.Divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divide.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Divide.Location = new System.Drawing.Point(22, 262);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(120, 38);
            this.Divide.TabIndex = 7;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.Highlight;
            this.Multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Multiply.FlatAppearance.BorderSize = 3;
            this.Multiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiply.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiply.Location = new System.Drawing.Point(22, 218);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(120, 38);
            this.Multiply.TabIndex = 6;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Substract
            // 
            this.Substract.BackColor = System.Drawing.SystemColors.GrayText;
            this.Substract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Substract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Substract.FlatAppearance.BorderSize = 3;
            this.Substract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Substract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Substract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Substract.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Substract.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Substract.Location = new System.Drawing.Point(22, 174);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(120, 38);
            this.Substract.TabIndex = 5;
            this.Substract.Text = "Substract";
            this.Substract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Substract.UseVisualStyleBackColor = false;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ControlText;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add.FlatAppearance.BorderSize = 3;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Add.Location = new System.Drawing.Point(22, 130);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 38);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // second_num
            // 
            this.second_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.second_num.Location = new System.Drawing.Point(189, 83);
            this.second_num.Name = "second_num";
            this.second_num.Size = new System.Drawing.Size(111, 27);
            this.second_num.TabIndex = 3;
            // 
            // SecodNumber
            // 
            this.SecodNumber.AutoSize = true;
            this.SecodNumber.BackColor = System.Drawing.SystemColors.Control;
            this.SecodNumber.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SecodNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SecodNumber.Location = new System.Drawing.Point(3, 76);
            this.SecodNumber.Name = "SecodNumber";
            this.SecodNumber.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SecodNumber.Size = new System.Drawing.Size(174, 34);
            this.SecodNumber.TabIndex = 2;
            this.SecodNumber.Text = "Second Number";
            this.SecodNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_num
            // 
            this.first_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first_num.Location = new System.Drawing.Point(189, 40);
            this.first_num.Name = "first_num";
            this.first_num.Size = new System.Drawing.Size(111, 27);
            this.first_num.TabIndex = 1;
            // 
            // FirstNumber
            // 
            this.FirstNumber.AutoSize = true;
            this.FirstNumber.BackColor = System.Drawing.SystemColors.Control;
            this.FirstNumber.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FirstNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FirstNumber.Location = new System.Drawing.Point(3, 33);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FirstNumber.Size = new System.Drawing.Size(150, 34);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "First Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addperson);
            this.groupBox2.Controls.Add(this.Firstname);
            this.groupBox2.Controls.Add(this.Lastname);
            this.groupBox2.Controls.Add(this.lastameinput);
            this.groupBox2.Controls.Add(this.firstnameinput);
            this.groupBox2.Controls.Add(this.Users);
            this.groupBox2.Controls.Add(this.usersDropdown);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(624, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(363, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // addperson
            // 
            this.addperson.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addperson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addperson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addperson.FlatAppearance.BorderSize = 0;
            this.addperson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addperson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.addperson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addperson.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addperson.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addperson.Location = new System.Drawing.Point(128, 238);
            this.addperson.Name = "addperson";
            this.addperson.Size = new System.Drawing.Size(142, 48);
            this.addperson.TabIndex = 7;
            this.addperson.Text = "Add Person";
            this.addperson.UseVisualStyleBackColor = false;
            this.addperson.Click += new System.EventHandler(this.addperson_Click);
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Firstname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Firstname.Location = new System.Drawing.Point(31, 113);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(96, 29);
            this.Firstname.TabIndex = 6;
            this.Firstname.Text = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lastname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Lastname.Location = new System.Drawing.Point(31, 164);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(92, 29);
            this.Lastname.TabIndex = 5;
            this.Lastname.Text = "Lastname";
            // 
            // lastameinput
            // 
            this.lastameinput.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastameinput.Location = new System.Drawing.Point(139, 161);
            this.lastameinput.Name = "lastameinput";
            this.lastameinput.Size = new System.Drawing.Size(206, 34);
            this.lastameinput.TabIndex = 3;
            // 
            // firstnameinput
            // 
            this.firstnameinput.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameinput.Location = new System.Drawing.Point(139, 115);
            this.firstnameinput.Name = "firstnameinput";
            this.firstnameinput.Size = new System.Drawing.Size(206, 34);
            this.firstnameinput.TabIndex = 2;
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Users.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Users.Location = new System.Drawing.Point(31, 43);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(69, 29);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            // 
            // usersDropdown
            // 
            this.usersDropdown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usersDropdown.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersDropdown.FormattingEnabled = true;
            this.usersDropdown.Location = new System.Drawing.Point(139, 40);
            this.usersDropdown.Name = "usersDropdown";
            this.usersDropdown.Size = new System.Drawing.Size(206, 33);
            this.usersDropdown.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SecodNumber;
        private System.Windows.Forms.NumericUpDown first_num;
        private System.Windows.Forms.Label FirstNumber;
        private System.Windows.Forms.NumericUpDown second_num;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Button addperson;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.TextBox lastameinput;
        private System.Windows.Forms.TextBox firstnameinput;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.ComboBox usersDropdown;
        private System.Windows.Forms.TextBox resultText;
    }
}
