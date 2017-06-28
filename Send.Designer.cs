namespace BitcoinWallet
{
    partial class Send
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.walletAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sumToSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(302, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 302);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet address for beneficiary:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // walletAddress
            // 
            this.walletAddress.Location = new System.Drawing.Point(30, 70);
            this.walletAddress.Name = "walletAddress";
            this.walletAddress.Size = new System.Drawing.Size(256, 20);
            this.walletAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many BTC to send:";
            // 
            // sumToSend
            // 
            this.sumToSend.Location = new System.Drawing.Point(30, 172);
            this.sumToSend.Name = "sumToSend";
            this.sumToSend.Size = new System.Drawing.Size(146, 20);
            this.sumToSend.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note (optional):";
            // 
            // paymentNote
            // 
            this.paymentNote.Location = new System.Drawing.Point(30, 279);
            this.paymentNote.Name = "paymentNote";
            this.paymentNote.Size = new System.Drawing.Size(256, 20);
            this.paymentNote.TabIndex = 7;
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 375);
            this.Controls.Add(this.paymentNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumToSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.walletAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Send";
            this.Text = "Send BTC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox walletAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumToSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paymentNote;
    }
}