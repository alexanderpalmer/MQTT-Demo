namespace MQTT_Client_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.CmdSendMessage = new System.Windows.Forms.Button();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(13, 13);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(684, 20);
            this.TxtInput.TabIndex = 0;
            // 
            // CmdSendMessage
            // 
            this.CmdSendMessage.Location = new System.Drawing.Point(417, 40);
            this.CmdSendMessage.Name = "CmdSendMessage";
            this.CmdSendMessage.Size = new System.Drawing.Size(279, 23);
            this.CmdSendMessage.TabIndex = 2;
            this.CmdSendMessage.Text = "Publish MQTT Message";
            this.CmdSendMessage.UseVisualStyleBackColor = true;
            this.CmdSendMessage.Click += new System.EventHandler(this.CmdSendMessage_Click);
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.Location = new System.Drawing.Point(13, 75);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(683, 212);
            this.LstOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 300);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.CmdSendMessage);
            this.Controls.Add(this.TxtInput);
            this.Name = "Form1";
            this.Text = "MQTT-Client 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button CmdSendMessage;
        private System.Windows.Forms.ListBox LstOutput;
    }
}

