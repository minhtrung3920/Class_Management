namespace WindowsFormsApplication
{
    partial class CreateClassForm
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtClassName_1 = new System.Windows.Forms.TextBox();
            this.txtDescrip_1 = new System.Windows.Forms.TextBox();
            this.btnCancel_1 = new System.Windows.Forms.Button();
            this.btnSave_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(25, 24);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(97, 20);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class\'s name";
            // 
            // lblDescrip
            // 
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(25, 70);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(97, 19);
            this.lblDescrip.TabIndex = 0;
            this.lblDescrip.Text = "Description";
            // 
            // txtClassName_1
            // 
            this.txtClassName_1.Location = new System.Drawing.Point(159, 24);
            this.txtClassName_1.Name = "txtClassName_1";
            this.txtClassName_1.Size = new System.Drawing.Size(129, 20);
            this.txtClassName_1.TabIndex = 1;
            // 
            // txtDescrip_1
            // 
            this.txtDescrip_1.Location = new System.Drawing.Point(159, 69);
            this.txtDescrip_1.Name = "txtDescrip_1";
            this.txtDescrip_1.Size = new System.Drawing.Size(129, 20);
            this.txtDescrip_1.TabIndex = 1;
            // 
            // btnCancel_1
            // 
            this.btnCancel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_1.Location = new System.Drawing.Point(180, 127);
            this.btnCancel_1.Name = "btnCancel_1";
            this.btnCancel_1.Size = new System.Drawing.Size(65, 23);
            this.btnCancel_1.TabIndex = 2;
            this.btnCancel_1.Text = "Cancel\r\n";
            this.btnCancel_1.UseVisualStyleBackColor = true;
            // 
            // btnSave_1
            // 
            this.btnSave_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_1.Location = new System.Drawing.Point(73, 127);
            this.btnSave_1.Name = "btnSave_1";
            this.btnSave_1.Size = new System.Drawing.Size(75, 23);
            this.btnSave_1.TabIndex = 2;
            this.btnSave_1.Text = "Save";
            this.btnSave_1.UseVisualStyleBackColor = true;
            // 
            // CreateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 178);
            this.Controls.Add(this.btnSave_1);
            this.Controls.Add(this.btnCancel_1);
            this.Controls.Add(this.txtDescrip_1);
            this.Controls.Add(this.txtClassName_1);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblClassName);
            this.Name = "CreateClassForm";
            this.Text = "CreateClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtClassName_1;
        private System.Windows.Forms.TextBox txtDescrip_1;
        private System.Windows.Forms.Button btnCancel_1;
        private System.Windows.Forms.Button btnSave_1;
    }
}

