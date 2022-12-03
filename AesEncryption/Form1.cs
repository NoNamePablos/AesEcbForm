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

        private void buttonEnccrypt_Click(object sender, EventArgs e)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;
            string logger = "";
            long keyFromTextSize = textBoxKey.Text.Length;
            long sourceTextEnter = richTextBoxTextEnter.Text.Length;
            keyByte = new byte[(int)keyFromTextSize];

            keyByte = encoding.GetBytes(textBoxKey.Text);

            messageByte = new byte[(int)sourceTextEnter];
            messageByte = encoding.GetBytes(richTextBoxTextEnter.Text);
            if (messageByte != null && keyByte != null && checkKeySizeGlobal(textBoxKey.Text))
            {

                var chiperByte = Aes.encrypt(messageByte, keyByte, ref logger);
                richTextBoxInition.Text = logger;
                BinaryWriter chiperStream = new BinaryWriter(File.Open("3.txt", FileMode.Create),Encoding.UTF8);
                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxTextClose.Text = encoding.GetString(chiperByte);
                myDecoder s = new myDecoder(encoding.GetString(chiperByte), encoding.GetString(chiperByte));
                lst.Add(s);



                MessageBox.Show("Файл был успешно зашифрован");


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
            keyByte = new byte[(int)keyFromTextSize];

            keyByte = encoding.GetBytes(textBoxKey.Text);


            messageByte = new byte[(int)sourceTextEnter];
            messageByte = encoding.GetBytes(richTextBoxTextEnter.Text);
            if (messageByte != null && keyByte != null&& checkKeySizeGlobal(textBoxKey.Text))
            {

                var chiperByte = Aes.decrypt(messageByte, keyByte, ref log);
                BinaryWriter chiperStream = new BinaryWriter(File.Open("decrypt.txt", FileMode.Create));

                chiperStream.Write(chiperByte);
                chiperStream.Close();
                richTextBoxInition.Text = log;
                richTextBoxTextClose.Text = encoding.GetString(chiperByte);
                //richTextBoxTextClose.Text = chiperByte.ToString();
                MessageBox.Show("Файл был успешно расшифрован");
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
            string text = File.ReadAllText(FName);
            richTextBoxTextEnter.Text = File.ReadAllText(FName, Encoding.UTF8);
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

        private void загрузитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FName = getFilename(); // пользователь выбирает файл
            if (FName == null) return; // если файл не выбран
            string text = File.ReadAllText(FName,Encoding.UTF8);
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
