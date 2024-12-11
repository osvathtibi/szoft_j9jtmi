namespace ZH3_3
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
            buttonEvent = new Button();
            buttonPart = new Button();
            buttonEAP = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // buttonEvent
            // 
            buttonEvent.Location = new Point(53, 26);
            buttonEvent.Name = "buttonEvent";
            buttonEvent.Size = new Size(94, 29);
            buttonEvent.TabIndex = 0;
            buttonEvent.Text = "Events";
            buttonEvent.UseVisualStyleBackColor = true;
            buttonEvent.Click += buttonEvent_Click;
            // 
            // buttonPart
            // 
            buttonPart.Anchor = AnchorStyles.Top;
            buttonPart.Location = new Point(350, 26);
            buttonPart.Name = "buttonPart";
            buttonPart.Size = new Size(94, 29);
            buttonPart.TabIndex = 1;
            buttonPart.Text = "Participants";
            buttonPart.UseVisualStyleBackColor = true;
            buttonPart.Click += buttonPart_Click;
            // 
            // buttonEAP
            // 
            buttonEAP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEAP.Location = new Point(604, 26);
            buttonEAP.Name = "buttonEAP";
            buttonEAP.Size = new Size(94, 29);
            buttonEAP.TabIndex = 2;
            buttonEAP.Text = "EAP";
            buttonEAP.UseVisualStyleBackColor = true;
            buttonEAP.Click += buttonEAP_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(1, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 319);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(buttonEAP);
            Controls.Add(buttonPart);
            Controls.Add(buttonEvent);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEvent;
        private Button buttonPart;
        private Button buttonEAP;
        private Panel panel1;
    }
}
