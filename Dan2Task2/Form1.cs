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

            if(AlgoritmCodeBox.Text== "Base64")
            {
                if(ActionBox.Text == "Encode")
                {
                    EncodeTextBytes = Encoding.UTF8.GetBytes(GetTextEncodingTextBox.Text);
                    ResultEncodingTextBox.Text = Convert.ToBase64String(EncodeTextBytes);

                }
                else if(ActionBox.Text == "Decode")
                {
                    EncodeTextBytes = Convert.FromBase64String(GetTextEncodingTextBox.Text);
                    ResultEncodingTextBox.Text = Encoding.UTF8.GetString(EncodeTextBytes);
                }
            }
            else if (AlgoritmCodeBox.Text == "UrlEncode")
            {
                if (ActionBox.Text == "Encode")
                {
                

                }
                else if (ActionBox.Text == "Decode")
                {
                    
                }

            }
            else if (AlgoritmCodeBox.Text == "HtmlEncode")
            {

                if (ActionBox.Text == "Encode")
                {
                    

                }
                else if (ActionBox.Text == "Decode")
                {
                    
                }
            }
        }
    }
}
