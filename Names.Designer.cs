namespace Elektrarny
{
    partial class Names
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.names_label = new System.Windows.Forms.Label();
            this.names_label_list = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(10, 10);
            this.Name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(74, 25);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Name:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(85, 8);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(113, 31);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_textbox_keypress);
            // 
            // names_label
            // 
            this.names_label.AutoSize = true;
            this.names_label.Location = new System.Drawing.Point(236, 11);
            this.names_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.names_label.Name = "names_label";
            this.names_label.Size = new System.Drawing.Size(85, 25);
            this.names_label.TabIndex = 3;
            this.names_label.Text = "Names:";
            // 
            // names_label_list
            // 
            this.names_label_list.AutoSize = true;
            this.names_label_list.Location = new System.Drawing.Point(326, 11);
            this.names_label_list.Name = "names_label_list";
            this.names_label_list.Size = new System.Drawing.Size(0, 25);
            this.names_label_list.TabIndex = 4;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(15, 149);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(135, 42);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start);
            // 
            // Names
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 203);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.names_label_list);
            this.Controls.Add(this.names_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.Name_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Names";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elektrárny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label names_label;
        private System.Windows.Forms.Label names_label_list;
        private System.Windows.Forms.Button start_button;
    }
}

