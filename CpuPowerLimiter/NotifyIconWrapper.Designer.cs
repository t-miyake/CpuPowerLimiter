namespace CpuPowerLimiter
{
    partial class NotifyIconWrapper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Set100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set90 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set80 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set70 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set60 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Set50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CPU Power Limiter";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Set100,
            this.toolStripMenuItem_Set90,
            this.toolStripMenuItem_Set80,
            this.toolStripMenuItem_Set70,
            this.toolStripMenuItem_Set60,
            this.toolStripMenuItem_Set50,
            this.toolStripSeparator,
            this.toolStripMenuItem_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 178);
            // 
            // toolStripMenuItem_Set100
            // 
            this.toolStripMenuItem_Set100.Name = "toolStripMenuItem_Set100";
            this.toolStripMenuItem_Set100.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set100.Text = "100% (Default)";
            // 
            // toolStripMenuItem_Set90
            // 
            this.toolStripMenuItem_Set90.Name = "toolStripMenuItem_Set90";
            this.toolStripMenuItem_Set90.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set90.Text = "90%";
            // 
            // toolStripMenuItem_Set80
            // 
            this.toolStripMenuItem_Set80.Name = "toolStripMenuItem_Set80";
            this.toolStripMenuItem_Set80.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set80.Text = "80%";
            // 
            // toolStripMenuItem_Set70
            // 
            this.toolStripMenuItem_Set70.Name = "toolStripMenuItem_Set70";
            this.toolStripMenuItem_Set70.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set70.Text = "70%";
            // 
            // toolStripMenuItem_Set60
            // 
            this.toolStripMenuItem_Set60.Name = "toolStripMenuItem_Set60";
            this.toolStripMenuItem_Set60.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set60.Text = "60%";
            // 
            // toolStripMenuItem_Set50
            // 
            this.toolStripMenuItem_Set50.Name = "toolStripMenuItem_Set50";
            this.toolStripMenuItem_Set50.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Set50.Text = "50%";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(174, 6);
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_Exit.Text = "Exit";
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set90;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set80;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set70;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set60;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Set50;
    }
}
