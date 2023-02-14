namespace ScannerCommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Commandbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Printerperson = new System.Windows.Forms.ComboBox();
            this.Printbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Commandbox
            // 
            this.Commandbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Commandbox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Commandbox.Location = new System.Drawing.Point(0, 0);
            this.Commandbox.Name = "Commandbox";
            this.Commandbox.Size = new System.Drawing.Size(428, 43);
            this.Commandbox.TabIndex = 0;
            this.Commandbox.TextChanged += new System.EventHandler(this.Commandbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Print the Commands";
            // 
            // Printerperson
            // 
            this.Printerperson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Printerperson.FormattingEnabled = true;
            this.Printerperson.Items.AddRange(new object[] {
            "Operartor",
            "Administrator",
            "Programmer"});
            this.Printerperson.Location = new System.Drawing.Point(174, 47);
            this.Printerperson.Name = "Printerperson";
            this.Printerperson.Size = new System.Drawing.Size(151, 36);
            this.Printerperson.TabIndex = 2;
            // 
            // Printbutton
            // 
            this.Printbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Printbutton.Location = new System.Drawing.Point(334, 44);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(76, 39);
            this.Printbutton.TabIndex = 3;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            this.Printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 104);
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.Printerperson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Commandbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Omar Driouch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Commandbox;
        private Label label1;
        private ComboBox Printerperson;
        private Button Printbutton;
    }
}