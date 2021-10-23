using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace cs_form_net_binary {

    public partial class Form1 : Form {

        public Form1()
        {
            InitializeComponent();
            this.textUrl.Text = "http://lightbox.on.coocan.jp/html/g/s800/2021-08-03-1.jpg";
        }

        private void read_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.pictureBox.ImageLocation = this.textUrl.Text;

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }

        private void write_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "image.jpg";
            sfd.Filter = "すべてのファイル|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                try
                {
                    Byte[] data  = webClient.DownloadData( this.textUrl.Text );
                    FileStream fs = new FileStream(
                        sfd.FileName,                         
                        System.IO.FileMode.Create,
                        System.IO.FileAccess.Write);
                    //バイト型配列の内容をすべて書き込む
                    fs.Write(data, 0, data.Length);
                    //閉じる
                    fs.Close();
                    MessageBox.Show(this, "ダウンロードが完了しました");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show(this, "ダウンロードが失敗しました");
                }

            }

        }
    }
}
