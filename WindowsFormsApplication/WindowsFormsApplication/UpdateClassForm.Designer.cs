namespace WindowsFormsApplication
{
    partial class UpdateClassForm
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
            this.txtClassName_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecrip_2 = new System.Windows.Forms.TextBox();
            this.btnCancel_2 = new System.Windows.Forms.Button();
            this.btnSave_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class\'name";
            // 
            // txtClassName_2
            // 
            this.txtClassName_2.Location = new System.Drawing.Point(173, 30);
            this.txtClassName_2.Name = "txtClassName_2";
            this.txtClassName_2.Size = new System.Drawing.Size(122, 20);
            this.txtClassName_2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // txtDecrip_2
            // 
            this.txtDecrip_2.Location = new System.Drawing.Point(173, 70);
            this.txtDecrip_2.Name = "txtDecrip_2";
            this.txtDecrip_2.Size = new System.Drawing.Size(122, 20);
            this.txtDecrip_2.TabIndex = 1;
            // 
            // btnCancel_2
            // 
            this.btnCancel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_2.Location = new System.Drawing.Point(189, 113);
            this.btnCancel_2.Name = "btnCancel_2";
            this.btnCancel_2.Size = new System.Drawing.Size(75, 31);
            this.btnCancel_2.TabIndex = 2;
            this.btnCancel_2.Text = "Cancel";
            this.btnCancel_2.UseVisualStyleBackColor = true;
            // 
            // btnSave_2
            // 
            this.btnSave_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_2.Location = new System.Drawing.Point(85, 113);
            this.btnSave_2.Name = "btnSave_2";
            this.btnSave_2.Size = new System.Drawing.Size(75, 31);
            this.btnSave_2.TabIndex = 2;
            this.btnSave_2.Text = "Save";
            this.btnSave_2.UseVisualStyleBackColor = true;
            // 
            // UpdateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 179);
            this.Controls.Add(this.btnSave_2);
            this.Controls.Add(this.btnCancel_2);
            this.Controls.Add(this.txtDecrip_2);
            this.Controls.Add(this.txtClassName_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateClassForm";
            this.Text = "UpdateClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecrip_2;
        private System.Windows.Forms.Button btnCancel_2;
        private System.Windows.Forms.Button btnSave_2;
    }
}