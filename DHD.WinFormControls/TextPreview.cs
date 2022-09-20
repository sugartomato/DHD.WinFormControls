using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHD.WinFormControls
{
    public partial class TextPreview : Form
    {
        public TextPreview()
        {
            InitializeComponent();
            
        }
        private void TextPreview_Load(object sender, EventArgs e)
        {
            txtMain.Text = PreviewText;
            txtMain.SelectionStart = 0;
            chkWarp.Checked = false;
            chkEdit.Checked = false;
            chkTopShow.Checked = true;
            txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        }

        private void OnClick_CopyAll(object sender, EventArgs e)
        {
            txtMain.SelectAll();
            txtMain.Copy();
            lblStatus.Text = "内容已复制到剪贴板！";
        }
        private void OnClick_Close(object sender, EventArgs e)
        {
            this.Close();
        }


        private void chkWarp_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.WordWrap = chkWarp.Checked;
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.ReadOnly = !chkEdit.Checked;
        }

        private void chkTopShow_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopShow.Checked;
        }

        #region 数据接口

        /// <summary>
        /// 需要预览显示的数据
        /// </summary>
        public String PreviewText { get; set; } = String.Empty;


        #endregion


    }
}
