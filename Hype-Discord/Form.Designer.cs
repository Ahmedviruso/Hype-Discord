
namespace Hype_Discord
{
    partial class Form
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Active = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.MaxLength = 88;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(288, 20);
            this.TextBox.TabIndex = 0;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // Active
            // 
            this.Active.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.Location = new System.Drawing.Point(113, 68);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(75, 26);
            this.Active.TabIndex = 1;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = false;
            this.Active.Click += new System.EventHandler(this.Active_Click);
            this.Active.MouseLeave += new System.EventHandler(this.Active_MouseLeave);
            this.Active.MouseHover += new System.EventHandler(this.Active_MouseHover);
            // 
            // Selector
            // 
            this.Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selector.FormattingEnabled = true;
            this.Selector.Items.AddRange(new object[] {
            "Purple",
            "Red",
            "Green"});
            this.Selector.Location = new System.Drawing.Point(113, 41);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(121, 21);
            this.Selector.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Badge:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 106);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selector);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "HypeSquad Activator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Active;
        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Label label1;
    }
}

