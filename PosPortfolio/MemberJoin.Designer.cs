namespace PosPortfolio
{
    partial class MemberJoin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAdminPw = new System.Windows.Forms.GroupBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJoinList = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpAdminPw.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grpAdminPw);
            this.panel1.Controls.Add(this.btnJoinList);
            this.panel1.Controls.Add(this.btnJoin);
            this.panel1.Controls.Add(this.txtPw);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 218);
            this.panel1.TabIndex = 0;
            // 
            // grpAdminPw
            // 
            this.grpAdminPw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpAdminPw.Controls.Add(this.lblCancel);
            this.grpAdminPw.Controls.Add(this.btnConfirm);
            this.grpAdminPw.Controls.Add(this.label5);
            this.grpAdminPw.Controls.Add(this.txtAdminPw);
            this.grpAdminPw.Controls.Add(this.label4);
            this.grpAdminPw.Location = new System.Drawing.Point(4, 18);
            this.grpAdminPw.Name = "grpAdminPw";
            this.grpAdminPw.Size = new System.Drawing.Size(396, 171);
            this.grpAdminPw.TabIndex = 8;
            this.grpAdminPw.TabStop = false;
            this.grpAdminPw.Text = "비번: 2580";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCancel.Location = new System.Drawing.Point(364, 16);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(26, 24);
            this.lblCancel.TabIndex = 7;
            this.lblCancel.Text = "X";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(123, 118);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(267, 45);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "관리자 비밀번호는 2580입니다.";
            // 
            // txtAdminPw
            // 
            this.txtAdminPw.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAdminPw.Location = new System.Drawing.Point(123, 79);
            this.txtAdminPw.Name = "txtAdminPw";
            this.txtAdminPw.Size = new System.Drawing.Size(267, 33);
            this.txtAdminPw.TabIndex = 5;
            this.txtAdminPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminPw_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "비밀번호";
            // 
            // btnJoinList
            // 
            this.btnJoinList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnJoinList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJoinList.ForeColor = System.Drawing.Color.Black;
            this.btnJoinList.Location = new System.Drawing.Point(32, 158);
            this.btnJoinList.Name = "btnJoinList";
            this.btnJoinList.Size = new System.Drawing.Size(346, 51);
            this.btnJoinList.TabIndex = 4;
            this.btnJoinList.Text = "회원정보 보기";
            this.btnJoinList.UseVisualStyleBackColor = false;
            this.btnJoinList.Click += new System.EventHandler(this.btnJoinList_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Location = new System.Drawing.Point(32, 101);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(346, 51);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPw.Location = new System.Drawing.Point(159, 58);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(219, 35);
            this.txtPw.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtId.Location = new System.Drawing.Point(159, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 35);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // MemberJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 242);
            this.Controls.Add(this.panel1);
            this.Name = "MemberJoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberJoin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpAdminPw.ResumeLayout(false);
            this.grpAdminPw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoinList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminPw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.GroupBox grpAdminPw;
    }
}