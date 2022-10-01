using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Security.Cryptography;

namespace Dan2Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TimerDateTimeNow.Start();


            this.Width -= 17;
            PanelBody.AutoScroll = false;

            foreach (var panel in PanelBody.Controls.OfType<Guna2Panel>())
            {
                panel.Height = PanelBody.Height;
            }

            
        }

        public static string Encrypt(string text, byte[] key, byte[] iv, int keysize = 128, int blocksize = 128, CipherMode cipher = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {


            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = blocksize;
            aes.KeySize = keysize;
            aes.Mode = cipher;
            aes.Padding = padding;

            byte[] src = Encoding.UTF8.GetBytes(text);
            using (ICryptoTransform encrypt = aes.CreateEncryptor(key, iv))
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                encrypt.Dispose();
                return Convert.ToBase64String(dest);
            }

        }

        public static string Decrypt(string text, byte[] key, byte[] iv, int keysize = 128, int blocksize = 128, CipherMode cipher = CipherMode.CBC, PaddingMode padding = PaddingMode.PKCS7)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = blocksize;
            aes.KeySize = keysize;
            aes.Mode = cipher;
            aes.Padding = padding;

            byte[] src = Convert.FromBase64String(text);
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, iv))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }

        private void EncodingMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                EncodingPanel.SendToBack();
                AlgoritmCodeBox.StartIndex = 0;
                ActionEncodingBox.StartIndex = 0;
                GetTextEncodingTextBox.Text = string.Empty;
                ResultEncodingTextBox.Text = string.Empty;
            }
            catch { }
        }

        private void AESMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                AESPanel.SendToBack();
                ActionAesBox.StartIndex = 0;
                SizeKeyAesBox.StartIndex = 0;
                AlgoritmAesBox.StartIndex = 0;
                KeyAesTextBox.Text = string.Empty;
                GetTextAESTextBox.Text = string.Empty;
                ResultAESTextBox.Text = string.Empty;
            }
            catch { }
        }

        private void HashingMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                HashingPanel.SendToBack();
                GetTextHashingTextBox.Text = string.Empty;
                ResultHashingTextBox.Text = string.Empty;
            }
            catch { }
        }

        private void EncodingGetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetTextEncodingTextBox.Text = Clipboard.GetText();
            }
            catch { }
            
        }

        private void EncodingSetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ResultEncodingTextBox.Text);
            }
            catch { }
           
        }

        private void TimerDateTimeNow_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTimeNowLabel.Text = now.ToLongTimeString();
        }

        private void AESGetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetTextAESTextBox.Text = Clipboard.GetText();
            }
            catch { }
        }

        private void AESSetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ResultAESTextBox.Text);
            }
            catch { }
        }

        private void HashingGetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetTextHashingTextBox.Text = Clipboard.GetText();
            }
            catch { }
        }

        private void HashingSetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ResultHashingTextBox.Text);
            }
            catch { }
        }

        private void GoEncodingButton_Click(object sender, EventArgs e)
        {
            byte[] EncodeTextBytes;

            try
            {
                if (AlgoritmCodeBox.Text == "Base64")
                {
                    if (ActionEncodingBox.Text == "Encode")
                    {

                        EncodeTextBytes = Encoding.UTF8.GetBytes(GetTextEncodingTextBox.Text);     //переводим строку в байты 
                        ResultEncodingTextBox.Text = Convert.ToBase64String(EncodeTextBytes);     //шифруем байтвую строку в Base64 и выводим 

                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {


                        EncodeTextBytes = Convert.FromBase64String(GetTextEncodingTextBox.Text);  //расшифровуем с Base64 в строку и помещаем в переменную байт 
                        ResultEncodingTextBox.Text = Encoding.UTF8.GetString(EncodeTextBytes);   //с переменной байт переводим в строку и выводим
                    }
                }
                else if (AlgoritmCodeBox.Text == "UrlEncode")
                {
                    if (ActionEncodingBox.Text == "Encode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlEncode(GetTextEncodingTextBox.Text);
                        //зашифровуем текст в UrlEncode с входной строки и выводим 
                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlDecode(GetTextEncodingTextBox.Text);
                        //расшифровуем тест с UrlEncode и выводим
                    }

                }
                else if (AlgoritmCodeBox.Text == "HtmlEncode")
                {

                    if (ActionEncodingBox.Text == "Encode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlEncode(GetTextEncodingTextBox.Text);
                        //зашифровуем текст в HtmlEncode с входной строки и выводим 



                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlDecode(GetTextEncodingTextBox.Text);
                        //расшифровуем тест с HtmlEncode и выводим


                    }
                }
            }
            catch { }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ActionAesBox.Text == "Encode")
            {
                GoAesButton.Text = "Encoding";
            }
            else if(ActionAesBox.Text == "Decode")
            {
                GoAesButton.Text = "Decoding";
            }
        }

        private void ActionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ActionEncodingBox.Text == "Encode")
            {
                GoEncodingButton.Text = "Encoding";
            }
            else if(ActionEncodingBox.Text == "Decode")
            {
                GoEncodingButton.Text = "Decoding";
            }
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private void GoHashingButton_Click(object sender, EventArgs e)
        {
            string text = GetTextHashingTextBox.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hashMD5 = new MD5CryptoServiceProvider().ComputeHash(bytes);
            byte[] hashSha_1 = new SHA1CryptoServiceProvider().ComputeHash(bytes);
            byte[] hashSha_256 = new SHA256CryptoServiceProvider().ComputeHash(bytes);
            byte[] hashSha_384 = new SHA384CryptoServiceProvider().ComputeHash(bytes);
            byte[] hashSha_512 = new SHA512CryptoServiceProvider().ComputeHash(bytes);


            ResultHashingTextBox.Text = $"MD5 : {ByteArrayToString(hashMD5)} \r\nsha-1 : {ByteArrayToString(hashSha_1)} \r\nsha-256 : {ByteArrayToString(hashSha_256)} " +
                $"\r\nsha-384 : {ByteArrayToString(hashSha_384)} \r\nsha-512 : {ByteArrayToString(hashSha_512)}" ;

        }

        private void GoAesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = GetTextAESTextBox.Text;                             //в переменную текст помещаем тест введеный пользователем 
                byte[] key = Convert.FromBase64String(KeyAesTextBox.Text);        // в переменную кей помещаем сгенерировавшийся ключ с текст бокса 

                int keysize = 128;       //указываем длину ключа 
                int blocksize = 128;      //указываем длину блока 

                CipherMode cipher = CipherMode.CBC;          //указываем алгоритм шифрования 
                PaddingMode padding = PaddingMode.PKCS7;     //не знаю что это но указать нужно 

                if (SizeKeyAesBox.Text == "128")
                {
                    keysize = 128;
                    blocksize = 128;
                }

                if (AlgoritmAesBox.Text == "AES-ECB")
                {
                    cipher = CipherMode.ECB;
                }
                else if (AlgoritmAesBox.Text == "AES-CBC")
                {
                    cipher = CipherMode.CBC;
                }


                if (ActionAesBox.Text == "Encode")
                {
                    ResultAESTextBox.Text = Encrypt(text, key, key, keysize, blocksize, cipher, padding).ToString(); //вызываем метод по шифровке и помещаем результат в текст бокс 
                }
                else if (ActionAesBox.Text == "Decode")
                {
                    ResultAESTextBox.Text = Decrypt(text, key, key, keysize, blocksize, cipher, padding).ToString(); //вызываем метод по дешифровке и помещаем результат в текст бокс 
                }
            }
            catch { }
        }

        private void GenerationKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = new byte[128 / 8];       //создаем переменную ключ дленой 128\8

                new Random().NextBytes(key);       //заполняем ее рандомными символами 

                KeyAesTextBox.Text = Convert.ToBase64String(key); // вывводм получившийся ключ в текст бокс
            }
            catch { }
           

        }
    }
}
