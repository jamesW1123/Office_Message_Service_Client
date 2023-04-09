namespace MessageServiceClientApp
{
    partial class ClientGui
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSndStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxSndMessage = new System.Windows.Forms.GroupBox();
            this.txtSndMessage = new System.Windows.Forms.TextBox();
            this.gbxSndRecipients = new System.Windows.Forms.GroupBox();
            this.clbSndRecipients = new System.Windows.Forms.CheckedListBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.txtSndEmail = new System.Windows.Forms.TextBox();
            this.txtSndPhone = new System.Windows.Forms.TextBox();
            this.txtSndAddress = new System.Windows.Forms.TextBox();
            this.txtSndName = new System.Windows.Forms.TextBox();
            this.lblSndEmail = new System.Windows.Forms.Label();
            this.lblSndPhone = new System.Windows.Forms.Label();
            this.lblSndAddress = new System.Windows.Forms.Label();
            this.lblSndName = new System.Windows.Forms.Label();
            this.tabReceive = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRecStatus = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.gbxRecMessage = new System.Windows.Forms.GroupBox();
            this.txtRecMessage = new System.Windows.Forms.TextBox();
            this.gbxRecRecipients = new System.Windows.Forms.GroupBox();
            this.clbRecRecipients = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecEmail = new System.Windows.Forms.TextBox();
            this.txtRecPhone = new System.Windows.Forms.TextBox();
            this.txtRecAddress = new System.Windows.Forms.TextBox();
            this.txtRecName = new System.Windows.Forms.TextBox();
            this.lblRecEmail = new System.Windows.Forms.Label();
            this.lblRecPhone = new System.Windows.Forms.Label();
            this.lblRecAddress = new System.Windows.Forms.Label();
            this.lblRecName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxSndMessage.SuspendLayout();
            this.gbxSndRecipients.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.tabReceive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxRecMessage.SuspendLayout();
            this.gbxRecRecipients.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSend);
            this.tabControl1.Controls.Add(this.tabReceive);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.panel1);
            this.tabSend.Controls.Add(this.gbxSndMessage);
            this.tabSend.Controls.Add(this.gbxSndRecipients);
            this.tabSend.Controls.Add(this.gbxInfo);
            this.tabSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSend.Location = new System.Drawing.Point(4, 25);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(613, 454);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Send";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblSndStatus);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(9, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 37);
            this.panel1.TabIndex = 5;
            // 
            // lblSndStatus
            // 
            this.lblSndStatus.AutoSize = true;
            this.lblSndStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSndStatus.Location = new System.Drawing.Point(283, 11);
            this.lblSndStatus.Name = "lblSndStatus";
            this.lblSndStatus.Size = new System.Drawing.Size(97, 16);
            this.lblSndStatus.TabIndex = 1;
            this.lblSndStatus.Text = "Not Connected";
            this.lblSndStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSend.AutoSize = true;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(17, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbxSndMessage
            // 
            this.gbxSndMessage.Controls.Add(this.txtSndMessage);
            this.gbxSndMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSndMessage.Location = new System.Drawing.Point(6, 173);
            this.gbxSndMessage.Name = "gbxSndMessage";
            this.gbxSndMessage.Size = new System.Drawing.Size(392, 231);
            this.gbxSndMessage.TabIndex = 4;
            this.gbxSndMessage.TabStop = false;
            this.gbxSndMessage.Text = "Message";
            // 
            // txtSndMessage
            // 
            this.txtSndMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSndMessage.Location = new System.Drawing.Point(3, 16);
            this.txtSndMessage.Multiline = true;
            this.txtSndMessage.Name = "txtSndMessage";
            this.txtSndMessage.Size = new System.Drawing.Size(386, 212);
            this.txtSndMessage.TabIndex = 0;
            // 
            // gbxSndRecipients
            // 
            this.gbxSndRecipients.Controls.Add(this.clbSndRecipients);
            this.gbxSndRecipients.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxSndRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSndRecipients.Location = new System.Drawing.Point(401, 3);
            this.gbxSndRecipients.Name = "gbxSndRecipients";
            this.gbxSndRecipients.Size = new System.Drawing.Size(209, 448);
            this.gbxSndRecipients.TabIndex = 3;
            this.gbxSndRecipients.TabStop = false;
            this.gbxSndRecipients.Text = "Recipient(s)";
            // 
            // clbSndRecipients
            // 
            this.clbSndRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSndRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSndRecipients.FormattingEnabled = true;
            this.clbSndRecipients.Location = new System.Drawing.Point(3, 16);
            this.clbSndRecipients.Name = "clbSndRecipients";
            this.clbSndRecipients.Size = new System.Drawing.Size(203, 429);
            this.clbSndRecipients.TabIndex = 0;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtSndEmail);
            this.gbxInfo.Controls.Add(this.txtSndPhone);
            this.gbxInfo.Controls.Add(this.txtSndAddress);
            this.gbxInfo.Controls.Add(this.txtSndName);
            this.gbxInfo.Controls.Add(this.lblSndEmail);
            this.gbxInfo.Controls.Add(this.lblSndPhone);
            this.gbxInfo.Controls.Add(this.lblSndAddress);
            this.gbxInfo.Controls.Add(this.lblSndName);
            this.gbxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(6, 6);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(389, 161);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            // 
            // txtSndEmail
            // 
            this.txtSndEmail.Location = new System.Drawing.Point(73, 130);
            this.txtSndEmail.Name = "txtSndEmail";
            this.txtSndEmail.Size = new System.Drawing.Size(310, 21);
            this.txtSndEmail.TabIndex = 3;
            // 
            // txtSndPhone
            // 
            this.txtSndPhone.Location = new System.Drawing.Point(73, 93);
            this.txtSndPhone.Name = "txtSndPhone";
            this.txtSndPhone.Size = new System.Drawing.Size(310, 21);
            this.txtSndPhone.TabIndex = 2;
            // 
            // txtSndAddress
            // 
            this.txtSndAddress.Location = new System.Drawing.Point(73, 56);
            this.txtSndAddress.Name = "txtSndAddress";
            this.txtSndAddress.Size = new System.Drawing.Size(310, 21);
            this.txtSndAddress.TabIndex = 1;
            // 
            // txtSndName
            // 
            this.txtSndName.Location = new System.Drawing.Point(73, 19);
            this.txtSndName.Name = "txtSndName";
            this.txtSndName.Size = new System.Drawing.Size(310, 21);
            this.txtSndName.TabIndex = 0;
            // 
            // lblSndEmail
            // 
            this.lblSndEmail.AutoSize = true;
            this.lblSndEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndEmail.Location = new System.Drawing.Point(23, 130);
            this.lblSndEmail.Name = "lblSndEmail";
            this.lblSndEmail.Size = new System.Drawing.Size(45, 16);
            this.lblSndEmail.TabIndex = 3;
            this.lblSndEmail.Text = "Email:";
            // 
            // lblSndPhone
            // 
            this.lblSndPhone.AutoSize = true;
            this.lblSndPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndPhone.Location = new System.Drawing.Point(18, 95);
            this.lblSndPhone.Name = "lblSndPhone";
            this.lblSndPhone.Size = new System.Drawing.Size(50, 16);
            this.lblSndPhone.TabIndex = 2;
            this.lblSndPhone.Text = "Phone:";
            // 
            // lblSndAddress
            // 
            this.lblSndAddress.AutoSize = true;
            this.lblSndAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndAddress.Location = new System.Drawing.Point(6, 58);
            this.lblSndAddress.Name = "lblSndAddress";
            this.lblSndAddress.Size = new System.Drawing.Size(62, 16);
            this.lblSndAddress.TabIndex = 1;
            this.lblSndAddress.Text = "Address:";
            // 
            // lblSndName
            // 
            this.lblSndName.AutoSize = true;
            this.lblSndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSndName.Location = new System.Drawing.Point(20, 21);
            this.lblSndName.Name = "lblSndName";
            this.lblSndName.Size = new System.Drawing.Size(48, 16);
            this.lblSndName.TabIndex = 0;
            this.lblSndName.Text = "Name:";
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.panel2);
            this.tabReceive.Controls.Add(this.gbxRecMessage);
            this.tabReceive.Controls.Add(this.gbxRecRecipients);
            this.tabReceive.Controls.Add(this.groupBox3);
            this.tabReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReceive.Location = new System.Drawing.Point(4, 25);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceive.Size = new System.Drawing.Size(613, 454);
            this.tabReceive.TabIndex = 1;
            this.tabReceive.Text = "Receive (0)";
            this.tabReceive.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.lblRecStatus);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Location = new System.Drawing.Point(9, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 37);
            this.panel2.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(17, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.AutoSize = true;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(209, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblRecStatus
            // 
            this.lblRecStatus.AutoSize = true;
            this.lblRecStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecStatus.ForeColor = System.Drawing.Color.Red;
            this.lblRecStatus.Location = new System.Drawing.Point(283, 11);
            this.lblRecStatus.Name = "lblRecStatus";
            this.lblRecStatus.Size = new System.Drawing.Size(97, 16);
            this.lblRecStatus.TabIndex = 1;
            this.lblRecStatus.Text = "Not Connected";
            this.lblRecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrev.AutoSize = true;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(143, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(48, 28);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // gbxRecMessage
            // 
            this.gbxRecMessage.Controls.Add(this.txtRecMessage);
            this.gbxRecMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRecMessage.Location = new System.Drawing.Point(6, 173);
            this.gbxRecMessage.Name = "gbxRecMessage";
            this.gbxRecMessage.Size = new System.Drawing.Size(392, 231);
            this.gbxRecMessage.TabIndex = 8;
            this.gbxRecMessage.TabStop = false;
            this.gbxRecMessage.Text = "Message";
            // 
            // txtRecMessage
            // 
            this.txtRecMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecMessage.Location = new System.Drawing.Point(3, 16);
            this.txtRecMessage.Multiline = true;
            this.txtRecMessage.Name = "txtRecMessage";
            this.txtRecMessage.Size = new System.Drawing.Size(386, 212);
            this.txtRecMessage.TabIndex = 0;
            // 
            // gbxRecRecipients
            // 
            this.gbxRecRecipients.Controls.Add(this.clbRecRecipients);
            this.gbxRecRecipients.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxRecRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRecRecipients.Location = new System.Drawing.Point(401, 3);
            this.gbxRecRecipients.Name = "gbxRecRecipients";
            this.gbxRecRecipients.Size = new System.Drawing.Size(209, 448);
            this.gbxRecRecipients.TabIndex = 7;
            this.gbxRecRecipients.TabStop = false;
            this.gbxRecRecipients.Text = "Recipient(s)";
            // 
            // clbRecRecipients
            // 
            this.clbRecRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbRecRecipients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRecRecipients.FormattingEnabled = true;
            this.clbRecRecipients.Location = new System.Drawing.Point(3, 16);
            this.clbRecRecipients.Name = "clbRecRecipients";
            this.clbRecRecipients.Size = new System.Drawing.Size(203, 429);
            this.clbRecRecipients.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRecEmail);
            this.groupBox3.Controls.Add(this.txtRecPhone);
            this.groupBox3.Controls.Add(this.txtRecAddress);
            this.groupBox3.Controls.Add(this.txtRecName);
            this.groupBox3.Controls.Add(this.lblRecEmail);
            this.groupBox3.Controls.Add(this.lblRecPhone);
            this.groupBox3.Controls.Add(this.lblRecAddress);
            this.groupBox3.Controls.Add(this.lblRecName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 161);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txtRecEmail
            // 
            this.txtRecEmail.Location = new System.Drawing.Point(73, 130);
            this.txtRecEmail.Name = "txtRecEmail";
            this.txtRecEmail.Size = new System.Drawing.Size(310, 21);
            this.txtRecEmail.TabIndex = 3;
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Location = new System.Drawing.Point(73, 93);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(310, 21);
            this.txtRecPhone.TabIndex = 2;
            // 
            // txtRecAddress
            // 
            this.txtRecAddress.Location = new System.Drawing.Point(73, 56);
            this.txtRecAddress.Name = "txtRecAddress";
            this.txtRecAddress.Size = new System.Drawing.Size(310, 21);
            this.txtRecAddress.TabIndex = 1;
            // 
            // txtRecName
            // 
            this.txtRecName.Location = new System.Drawing.Point(73, 19);
            this.txtRecName.Name = "txtRecName";
            this.txtRecName.Size = new System.Drawing.Size(310, 21);
            this.txtRecName.TabIndex = 0;
            // 
            // lblRecEmail
            // 
            this.lblRecEmail.AutoSize = true;
            this.lblRecEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecEmail.Location = new System.Drawing.Point(23, 130);
            this.lblRecEmail.Name = "lblRecEmail";
            this.lblRecEmail.Size = new System.Drawing.Size(45, 16);
            this.lblRecEmail.TabIndex = 3;
            this.lblRecEmail.Text = "Email:";
            // 
            // lblRecPhone
            // 
            this.lblRecPhone.AutoSize = true;
            this.lblRecPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecPhone.Location = new System.Drawing.Point(18, 95);
            this.lblRecPhone.Name = "lblRecPhone";
            this.lblRecPhone.Size = new System.Drawing.Size(50, 16);
            this.lblRecPhone.TabIndex = 2;
            this.lblRecPhone.Text = "Phone:";
            // 
            // lblRecAddress
            // 
            this.lblRecAddress.AutoSize = true;
            this.lblRecAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecAddress.Location = new System.Drawing.Point(6, 58);
            this.lblRecAddress.Name = "lblRecAddress";
            this.lblRecAddress.Size = new System.Drawing.Size(62, 16);
            this.lblRecAddress.TabIndex = 1;
            this.lblRecAddress.Text = "Address:";
            // 
            // lblRecName
            // 
            this.lblRecName.AutoSize = true;
            this.lblRecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecName.Location = new System.Drawing.Point(20, 21);
            this.lblRecName.Name = "lblRecName";
            this.lblRecName.Size = new System.Drawing.Size(48, 16);
            this.lblRecName.TabIndex = 0;
            this.lblRecName.Text = "Name:";
            // 
            // ClientGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 483);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ClientGui";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Message Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientGui_FormClosing);
            this.Load += new System.EventHandler(this.ClientGui_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSend.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxSndMessage.ResumeLayout(false);
            this.gbxSndMessage.PerformLayout();
            this.gbxSndRecipients.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.tabReceive.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxRecMessage.ResumeLayout(false);
            this.gbxRecMessage.PerformLayout();
            this.gbxRecRecipients.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.GroupBox gbxSndMessage;
        private System.Windows.Forms.TextBox txtSndMessage;
        private System.Windows.Forms.GroupBox gbxSndRecipients;
        private System.Windows.Forms.CheckedListBox clbSndRecipients;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox txtSndEmail;
        private System.Windows.Forms.TextBox txtSndPhone;
        private System.Windows.Forms.TextBox txtSndAddress;
        private System.Windows.Forms.TextBox txtSndName;
        private System.Windows.Forms.Label lblSndEmail;
        private System.Windows.Forms.Label lblSndPhone;
        private System.Windows.Forms.Label lblSndAddress;
        private System.Windows.Forms.Label lblSndName;
        private System.Windows.Forms.TabPage tabReceive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSndStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecStatus;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox gbxRecMessage;
        private System.Windows.Forms.TextBox txtRecMessage;
        private System.Windows.Forms.GroupBox gbxRecRecipients;
        private System.Windows.Forms.CheckedListBox clbRecRecipients;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRecEmail;
        private System.Windows.Forms.TextBox txtRecPhone;
        private System.Windows.Forms.TextBox txtRecAddress;
        private System.Windows.Forms.TextBox txtRecName;
        private System.Windows.Forms.Label lblRecEmail;
        private System.Windows.Forms.Label lblRecPhone;
        private System.Windows.Forms.Label lblRecAddress;
        private System.Windows.Forms.Label lblRecName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
    }
}

