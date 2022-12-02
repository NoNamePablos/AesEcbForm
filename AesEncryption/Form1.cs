using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AesEncryption
{
    public partial class AesEncryption : Form
    {
        public Logger logger=new Logger();
        public static string sourceKey,sourceText, sourceDecryptText;
        public static bool isLoadFirst = false;
        public AesEncryption()
        {
            InitializeComponent();
            comboBoxSizeKey.Items.Add("128");
            comboBoxSizeKey.Items.Add("192");
            comboBoxSizeKey.Items.Add("256");
           
        }

        private void buttonEnccrypt_Click(object sender, EventArgs e)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;

            FileInfo fileKey = new FileInfo(sourceKey);
            FileInfo fileMessage = new FileInfo(sourceText);
            BinaryWriter chiperStream = new BinaryWriter(File.Open("3.txt", FileMode.Create));

            BinaryReader keyStream = new BinaryReader(File.Open(sourceKey, FileMode.Open));
            keyByte = new byte[(int)fileKey.Length];
            keyStream.Read(keyByte, 0, (int)fileKey.Length);

            BinaryReader messageStream = new BinaryReader(File.Open(sourceText, FileMode.Open));
            messageByte = new byte[(int)fileMessage.Length];
            messageStream.Read(messageByte, 0, (int)fileMessage.Length);
            if (messageByte != null && keyByte != null)
            {

                var chiperByte = Aes.encrypt(messageByte, keyByte);
                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxTextClose.Text = File.ReadAllText("3.txt", Encoding.Default);
                
                //richTextBoxTextClose.Text = chiperByte.ToString();
                MessageBox.Show("Файл был успешно зашифрован");
               

            }


        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;

            FileInfo fileKey = new FileInfo("key1.txt");
            FileInfo fileMessage = new FileInfo(sourceDecryptText);
            BinaryWriter chiperStream = new BinaryWriter(File.Open("decrypt.txt", FileMode.Create));

            BinaryReader keyStream = new BinaryReader(File.Open("key1.txt", FileMode.Open));
            keyByte = new byte[(int)fileKey.Length];
            keyStream.Read(keyByte, 0, (int)fileKey.Length);

            BinaryReader messageStream = new BinaryReader(File.Open(sourceDecryptText, FileMode.Open));
            messageByte = new byte[(int)fileMessage.Length];
            messageStream.Read(messageByte, 0, (int)fileMessage.Length);
            if (messageByte != null && keyByte != null)
            {

                var chiperByte = Aes.decrypt(messageByte, keyByte);
                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxTextClose.Text = File.ReadAllText("decrypt.txt", Encoding.Default);
                //richTextBoxTextClose.Text = chiperByte.ToString();
                MessageBox.Show("Файл был успешно расшифрован");


            }
        }

        private static string getFilename()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt";
            dlg.Multiselect = false;
            dlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.FileName;
            
            return null;
        }


        private void загрузитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName);
            textBoxKey.Text = text;
            sourceKey = FName;
            isLoadFirst = true;

        }

        private void загрузитьЗашифрованныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName);
            richTextBoxTextEnter.Text = File.ReadAllText(FName, Encoding.Default);
            sourceDecryptText = FName;
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadFirst) {
                if(sourceKey!=null)
                    File.WriteAllText("key1.txt", textBoxKey.Text);
            }
            isLoadFirst = false;

        }

        private void загрузитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName);
            richTextBoxTextEnter.Text = text;
            sourceText = FName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName);
            textBoxKey.Text = text;
            sourceKey = FName;

        }
    }
}
