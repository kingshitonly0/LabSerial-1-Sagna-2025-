namespace SerialSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxD1;
        private System.Windows.Forms.TextBox textBoxD2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelD1;
        private System.Windows.Forms.Label labelD2;

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
            comboBoxPorts = new ComboBox();
            buttonList = new Button();
            buttonOpen = new Button();
            buttonClose = new Button();
            textBoxD1 = new TextBox();
            textBoxD2 = new TextBox();
            buttonSend = new Button();
            labelD1 = new Label();
            labelD2 = new Label();
            labelSeparator = new Label();
            labelPOC = new Label();
            SuspendLayout();
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(189, 27);
            comboBoxPorts.Margin = new Padding(3, 4, 3, 4);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(114, 28);
            comboBoxPorts.TabIndex = 0;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(23, 27);
            buttonList.Margin = new Padding(3, 4, 3, 4);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(86, 31);
            buttonList.TabIndex = 1;
            buttonList.Text = "List";
            buttonList.UseVisualStyleBackColor = true;
            buttonList.Click += buttonList_Click_1;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(23, 80);
            buttonOpen.Margin = new Padding(3, 4, 3, 4);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(86, 31);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(189, 80);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(86, 31);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // textBoxD1
            // 
            textBoxD1.Location = new Point(63, 170);
            textBoxD1.Margin = new Padding(3, 4, 3, 4);
            textBoxD1.Name = "textBoxD1";
            textBoxD1.Size = new Size(68, 27);
            textBoxD1.TabIndex = 5;
            // 
            // textBoxD2
            // 
            textBoxD2.Location = new Point(189, 170);
            textBoxD2.Margin = new Padding(3, 4, 3, 4);
            textBoxD2.Name = "textBoxD2";
            textBoxD2.Size = new Size(68, 27);
            textBoxD2.TabIndex = 7;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(97, 213);
            buttonSend.Margin = new Padding(3, 4, 3, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(86, 31);
            buttonSend.TabIndex = 8;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click_1;
            // 
            // labelD1
            // 
            labelD1.Location = new Point(23, 173);
            labelD1.Name = "labelD1";
            labelD1.Size = new Size(34, 31);
            labelD1.TabIndex = 4;
            labelD1.Text = "D1";
            // 
            // labelD2
            // 
            labelD2.Location = new Point(149, 170);
            labelD2.Name = "labelD2";
            labelD2.Size = new Size(34, 31);
            labelD2.TabIndex = 6;
            labelD2.Text = "D2";
            // 
            // labelSeparator
            // 
            labelSeparator.Location = new Point(-11, 123);
            labelSeparator.Name = "labelSeparator";
            labelSeparator.Size = new Size(366, 20);
            labelSeparator.TabIndex = 10;
            labelSeparator.Text = "------------------------------------------------------";
            // 
            // labelPOC
            // 
            labelPOC.AutoSize = true;
            labelPOC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPOC.Location = new Point(61, 281);
            labelPOC.Name = "labelPOC";
            labelPOC.Size = new Size(214, 20);
            labelPOC.TabIndex = 11;
            labelPOC.Text = "POC-Mouhamed-Sagna-2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 333);
            Controls.Add(labelPOC);
            Controls.Add(labelSeparator);
            Controls.Add(comboBoxPorts);
            Controls.Add(buttonList);
            Controls.Add(buttonOpen);
            Controls.Add(buttonClose);
            Controls.Add(labelD1);
            Controls.Add(textBoxD1);
            Controls.Add(labelD2);
            Controls.Add(textBoxD2);
            Controls.Add(buttonSend);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "SerialSend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSeparator;
        private Label labelPOC;
    }
}
