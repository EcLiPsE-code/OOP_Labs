namespace Salary
{
    partial class DeletedEmployee
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
            this.deleteNameText = new System.Windows.Forms.TextBox();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя";
            // 
            // deleteNameText
            // 
            this.deleteNameText.Location = new System.Drawing.Point(157, 12);
            this.deleteNameText.Name = "deleteNameText";
            this.deleteNameText.Size = new System.Drawing.Size(160, 20);
            this.deleteNameText.TabIndex = 1;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.deleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteEmployee.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.Location = new System.Drawing.Point(103, 53);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(154, 45);
            this.deleteEmployee.TabIndex = 2;
            this.deleteEmployee.Text = "Удалить";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployeeClick);
            // 
            // DeletedEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 126);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.deleteNameText);
            this.Controls.Add(this.label1);
            this.Name = "DeletedEmployee";
            this.Text = "DeletedEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteNameText;
        private System.Windows.Forms.Button deleteEmployee;
    }
}