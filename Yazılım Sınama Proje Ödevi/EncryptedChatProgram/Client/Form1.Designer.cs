
namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.cboxSHA = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(285, 158);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 23);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(285, 110);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(75, 23);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.0.1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(125, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Port:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Host:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(446, 110);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(125, 204);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(396, 55);
            this.txtMessage.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(446, 293);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(125, 345);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(396, 55);
            this.txtStatus.TabIndex = 13;
            // 
            // cboxSHA
            // 
            this.cboxSHA.AutoSize = true;
            this.cboxSHA.Location = new System.Drawing.Point(125, 293);
            this.cboxSHA.Name = "cboxSHA";
            this.cboxSHA.Size = new System.Drawing.Size(69, 17);
            this.cboxSHA.TabIndex = 14;
            this.cboxSHA.Text = "SHA256";
            this.cboxSHA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxSHA);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroCheckBox cboxSHA;
    }
}

