﻿namespace 图灵聊天机器人
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ChatBox = new System.Windows.Forms.RichTextBox();
            this.txt_MessageBox = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(83, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(349, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_ChatBox
            // 
            this.txt_ChatBox.Location = new System.Drawing.Point(12, 36);
            this.txt_ChatBox.Name = "txt_ChatBox";
            this.txt_ChatBox.ReadOnly = true;
            this.txt_ChatBox.Size = new System.Drawing.Size(595, 390);
            this.txt_ChatBox.TabIndex = 2;
            this.txt_ChatBox.Text = "";
            // 
            // txt_MessageBox
            // 
            this.txt_MessageBox.Location = new System.Drawing.Point(12, 432);
            this.txt_MessageBox.Multiline = true;
            this.txt_MessageBox.Name = "txt_MessageBox";
            this.txt_MessageBox.Size = new System.Drawing.Size(540, 49);
            this.txt_MessageBox.TabIndex = 0;
            this.txt_MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MessageBox_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(559, 433);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(50, 48);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(485, 9);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(122, 21);
            this.txt_City.TabIndex = 5;
            this.txt_City.Text = "北京";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "城市：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_MessageBox);
            this.Controls.Add(this.txt_ChatBox);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "图灵聊天机器人";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.RichTextBox txt_ChatBox;
        private System.Windows.Forms.TextBox txt_MessageBox;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label label2;
    }
}

