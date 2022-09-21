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

        private void EncodingMenuButton_Click(object sender, EventArgs e)
        {
            EncodingPanel.SendToBack();
            AlgoritmCodeBox.StartIndex = 0;
            ActionEncodingBox.StartIndex = 0;
            GetTextEncodingTextBox.Text = string.Empty;
            ResultEncodingTextBox.Text = string.Empty;
        }

        private void AESMenuButton_Click(object sender, EventArgs e)
        {
            AESPanel.SendToBack();
        }

        private void HashingMenuButton_Click(object sender, EventArgs e)
        {
            HashingPanel.SendToBack();
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

                        EncodeTextBytes = Encoding.UTF8.GetBytes(GetTextEncodingTextBox.Text);
                        ResultEncodingTextBox.Text = Convert.ToBase64String(EncodeTextBytes);

                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {


                        EncodeTextBytes = Convert.FromBase64String(GetTextEncodingTextBox.Text);
                        ResultEncodingTextBox.Text = Encoding.UTF8.GetString(EncodeTextBytes);
                    }
                }
                else if (AlgoritmCodeBox.Text == "UrlEncode")
                {
                    if (ActionEncodingBox.Text == "Encode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlEncode(GetTextEncodingTextBox.Text);
                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlDecode(GetTextEncodingTextBox.Text);
                    }

                }
                else if (AlgoritmCodeBox.Text == "HtmlEncode")
                {

                    if (ActionEncodingBox.Text == "Encode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlEncode(GetTextEncodingTextBox.Text);


                    }
                    else if (ActionEncodingBox.Text == "Decode")
                    {
                        ResultEncodingTextBox.Text = WebUtility.UrlDecode(GetTextEncodingTextBox.Text);

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
    }
}
