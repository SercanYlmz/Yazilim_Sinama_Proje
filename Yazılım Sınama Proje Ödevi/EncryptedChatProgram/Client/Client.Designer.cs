
namespace Client
{
    partial class Client
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
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(214, 128);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(56, 19);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(214, 89);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(56, 19);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.0.1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(94, 128);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Port:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(94, 89);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Host:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(334, 89);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 19);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(94, 166);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(297, 45);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(334, 238);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 19);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(94, 280);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(297, 45);
            this.txtStatus.TabIndex = 13;
            // 
            // cboxSHA
            // 
            this.cboxSHA.AutoSize = true;
            this.cboxSHA.Location = new System.Drawing.Point(94, 261);
            this.cboxSHA.Margin = new System.Windows.Forms.Padding(2);
            this.cboxSHA.Name = "cboxSHA";
            this.cboxSHA.Size = new System.Drawing.Size(64, 15);
            this.cboxSHA.TabIndex = 14;
            this.cboxSHA.Text = "SHA256";
            this.cboxSHA.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(94, 222);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(190, 19);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Text contains invalid characters!";
            this.lblError.UseStyleColors = true;
            this.lblError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 45);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cboxSHA);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

