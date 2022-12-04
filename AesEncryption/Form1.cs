using AesEncryption.Core;
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
        public Logger logger = new Logger();
        public static string sourceKey, sourceText, sourceDecryptText;
        public static bool isLoadFirst = false;
        List<myDecoder> lst=new List<myDecoder>();
        private Encoding encoding = Encoding.GetEncoding(1251);
        public AesEncryption()
        {
            InitializeComponent();
            comboBoxSizeKey.Items.Add("128");
            comboBoxSizeKey.Items.Add("192");
            comboBoxSizeKey.Items.Add("256");

        }
        public static Encoding DetectEncoding(String fileName, out String contents)
        {
            // open the file with the stream-reader:
            using (StreamReader reader = new StreamReader(fileName, true))
            {
                // read the contents of the file into a string
                contents = reader.ReadToEnd();

                // return the encoding.
                return reader.CurrentEncoding;
            }
        }
        private void buttonEnccrypt_Click(object sender, EventArgs e)
        {
            //FileInfo fileKey = new FileInfo("key-192.txt");
            //FileInfo fileMessage = new FileInfo("2.txt");
            Random d = new Random();
            string path = "decr" + d.Next(1, 10000).ToString() + ".txt";
            BinaryWriter chiperStream = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8);


            byte[] messageByte = null;
            byte[] keyByte = null;
            string logger = "";
            long keyFromTextSize = textBoxKey.Text.Length;
            long sourceTextEnter = richTextBoxTextEnter.Text.Length;

            saveFile("binaryKey_key.txt", textBoxKey.Text);



            FileInfo fileKey = new FileInfo("binaryKey_key.txt");
            BinaryReader keyStream = new BinaryReader(File.Open("binaryKey_key.txt", FileMode.Open));
            keyByte = new byte[(int)fileKey.Length];
            keyStream.Read(keyByte, 0, (int)fileKey.Length);
            keyStream.Close();


            Random d1 = new Random();
            string path1 = "binaryKey" + d.Next(1, 10000).ToString() + ".txt";
            if (sourceText != null) { 
                File.Copy(sourceText, path1);
            }

            saveFile(path1, richTextBoxTextEnter.Text);




            //File.WriteAllBytes(path1,Encoding.Default.GetBytes(richTextBoxTextEnter.Text));
            FileInfo fileMessage = new FileInfo(path1);
            BinaryReader messageStream = new BinaryReader(File.Open(path1, FileMode.Open));
            messageByte = new byte[(int)fileMessage.Length];
            messageStream.Read(messageByte, 0, (int)fileMessage.Length);

            if (messageByte != null && keyByte != null && checkKeySizeGlobal(textBoxKey.Text))
            {

                var chiperByte = Aes.encrypt(messageByte, keyByte);
                //richTextBoxInition.Text = logger;
                //BinaryWriter chiperStream = new BinaryWriter(File.Open("3.txt", FileMode.Create),Encoding.Unicode);
                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxTextClose.Text = Encoding.Unicode.GetString(chiperByte);
                //myDecoder s = new myDecoder(encoding.GetString(chiperByte), encoding.GetString(chiperByte));
                //lst.Add(s);



                MessageBox.Show("Файл успешно сохранен " + path, "Успешно");
                messageStream.Close();


            }
            else {
                MessageBox.Show("Неверные параметры или ключ неверной длины!");
            
            }


        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;
            string log = "";
            long keyFromTextSize = textBoxKey.Text.Length;
            long sourceTextEnter = richTextBoxTextEnter.Text.Length;

            //FileInfo fileKey = new FileInfo("key-192.txt");
            //FileInfo fileMessage = new FileInfo("decr.txt");
            Random d = new Random();
            string path = "encr" + d.Next(1, 10000).ToString() + ".txt";
            BinaryWriter chiperStream = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8);

            //BinaryWriter chiperStream12 = new BinaryWriter(File.Open("binaryKey_key.txt", FileMode.Create), Encoding.UTF8);
            //chiperStream12.Write(textBoxKey.Text);
            //chiperStream12.Close();

            saveFile("binaryKey_key.txt", textBoxKey.Text);



            FileInfo fileKey = new FileInfo("binaryKey_key.txt");
            BinaryReader keyStream = new BinaryReader(File.Open("binaryKey_key.txt", FileMode.Open));
            keyByte = new byte[(int)fileKey.Length];
            keyStream.Read(keyByte, 0, (int)fileKey.Length);
            keyStream.Close();


            //BinaryWriter chiperStream1 = new BinaryWriter(File.Open("binaryKey.txt", FileMode.Create),Encoding.UTF8);
            //chiperStream1.Write(richTextBoxTextEnter.Text);
            //chiperStream1.Close();

            Random d1 = new Random();
            string path1 = "binaryKey" + d.Next(1, 10000).ToString() + ".txt";


            //string str = "";
            //Encoding dct=DetectEncoding(sourceDecryptText,out str);

            //File.Copy(sourceDecryptText, path1);

            //saveFile(path1, richTextBoxTextEnter.Text);

            //File.WriteAllBytes(path1,Encoding.Default.GetBytes(richTextBoxTextEnter.Text));
            FileInfo fileMessage = new FileInfo(sourceDecryptText);
            BinaryReader messageStream = new BinaryReader(File.Open(sourceDecryptText, FileMode.Open));
            messageByte = new byte[(int)fileMessage.Length];
            messageStream.Read(messageByte, 0, (int)fileMessage.Length);
            //messageStream.Close();
            //messageByte = Encoding.Unicode.GetBytes(richTextBoxTextEnter.Text);
            
            
            if (messageByte != null && keyByte != null&& checkKeySizeGlobal(textBoxKey.Text))
            {

                var chiperByte = Aes.decrypt(messageByte, keyByte);
                //BinaryWriter chiperStream = new BinaryWriter(File.Open("decrypt.txt", FileMode.Create),Encoding.Unicode);

                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxInition.Text = log;
                richTextBoxTextClose.Text = encoding.GetString(chiperByte);

                //richTextBoxTextClose.Text = chiperByte.ToString();
                MessageBox.Show("Файл успешно сохранен "+path,"Успешно");
                messageStream.Close();
            }
            else
            {
                MessageBox.Show("Неверные параметры или ключ неверной длины!");

            }
        }
        private static bool checkKeySize(int length, int size) {

            if (length * 8 == size){
                return true;
            }
            return false;


        }
        private static bool saveFile(string text) {


            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return false ;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, text,Encoding.UTF8);
            return true;
        }
        private static bool saveFile(string path,string text)
        {


            string filename = path;
            File.WriteAllText(filename, text);
            return true;
        }

        private static bool saveFile(string path, string text,Encoding enc)
        {


            string filename = path;
            File.WriteAllText(filename, text, enc);
            return true;
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
        private static bool checkKeySizeGlobal(string key)
        {
            if (checkKeySize(key.Length, 128))
            {
                return true;
            }
            else if (checkKeySize(key.Length, 192))
            {
                return true;

            }
            else if (checkKeySize(key.Length, 256))
            {
                return true;

            }
            return false;
        }

        private void загрузитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName);
            textBoxKey.Text = text;
            if (checkKeySize(text.Length, 128))
            {
                comboBoxSizeKey.SelectedIndex = 0;
            }
            else if (checkKeySize(text.Length, 192))
            {
                comboBoxSizeKey.SelectedIndex = 1;
            }
            else if (checkKeySize(text.Length, 256))
            {
                comboBoxSizeKey.SelectedIndex = 2;
            }
            else {
                MessageBox.Show("Ключ неверной длины!");
            
            }


        }

        private void загрузитьЗашифрованныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран

            byte[] text = File.ReadAllBytes(FName);
            richTextBoxTextEnter.Text = Encoding.Unicode.GetString(text);
            sourceDecryptText = FName;
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            //if (!isLoadFirst) {
            //    if(sourceKey!=null)
            //        File.WriteAllText("key1.txt", textBoxKey.Text);
            //}
            //isLoadFirst = false;

        }

        private void сохранитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(textBoxKey.Text);
        }

        private void сохранитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(richTextBoxTextEnter.Text);

        }

        private void сохранитьВыводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(richTextBoxTextClose.Text);
        }

        private void richTextBoxTextEnter_TextChanged(object sender, EventArgs e)
        {
            //BinaryWriter chiperStream = new BinaryWriter(File.Open("binary_tempfile.txt", FileMode.Create), Encoding.UTF8);
            //chiperStream.Write(richTextBoxTextEnter.Text);
            //chiperStream.Close(
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
            if (checkKeySize(text.Length, 128))
            {
                comboBoxSizeKey.SelectedIndex = 0;
            }
            else if (checkKeySize(text.Length, 192))
            {
                comboBoxSizeKey.SelectedIndex = 1;
            }
            else if (checkKeySize(text.Length, 256))
            {
                comboBoxSizeKey.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Ключ неверной длины!");

            }

        }
    }
}
