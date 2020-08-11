namespace Exercise9_3
{
    partial class Form1
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
            this.lblNewX = new System.Windows.Forms.Label();
            this.lblNewY = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtNewX = new System.Windows.Forms.TextBox();
            this.txtNewY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNewX
            // 
            this.lblNewX.AutoSize = true;
            this.lblNewX.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewX.Location = new System.Drawing.Point(87, 163);
            this.lblNewX.Name = "lblNewX";
            this.lblNewX.Size = new System.Drawing.Size(167, 23);
            this.lblNewX.TabIndex = 0;
            this.lblNewX.Text = "New X Coordinate:";
            // 
            // lblNewY
            // 
            this.lblNewY.AutoSize = true;
            this.lblNewY.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewY.Location = new System.Drawing.Point(87, 194);
            this.lblNewY.Name = "lblNewY";
            this.lblNewY.Size = new System.Drawing.Size(166, 23);
            this.lblNewY.TabIndex = 1;
            this.lblNewY.Text = "New Y Coordinate:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(43, 40);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(393, 43);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Enter New Coordinates ";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DarkGray;
            this.btnApply.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(179, 332);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(120, 42);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtNewX
            // 
            this.txtNewX.Location = new System.Drawing.Point(291, 163);
            this.txtNewX.Name = "txtNewX";
            this.txtNewX.Size = new System.Drawing.Size(100, 20);
            this.txtNewX.TabIndex = 4;
            // 
            // txtNewY
            // 
            this.txtNewY.Location = new System.Drawing.Point(291, 194);
            this.txtNewY.Name = "txtNewY";
            this.txtNewY.Size = new System.Drawing.Size(100, 20);
            this.txtNewY.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtNewY);
            this.Controls.Add(this.txtNewX);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblNewY);
            this.Controls.Add(this.lblNewX);
            this.Name = "Form1";
            this.Text = "Screen Position App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewX;
        private System.Windows.Forms.Label lblNewY;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtNewX;
        private System.Windows.Forms.TextBox txtNewY;
    }
}

