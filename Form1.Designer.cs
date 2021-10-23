
namespace cs_form_net_binary {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.read_button = new System.Windows.Forms.Button();
            this.download_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(45, 94);
            this.read_button.Margin = new System.Windows.Forms.Padding(4);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(255, 39);
            this.read_button.TabIndex = 0;
            this.read_button.Text = "WEB より読み込み";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(329, 94);
            this.download_button.Margin = new System.Windows.Forms.Padding(4);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(255, 39);
            this.download_button.TabIndex = 2;
            this.download_button.Text = "ダウンロード";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(45, 171);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(794, 392);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(45, 44);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(793, 23);
            this.textUrl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 600);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.read_button);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "画像ファイルを WEB より読込む";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textUrl;
    }
}

