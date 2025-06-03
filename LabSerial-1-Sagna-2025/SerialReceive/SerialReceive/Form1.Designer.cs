namespace SerialReceive
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TextBox textBoxD1;
        private System.Windows.Forms.TextBox textBoxD2;
        private System.Windows.Forms.Label labelD1;
        private System.Windows.Forms.Label labelD2;
        private System.Windows.Forms.Label labelPOC;
        private System.Windows.Forms.Label labelSeparator;

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
            buttonList = new Button();
            buttonOpen = new Button();
            buttonClose = new Button();
            comboBoxPorts = new ComboBox();
            textBoxD1 = new TextBox();
            textBoxD2 = new TextBox();
            labelD1 = new Label();
            labelD2 = new Label();
            labelPOC = new Label();
            labelSeparator = new Label();
            SuspendLayout();
            // 
            // buttonList
            // 
            buttonList.Location = new Point(37, 13);
            buttonList.Margin = new Padding(3, 4, 3, 4);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(86, 33);
            buttonList.TabIndex = 1;
            buttonList.Text = "List";
            buttonList.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(46, 107);
            buttonOpen.Margin = new Padding(3, 4, 3, 4);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(86, 33);
            buttonOpen.TabIndex = 3;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(171, 107);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(86, 33);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(171, 13);
            comboBoxPorts.Margin = new Padding(3, 4, 3, 4);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(102, 28);
            comboBoxPorts.TabIndex = 2;
            // 
            // textBoxD1
            // 
            textBoxD1.Location = new Point(80, 196);
            textBoxD1.Margin = new Padding(3, 4, 3, 4);
            textBoxD1.Name = "textBoxD1";
            textBoxD1.Size = new Size(68, 27);
            textBoxD1.TabIndex = 7;
            // 
            // textBoxD2
            // 
            textBoxD2.Location = new Point(206, 196);
            textBoxD2.Margin = new Padding(3, 4, 3, 4);
            textBoxD2.Name = "textBoxD2";
            textBoxD2.Size = new Size(68, 27);
            textBoxD2.TabIndex = 9;
            // 
            // labelD1
            // 
            labelD1.AutoSize = true;
            labelD1.Location = new Point(46, 200);
            labelD1.Name = "labelD1";
            labelD1.Size = new Size(28, 20);
            labelD1.TabIndex = 6;
            labelD1.Text = "D1";
            // 
            // labelD2
            // 
            labelD2.AutoSize = true;
            labelD2.Location = new Point(171, 200);
            labelD2.Name = "labelD2";
            labelD2.Size = new Size(28, 20);
            labelD2.TabIndex = 8;
            labelD2.Text = "D2";
            // 
            // labelPOC
            // 
            labelPOC.AutoSize = true;
            labelPOC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPOC.Location = new Point(59, 286);
            labelPOC.Name = "labelPOC";
            labelPOC.Size = new Size(214, 20);
            labelPOC.TabIndex = 0;
            labelPOC.Text = "POC-Mouhamed-Sagna-2025";
            labelPOC.Click += labelPOC_Click;
            // 
            // labelSeparator
            // 
            labelSeparator.Location = new Point(11, 160);
            labelSeparator.Name = "labelSeparator";
            labelSeparator.Size = new Size(286, 20);
            labelSeparator.TabIndex = 5;
            labelSeparator.Text = "------------------------------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 333);
            Controls.Add(labelPOC);
            Controls.Add(buttonList);
            Controls.Add(comboBoxPorts);
            Controls.Add(buttonOpen);
            Controls.Add(buttonClose);
            Controls.Add(labelSeparator);
            Controls.Add(labelD1);
            Controls.Add(textBoxD1);
            Controls.Add(labelD2);
            Controls.Add(textBoxD2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SerialReceive";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
