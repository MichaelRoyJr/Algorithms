namespace Exercise12_1
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
            this.txtBxVal1 = new System.Windows.Forms.TextBox();
            this.txtBxVal2 = new System.Windows.Forms.TextBox();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblValues = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lstBxValues = new System.Windows.Forms.ListBox();
            this.lstBxProduct = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBxVal1
            // 
            this.txtBxVal1.Location = new System.Drawing.Point(177, 82);
            this.txtBxVal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxVal1.Name = "txtBxVal1";
            this.txtBxVal1.Size = new System.Drawing.Size(148, 29);
            this.txtBxVal1.TabIndex = 0;
            // 
            // txtBxVal2
            // 
            this.txtBxVal2.Location = new System.Drawing.Point(177, 130);
            this.txtBxVal2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxVal2.Name = "txtBxVal2";
            this.txtBxVal2.Size = new System.Drawing.Size(148, 29);
            this.txtBxVal2.TabIndex = 1;
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(63, 89);
            this.lblValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(64, 22);
            this.lblValue1.TabIndex = 2;
            this.lblValue1.Text = "Value 1:";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(63, 137);
            this.lblValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(64, 22);
            this.lblValue2.TabIndex = 3;
            this.lblValue2.Text = "Value 2:";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompute.Location = new System.Drawing.Point(138, 210);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(112, 39);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(63, 281);
            this.lblValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(58, 22);
            this.lblValues.TabIndex = 5;
            this.lblValues.Text = "Values:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(63, 383);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 22);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product";
            // 
            // lstBxValues
            // 
            this.lstBxValues.FormattingEnabled = true;
            this.lstBxValues.ItemHeight = 22;
            this.lstBxValues.Location = new System.Drawing.Point(177, 281);
            this.lstBxValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBxValues.Name = "lstBxValues";
            this.lstBxValues.Size = new System.Drawing.Size(148, 48);
            this.lstBxValues.TabIndex = 8;
            // 
            // lstBxProduct
            // 
            this.lstBxProduct.FormattingEnabled = true;
            this.lstBxProduct.ItemHeight = 22;
            this.lstBxProduct.Location = new System.Drawing.Point(177, 383);
            this.lstBxProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBxProduct.Name = "lstBxProduct";
            this.lstBxProduct.Size = new System.Drawing.Size(148, 26);
            this.lstBxProduct.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 498);
            this.Controls.Add(this.lstBxProduct);
            this.Controls.Add(this.lstBxValues);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.txtBxVal2);
            this.Controls.Add(this.txtBxVal1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxVal1;
        private System.Windows.Forms.TextBox txtBxVal2;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lstBxValues;
        private System.Windows.Forms.ListBox lstBxProduct;
    }
}

