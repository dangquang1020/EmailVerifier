using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using Codicode;

namespace EmailVerifier
{
    public partial class EmailVerifier : Form
    {
        public EmailVerifier()
        {
            InitializeComponent();

            txtEmailAddress.Text = "dangquang10244@gmail.com";

            btnVerify.Click += BtnVerify_Click;
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            //EmailValidator Ev = new EmailValidator();
            //Ev.Mail_From = "dangquang1024@gmail.com";
            //// Check if the email address is valid and really exists
            //string errorMsg = Ev.Check_MailBox(txtEmailAddress.Text).ToString();

            //if (errorMsg == "")
            //{
            //    // the Mail Address/Smtp is valid and running
            //    txtLog.AppendText("\nMail OK");
            //}
            //else
            //{
            //    // An error occured while validating the email
            //    txtLog.AppendText("\n" + errorMsg);
            //}

            //// Close and Dispose
            //Ev.Dispose();
            VerifyEmail(txtEmailAddress.Text);
        }

        public void VerifyEmail(string emailAdress)
        {
            TcpClient tClient = new TcpClient("gmail-smtp-in.l.google.com", 25);
            string CRLF = "\r\n";
            byte[] dataBuffer;
            string ResponseString;

            NetworkStream netStream = tClient.GetStream();
            StreamReader reader = new StreamReader(netStream);
            ResponseString = reader.ReadLine();
            /* Perform HELO to SMTP Server and get Response */
            dataBuffer = BytesFromString("HELO " + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("MAIL FROM:<dangquang1024@gmail.com>" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            /* Read Response of the RCPT TO Message to know from google if it exist or not */

            dataBuffer = BytesFromString("RCPT TO:<" + emailAdress + ">" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            if (GetResponseCode(ResponseString) == 550)
            {
                txtLog.AppendText("Mai Address Does not Exist !");

                txtLog.AppendText("Original Error from Smtp Server : " + ResponseString);
            }
            /* QUITE CONNECTION */
            txtLog.AppendText("Email Id Existing !");
            dataBuffer = BytesFromString("QUITE" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            tClient.Close();
        }

        private byte[] BytesFromString(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        private int GetResponseCode(string ResponseString)
        {
            return int.Parse(ResponseString.Substring(0, 3));
        }
    }
}
