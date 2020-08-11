namespace Exercise10_5
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
            this.lstBxBagType = new System.Windows.Forms.ListBox();
            this.lblBag = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbBxQuantity = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radThreeDay = new System.Windows.Forms.RadioButton();
            this.radOvernight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstBxBagType
            // 
            this.lstBxBagType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxBagType.ForeColor = System.Drawing.Color.DarkRed;
            this.lstBxBagType.FormattingEnabled = true;
            this.lstBxBagType.ItemHeight = 18;
            this.lstBxBagType.Items.AddRange(new object[] {
            "Beaded--$45.00",
            "Fringed--$25.00",
            "Full Decorative--$50.00",
            "Leather--$80.00",
            "Pirate Design--$40.00",
            "Plain--$20.00"});
            this.lstBxBagType.Location = new System.Drawing.Point(17, 139);
            this.lstBxBagType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstBxBagType.Name = "lstBxBagType";
            this.lstBxBagType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBxBagType.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxBagType.Size = new System.Drawing.Size(216, 72);
            this.lstBxBagType.Sorted = true;
            this.lstBxBagType.TabIndex = 0;
            // 
            // lblBag
            // 
            this.lblBag.AutoSize = true;
            this.lblBag.Location = new System.Drawing.Point(14, 106);
            this.lblBag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(39, 18);
            this.lblBag.TabIndex = 1;
            this.lblBag.Text = "Bag";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(302, 106);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 18);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbBxQuantity
            // 
            this.cmbBxQuantity.FormattingEnabled = true;
            this.cmbBxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBxQuantity.Location = new System.Drawing.Point(305, 139);
            this.cmbBxQuantity.Name = "cmbBxQuantity";
            this.cmbBxQuantity.Size = new System.Drawing.Size(80, 26);
            this.cmbBxQuantity.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.Location = new System.Drawing.Point(139, 347);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(115, 58);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(398, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 58);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(464, 106);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(114, 18);
            this.lblShipping.TabIndex = 6;
            this.lblShipping.Text = "and Shipping";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(11, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(109, 32);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Select:";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(467, 139);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(99, 22);
            this.radStandard.TabIndex = 8;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // radThreeDay
            // 
            this.radThreeDay.AutoSize = true;
            this.radThreeDay.Location = new System.Drawing.Point(467, 177);
            this.radThreeDay.Name = "radThreeDay";
            this.radThreeDay.Size = new System.Drawing.Size(110, 22);
            this.radThreeDay.TabIndex = 9;
            this.radThreeDay.TabStop = true;
            this.radThreeDay.Text = "Three-Day";
            this.radThreeDay.UseVisualStyleBackColor = true;
            // 
            // radOvernight
            // 
            this.radOvernight.AutoSize = true;
            this.radOvernight.Location = new System.Drawing.Point(467, 215);
            this.radOvernight.Name = "radOvernight";
            this.radOvernight.Size = new System.Drawing.Size(106, 22);
            this.radOvernight.TabIndex = 10;
            this.radOvernight.TabStop = true;
            this.radOvernight.Text = "Overnight";
            this.radOvernight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(653, 492);
            this.Controls.Add(this.radOvernight);
            this.Controls.Add(this.radThreeDay);
            this.Controls.Add(this.radStandard);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbBxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBag);
            this.Controls.Add(this.lstBxBagType);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Bag Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxBagType;
        private System.Windows.Forms.Label lblBag;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbBxQuantity;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radThreeDay;
        private System.Windows.Forms.RadioButton radOvernight;
    }
}

