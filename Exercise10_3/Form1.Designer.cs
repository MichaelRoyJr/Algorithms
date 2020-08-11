namespace Exercise10_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHockey = new System.Windows.Forms.RadioButton();
            this.radSoccer = new System.Windows.Forms.RadioButton();
            this.radBasketball = new System.Windows.Forms.RadioButton();
            this.radFootball = new System.Windows.Forms.RadioButton();
            this.radBaseball = new System.Windows.Forms.RadioButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picBxBaseball = new System.Windows.Forms.PictureBox();
            this.picBxFootball = new System.Windows.Forms.PictureBox();
            this.picBxBasketball = new System.Windows.Forms.PictureBox();
            this.picBxSoccer = new System.Windows.Forms.PictureBox();
            this.picBxHockey = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBaseball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFootball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBasketball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSoccer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHockey)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.radHockey);
            this.groupBox1.Controls.Add(this.radSoccer);
            this.groupBox1.Controls.Add(this.radBasketball);
            this.groupBox1.Controls.Add(this.radFootball);
            this.groupBox1.Controls.Add(this.radBaseball);
            this.groupBox1.Location = new System.Drawing.Point(30, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(166, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radHockey
            // 
            this.radHockey.AutoSize = true;
            this.radHockey.Location = new System.Drawing.Point(30, 213);
            this.radHockey.Margin = new System.Windows.Forms.Padding(4);
            this.radHockey.Name = "radHockey";
            this.radHockey.Size = new System.Drawing.Size(80, 23);
            this.radHockey.TabIndex = 4;
            this.radHockey.Text = "Hockey";
            this.radHockey.UseVisualStyleBackColor = true;
            this.radHockey.CheckedChanged += new System.EventHandler(this.radHockey_CheckedChanged);
            // 
            // radSoccer
            // 
            this.radSoccer.AutoSize = true;
            this.radSoccer.Location = new System.Drawing.Point(30, 173);
            this.radSoccer.Margin = new System.Windows.Forms.Padding(4);
            this.radSoccer.Name = "radSoccer";
            this.radSoccer.Size = new System.Drawing.Size(78, 23);
            this.radSoccer.TabIndex = 3;
            this.radSoccer.Text = "Soccer";
            this.radSoccer.UseVisualStyleBackColor = true;
            this.radSoccer.CheckedChanged += new System.EventHandler(this.radSoccer_CheckedChanged);
            // 
            // radBasketball
            // 
            this.radBasketball.AutoSize = true;
            this.radBasketball.Location = new System.Drawing.Point(30, 128);
            this.radBasketball.Margin = new System.Windows.Forms.Padding(4);
            this.radBasketball.Name = "radBasketball";
            this.radBasketball.Size = new System.Drawing.Size(104, 23);
            this.radBasketball.TabIndex = 2;
            this.radBasketball.Text = "Basketball";
            this.radBasketball.UseVisualStyleBackColor = true;
            this.radBasketball.CheckedChanged += new System.EventHandler(this.radBasketball_CheckedChanged);
            // 
            // radFootball
            // 
            this.radFootball.AutoSize = true;
            this.radFootball.Location = new System.Drawing.Point(30, 86);
            this.radFootball.Margin = new System.Windows.Forms.Padding(4);
            this.radFootball.Name = "radFootball";
            this.radFootball.Size = new System.Drawing.Size(87, 23);
            this.radFootball.TabIndex = 1;
            this.radFootball.Text = "Football";
            this.radFootball.UseVisualStyleBackColor = true;
            this.radFootball.Click += new System.EventHandler(this.radFootball_Click);
            // 
            // radBaseball
            // 
            this.radBaseball.AutoSize = true;
            this.radBaseball.Location = new System.Drawing.Point(30, 41);
            this.radBaseball.Margin = new System.Windows.Forms.Padding(4);
            this.radBaseball.Name = "radBaseball";
            this.radBaseball.Size = new System.Drawing.Size(91, 23);
            this.radBaseball.TabIndex = 0;
            this.radBaseball.Text = "Baseball";
            this.radBaseball.UseVisualStyleBackColor = true;
            this.radBaseball.Click += new System.EventHandler(this.radBaseball_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(81, 44);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(265, 39);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Select your Sport!";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(248, 134);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 19);
            this.lblMessage.TabIndex = 2;
            // 
            // picBxBaseball
            // 
            this.picBxBaseball.Image = ((System.Drawing.Image)(resources.GetObject("picBxBaseball.Image")));
            this.picBxBaseball.Location = new System.Drawing.Point(256, 245);
            this.picBxBaseball.Name = "picBxBaseball";
            this.picBxBaseball.Size = new System.Drawing.Size(140, 140);
            this.picBxBaseball.TabIndex = 3;
            this.picBxBaseball.TabStop = false;
            this.picBxBaseball.Visible = false;
            // 
            // picBxFootball
            // 
            this.picBxFootball.Enabled = false;
            this.picBxFootball.Image = ((System.Drawing.Image)(resources.GetObject("picBxFootball.Image")));
            this.picBxFootball.Location = new System.Drawing.Point(256, 245);
            this.picBxFootball.Name = "picBxFootball";
            this.picBxFootball.Size = new System.Drawing.Size(140, 140);
            this.picBxFootball.TabIndex = 4;
            this.picBxFootball.TabStop = false;
            this.picBxFootball.Visible = false;
            // 
            // picBxBasketball
            // 
            this.picBxBasketball.Enabled = false;
            this.picBxBasketball.Image = ((System.Drawing.Image)(resources.GetObject("picBxBasketball.Image")));
            this.picBxBasketball.Location = new System.Drawing.Point(256, 245);
            this.picBxBasketball.Name = "picBxBasketball";
            this.picBxBasketball.Size = new System.Drawing.Size(140, 140);
            this.picBxBasketball.TabIndex = 5;
            this.picBxBasketball.TabStop = false;
            this.picBxBasketball.Visible = false;
            // 
            // picBxSoccer
            // 
            this.picBxSoccer.Enabled = false;
            this.picBxSoccer.Image = ((System.Drawing.Image)(resources.GetObject("picBxSoccer.Image")));
            this.picBxSoccer.Location = new System.Drawing.Point(256, 245);
            this.picBxSoccer.Name = "picBxSoccer";
            this.picBxSoccer.Size = new System.Drawing.Size(140, 140);
            this.picBxSoccer.TabIndex = 6;
            this.picBxSoccer.TabStop = false;
            this.picBxSoccer.Visible = false;
            // 
            // picBxHockey
            // 
            this.picBxHockey.Enabled = false;
            this.picBxHockey.Image = ((System.Drawing.Image)(resources.GetObject("picBxHockey.Image")));
            this.picBxHockey.Location = new System.Drawing.Point(256, 245);
            this.picBxHockey.Name = "picBxHockey";
            this.picBxHockey.Size = new System.Drawing.Size(140, 140);
            this.picBxHockey.TabIndex = 7;
            this.picBxHockey.TabStop = false;
            this.picBxHockey.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(427, 486);
            this.Controls.Add(this.picBxHockey);
            this.Controls.Add(this.picBxSoccer);
            this.Controls.Add(this.picBxBasketball);
            this.Controls.Add(this.picBxFootball);
            this.Controls.Add(this.picBxBaseball);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sports Sign Up Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBaseball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFootball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBasketball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSoccer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHockey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHockey;
        private System.Windows.Forms.RadioButton radSoccer;
        private System.Windows.Forms.RadioButton radBasketball;
        private System.Windows.Forms.RadioButton radFootball;
        private System.Windows.Forms.RadioButton radBaseball;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picBxBaseball;
        private System.Windows.Forms.PictureBox picBxFootball;
        private System.Windows.Forms.PictureBox picBxBasketball;
        private System.Windows.Forms.PictureBox picBxSoccer;
        private System.Windows.Forms.PictureBox picBxHockey;
    }
}

