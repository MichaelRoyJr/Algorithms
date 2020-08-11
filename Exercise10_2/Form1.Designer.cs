namespace Exercise10_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblClubName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckBxSkis = new System.Windows.Forms.CheckBox();
            this.ckBxPoles = new System.Windows.Forms.CheckBox();
            this.ckBxGloves = new System.Windows.Forms.CheckBox();
            this.ckBxGoggles = new System.Windows.Forms.CheckBox();
            this.ckBxJacket = new System.Windows.Forms.CheckBox();
            this.picbxPhoto = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("FontAwesome", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(64, 53);
            this.lblClubName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(292, 40);
            this.lblClubName.TabIndex = 0;
            this.lblClubName.Text = "Flyers Sports Club";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(421, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ckBxSkis
            // 
            this.ckBxSkis.AutoSize = true;
            this.ckBxSkis.Location = new System.Drawing.Point(44, 183);
            this.ckBxSkis.Margin = new System.Windows.Forms.Padding(4);
            this.ckBxSkis.Name = "ckBxSkis";
            this.ckBxSkis.Size = new System.Drawing.Size(53, 23);
            this.ckBxSkis.TabIndex = 3;
            this.ckBxSkis.Text = "Skis";
            this.ckBxSkis.UseVisualStyleBackColor = true;
            // 
            // ckBxPoles
            // 
            this.ckBxPoles.AutoSize = true;
            this.ckBxPoles.Location = new System.Drawing.Point(44, 232);
            this.ckBxPoles.Margin = new System.Windows.Forms.Padding(4);
            this.ckBxPoles.Name = "ckBxPoles";
            this.ckBxPoles.Size = new System.Drawing.Size(59, 23);
            this.ckBxPoles.TabIndex = 4;
            this.ckBxPoles.Text = "Poles";
            this.ckBxPoles.UseVisualStyleBackColor = true;
            // 
            // ckBxGloves
            // 
            this.ckBxGloves.AutoSize = true;
            this.ckBxGloves.Location = new System.Drawing.Point(44, 279);
            this.ckBxGloves.Margin = new System.Windows.Forms.Padding(4);
            this.ckBxGloves.Name = "ckBxGloves";
            this.ckBxGloves.Size = new System.Drawing.Size(70, 23);
            this.ckBxGloves.TabIndex = 5;
            this.ckBxGloves.Text = "Gloves";
            this.ckBxGloves.UseVisualStyleBackColor = true;
            // 
            // ckBxGoggles
            // 
            this.ckBxGoggles.AutoSize = true;
            this.ckBxGoggles.Location = new System.Drawing.Point(44, 326);
            this.ckBxGoggles.Margin = new System.Windows.Forms.Padding(4);
            this.ckBxGoggles.Name = "ckBxGoggles";
            this.ckBxGoggles.Size = new System.Drawing.Size(78, 23);
            this.ckBxGoggles.TabIndex = 6;
            this.ckBxGoggles.Text = "Goggles";
            this.ckBxGoggles.UseVisualStyleBackColor = true;
            // 
            // ckBxJacket
            // 
            this.ckBxJacket.AutoSize = true;
            this.ckBxJacket.Location = new System.Drawing.Point(44, 373);
            this.ckBxJacket.Margin = new System.Windows.Forms.Padding(4);
            this.ckBxJacket.Name = "ckBxJacket";
            this.ckBxJacket.Size = new System.Drawing.Size(72, 23);
            this.ckBxJacket.TabIndex = 7;
            this.ckBxJacket.Text = "Jacket";
            this.ckBxJacket.UseVisualStyleBackColor = true;
            // 
            // picbxPhoto
            // 
            this.picbxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picbxPhoto.Image")));
            this.picbxPhoto.ImageLocation = "";
            this.picbxPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbxPhoto.InitialImage")));
            this.picbxPhoto.Location = new System.Drawing.Point(225, 169);
            this.picbxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picbxPhoto.Name = "picbxPhoto";
            this.picbxPhoto.Size = new System.Drawing.Size(150, 200);
            this.picbxPhoto.TabIndex = 8;
            this.picbxPhoto.TabStop = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(259, 407);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(144, 39);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Ski Trip!!!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 424);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(71, 421);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(132, 26);
            this.txtBxName.TabIndex = 11;
            // 
            // txtDirections
            // 
            this.txtDirections.BackColor = System.Drawing.SystemColors.Control;
            this.txtDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirections.Location = new System.Drawing.Point(12, 116);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.Size = new System.Drawing.Size(397, 46);
            this.txtDirections.TabIndex = 12;
            this.txtDirections.Text = "Check box(es) for all equipment you will need to borrow for the upcoming ski trip" +
    ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 477);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.picbxPhoto);
            this.Controls.Add(this.ckBxJacket);
            this.Controls.Add(this.ckBxGoggles);
            this.Controls.Add(this.ckBxGloves);
            this.Controls.Add(this.ckBxPoles);
            this.Controls.Add(this.ckBxSkis);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sign Up Sheet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckBxSkis;
        private System.Windows.Forms.CheckBox ckBxPoles;
        private System.Windows.Forms.CheckBox ckBxGloves;
        private System.Windows.Forms.CheckBox ckBxGoggles;
        private System.Windows.Forms.CheckBox ckBxJacket;
        private System.Windows.Forms.PictureBox picbxPhoto;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtDirections;
    }
}

