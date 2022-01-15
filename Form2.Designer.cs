
namespace test_for_cody
{
    partial class Form2
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
            this.gb_from_another_form = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_from_another_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_from_another_form
            // 
            this.gb_from_another_form.Controls.Add(this.button1);
            this.gb_from_another_form.Location = new System.Drawing.Point(47, 29);
            this.gb_from_another_form.Name = "gb_from_another_form";
            this.gb_from_another_form.Size = new System.Drawing.Size(200, 100);
            this.gb_from_another_form.TabIndex = 0;
            this.gb_from_another_form.TabStop = false;
            this.gb_from_another_form.Text = "gb from Form2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button from form 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_from_another_form);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gb_from_another_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_from_another_form;
        private System.Windows.Forms.Button button1;
    }
}