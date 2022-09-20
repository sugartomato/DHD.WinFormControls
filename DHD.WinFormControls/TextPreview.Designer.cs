namespace DHD.WinFormControls
{
    partial class TextPreview
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
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.chkWarp = new System.Windows.Forms.CheckBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkTopShow = new System.Windows.Forms.CheckBox();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.Location = new System.Drawing.Point(12, 12);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.Size = new System.Drawing.Size(754, 398);
            this.txtMain.TabIndex = 0;
            this.txtMain.WordWrap = false;
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyAll.Location = new System.Drawing.Point(12, 435);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(125, 69);
            this.btnCopyAll.TabIndex = 1;
            this.btnCopyAll.Text = "复制全部(&A)";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.OnClick_CopyAll);
            // 
            // chkWarp
            // 
            this.chkWarp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkWarp.AutoSize = true;
            this.chkWarp.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWarp.Location = new System.Drawing.Point(159, 452);
            this.chkWarp.Name = "chkWarp";
            this.chkWarp.Size = new System.Drawing.Size(90, 30);
            this.chkWarp.TabIndex = 2;
            this.chkWarp.Text = "换行";
            this.chkWarp.UseVisualStyleBackColor = true;
            this.chkWarp.CheckedChanged += new System.EventHandler(this.chkWarp_CheckedChanged);
            // 
            // chkEdit
            // 
            this.chkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEdit.AutoSize = true;
            this.chkEdit.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkEdit.Location = new System.Drawing.Point(255, 452);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(90, 30);
            this.chkEdit.TabIndex = 3;
            this.chkEdit.Text = "编辑";
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 513);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(778, 31);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "就绪";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 24);
            this.lblStatus.Text = "就绪";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(641, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 69);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClick_Close);
            // 
            // chkTopShow
            // 
            this.chkTopShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopShow.AutoSize = true;
            this.chkTopShow.Checked = true;
            this.chkTopShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopShow.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkTopShow.Location = new System.Drawing.Point(351, 452);
            this.chkTopShow.Name = "chkTopShow";
            this.chkTopShow.Size = new System.Drawing.Size(142, 30);
            this.chkTopShow.TabIndex = 6;
            this.chkTopShow.Text = "顶端显示";
            this.chkTopShow.UseVisualStyleBackColor = true;
            this.chkTopShow.CheckedChanged += new System.EventHandler(this.chkTopShow_CheckedChanged);
            // 
            // TextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.chkTopShow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.chkWarp);
            this.Controls.Add(this.btnCopyAll);
            this.Controls.Add(this.txtMain);
            this.Name = "TextPreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内容预览";
            this.Load += new System.EventHandler(this.TextPreview_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.CheckBox chkWarp;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkTopShow;
    }
}