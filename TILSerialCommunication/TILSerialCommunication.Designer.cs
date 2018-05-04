namespace TILSerialCommunication
{
    partial class TADSerialCommunication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TADSerialCommunication));
            this.sendmsg = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.TAD = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendmsg
            // 
            this.sendmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendmsg.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendmsg.Location = new System.Drawing.Point(9, 431);
            this.sendmsg.Margin = new System.Windows.Forms.Padding(0);
            this.sendmsg.MaxLength = 15;
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.Size = new System.Drawing.Size(199, 37);
            this.sendmsg.TabIndex = 0;
            this.sendmsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendmsg_KeyDown);
            // 
            // sendbutton
            // 
            this.sendbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendbutton.BackColor = System.Drawing.Color.Black;
            this.sendbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendbutton.FlatAppearance.BorderSize = 2;
            this.sendbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbutton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.ForeColor = System.Drawing.Color.White;
            this.sendbutton.Location = new System.Drawing.Point(208, 431);
            this.sendbutton.Margin = new System.Windows.Forms.Padding(0);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(81, 37);
            this.sendbutton.TabIndex = 1;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // TAD
            // 
            this.TAD.AllowDrop = true;
            this.TAD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TAD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAD.Location = new System.Drawing.Point(9, 28);
            this.TAD.Name = "TAD";
            this.TAD.Size = new System.Drawing.Size(280, 403);
            this.TAD.TabIndex = 2;
            this.TAD.Text = "HELLO!";
            this.TAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(274, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refresh
            // 
            this.Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(246, 1);
            this.Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(28, 34);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "R";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // TADSerialCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(304, 477);
            this.ControlBox = false;
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.sendmsg);
            this.Controls.Add(this.TAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TADSerialCommunication";
            this.Text = "TADSerialCommunication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendmsg;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Label TAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Refresh;
    }
}

