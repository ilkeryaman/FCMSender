namespace FCMSender
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
            this.label1 = new System.Windows.Forms.Label();
            this.deviceTokenTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.devicetokenRadioBtn = new System.Windows.Forms.RadioButton();
            this.topicRadioBtn = new System.Windows.Forms.RadioButton();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notActionCombobox = new System.Windows.Forms.ComboBox();
            this.routeCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subrouteCombobox = new System.Windows.Forms.ComboBox();
            this.jsonDataTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.showJsonDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Token:";
            // 
            // deviceTokenTextBox
            // 
            this.deviceTokenTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.deviceTokenTextBox.Location = new System.Drawing.Point(118, 78);
            this.deviceTokenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.deviceTokenTextBox.Multiline = true;
            this.deviceTokenTextBox.Name = "deviceTokenTextBox";
            this.deviceTokenTextBox.Size = new System.Drawing.Size(370, 71);
            this.deviceTokenTextBox.TabIndex = 1;
            this.deviceTokenTextBox.Text = "fSKQ0c_ppn0:APA91bEtiRUS9PdSYvZjsf8bv__OdEuqnpxCSQY2w9wy2BGxPkhmMBP41Jb6IKo8bti7m" +
    "UzVsUEbCd2H6WO5LpkXh6_fOcwFoMPFg3ZGd7dul5vt_jY1PkjdQQlrquqCofGE0_MZNZTH";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.messageTextBox.Location = new System.Drawing.Point(118, 193);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(370, 63);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Text = "This is a notification from backend!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(19, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.titleTextBox.Location = new System.Drawing.Point(118, 165);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(370, 21);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.Text = "Hello Guys!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(19, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button1.Location = new System.Drawing.Point(388, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // devicetokenRadioBtn
            // 
            this.devicetokenRadioBtn.AutoSize = true;
            this.devicetokenRadioBtn.Checked = true;
            this.devicetokenRadioBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.devicetokenRadioBtn.Location = new System.Drawing.Point(118, 13);
            this.devicetokenRadioBtn.Name = "devicetokenRadioBtn";
            this.devicetokenRadioBtn.Size = new System.Drawing.Size(95, 17);
            this.devicetokenRadioBtn.TabIndex = 7;
            this.devicetokenRadioBtn.TabStop = true;
            this.devicetokenRadioBtn.Text = "deviceToken";
            this.devicetokenRadioBtn.UseVisualStyleBackColor = true;
            this.devicetokenRadioBtn.CheckedChanged += new System.EventHandler(this.devicetokenRadioBtn_CheckedChanged);
            // 
            // topicRadioBtn
            // 
            this.topicRadioBtn.AutoSize = true;
            this.topicRadioBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.topicRadioBtn.Location = new System.Drawing.Point(228, 13);
            this.topicRadioBtn.Name = "topicRadioBtn";
            this.topicRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.topicRadioBtn.TabIndex = 8;
            this.topicRadioBtn.Text = "topic";
            this.topicRadioBtn.UseVisualStyleBackColor = true;
            this.topicRadioBtn.CheckedChanged += new System.EventHandler(this.topicRadioBtn_CheckedChanged);
            // 
            // topicTextBox
            // 
            this.topicTextBox.Enabled = false;
            this.topicTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.topicTextBox.Location = new System.Drawing.Point(118, 42);
            this.topicTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(370, 21);
            this.topicTextBox.TabIndex = 10;
            this.topicTextBox.Text = "all";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Topic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.Location = new System.Drawing.Point(19, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ntf. Action:";
            // 
            // notActionCombobox
            // 
            this.notActionCombobox.DisplayMember = "None";
            this.notActionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notActionCombobox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notActionCombobox.FormattingEnabled = true;
            this.notActionCombobox.Items.AddRange(new object[] {
            "None",
            "Redirect"});
            this.notActionCombobox.Location = new System.Drawing.Point(118, 275);
            this.notActionCombobox.Name = "notActionCombobox";
            this.notActionCombobox.Size = new System.Drawing.Size(370, 21);
            this.notActionCombobox.TabIndex = 13;
            // 
            // routeCombobox
            // 
            this.routeCombobox.DisplayMember = "None";
            this.routeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routeCombobox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeCombobox.FormattingEnabled = true;
            this.routeCombobox.Items.AddRange(new object[] {
            "None",
            "AppWithOutLogin",
            "AppWithLogin"});
            this.routeCombobox.Location = new System.Drawing.Point(118, 310);
            this.routeCombobox.Name = "routeCombobox";
            this.routeCombobox.Size = new System.Drawing.Size(157, 21);
            this.routeCombobox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.Location = new System.Drawing.Point(19, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Route:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.Location = new System.Drawing.Point(299, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "SubRoute:";
            // 
            // subrouteCombobox
            // 
            this.subrouteCombobox.DisplayMember = "None";
            this.subrouteCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subrouteCombobox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subrouteCombobox.FormattingEnabled = true;
            this.subrouteCombobox.Items.AddRange(new object[] {
            "None",
            "Home",
            "Profile"});
            this.subrouteCombobox.Location = new System.Drawing.Point(371, 310);
            this.subrouteCombobox.Name = "subrouteCombobox";
            this.subrouteCombobox.Size = new System.Drawing.Size(116, 21);
            this.subrouteCombobox.TabIndex = 16;
            // 
            // jsonDataTextBox
            // 
            this.jsonDataTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.jsonDataTextBox.Location = new System.Drawing.Point(117, 352);
            this.jsonDataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.jsonDataTextBox.Multiline = true;
            this.jsonDataTextBox.Name = "jsonDataTextBox";
            this.jsonDataTextBox.ReadOnly = true;
            this.jsonDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonDataTextBox.Size = new System.Drawing.Size(370, 189);
            this.jsonDataTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.Location = new System.Drawing.Point(19, 355);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Json Data:";
            // 
            // showJsonDataBtn
            // 
            this.showJsonDataBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.showJsonDataBtn.Location = new System.Drawing.Point(285, 556);
            this.showJsonDataBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showJsonDataBtn.Name = "showJsonDataBtn";
            this.showJsonDataBtn.Size = new System.Drawing.Size(99, 25);
            this.showJsonDataBtn.TabIndex = 20;
            this.showJsonDataBtn.Text = "Show Json";
            this.showJsonDataBtn.UseVisualStyleBackColor = true;
            this.showJsonDataBtn.Click += new System.EventHandler(this.showJsonDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 604);
            this.Controls.Add(this.showJsonDataBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jsonDataTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subrouteCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.routeCombobox);
            this.Controls.Add(this.notActionCombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topicRadioBtn);
            this.Controls.Add(this.devicetokenRadioBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceTokenTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceTokenTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton devicetokenRadioBtn;
        private System.Windows.Forms.RadioButton topicRadioBtn;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox notActionCombobox;
        private System.Windows.Forms.ComboBox routeCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox subrouteCombobox;
        private System.Windows.Forms.TextBox jsonDataTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button showJsonDataBtn;
    }
}

