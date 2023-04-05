using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;


namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string url = "https://api.exchangerate.host/latest?format=xml";
            try
            {
                // Load the data.
                XmlDocument doc = new XmlDocument();
                doc.Load(url);

                XmlNodeList elemList = doc.GetElementsByTagName("code");
                for (int i = 0; i < elemList.Count; i++)
                {
                    dari_cmb.Items.Add(elemList[i].InnerText);
                    ke_cmb.Items.Add(elemList[i].InnerText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Read Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }  

        private void doConvert(string dari, string ke, double nilai = 0)
        {
            string url = "https://api.exchangerate.host/convert?from="+dari+"&to="+ke+"&format=xml";
            try
            {
                // Load the data.
                XmlDocument doc = new XmlDocument();
                doc.Load(url);

                XmlNodeList elemList = doc.GetElementsByTagName("result");
                XmlNodeList date = doc.GetElementsByTagName("date");
                for (int i = 0; i < elemList.Count; i++)
                {
                    hasil_txt.Text = Convert.ToString(Convert.ToDouble(elemList[i].InnerText.Replace(",", ".")) * nilai * 0.000001);
                    date_label.Text = date[i].InnerText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Read Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doConvert(dari_cmb.Text, ke_cmb.Text, Convert.ToDouble(nominal_inp.Text));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=currency+converter");
        }
    }
}
