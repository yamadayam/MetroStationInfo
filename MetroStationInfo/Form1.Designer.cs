namespace MetroStationInfo
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btStationInfo = new System.Windows.Forms.Button();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 438);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(659, 232);
            this.listBox1.TabIndex = 0;
            // 
            // btStationInfo
            // 
            this.btStationInfo.Location = new System.Drawing.Point(694, 12);
            this.btStationInfo.Name = "btStationInfo";
            this.btStationInfo.Size = new System.Drawing.Size(118, 63);
            this.btStationInfo.TabIndex = 1;
            this.btStationInfo.Text = "駅情報取得";
            this.btStationInfo.UseVisualStyleBackColor = true;
            this.btStationInfo.Click += new System.EventHandler(this.btStationInfo_Click);
            // 
            // tbJson
            // 
            this.tbJson.Location = new System.Drawing.Point(12, 12);
            this.tbJson.Multiline = true;
            this.tbJson.Name = "tbJson";
            this.tbJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJson.Size = new System.Drawing.Size(659, 420);
            this.tbJson.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 675);
            this.Controls.Add(this.tbJson);
            this.Controls.Add(this.btStationInfo);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btStationInfo;
        private System.Windows.Forms.TextBox tbJson;
    }
}

