using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutegador
{
    public partial class Neutegador : Form
    {
        public Neutegador()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSearchEngine.Items.Add("g");
            cmbSearchEngine.Items.Add("Google.com");
            cmbSearchEngine.Items.Add("Youtube.com");
            cmbSearchEngine.Items.Add("Facebook.com");
            cmbSearchEngine.Items.Add("Email.com");

            webBrowser1.Navigate("google.com");
            cmbSearchEngine.SelectedIndex = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void tsbNavigate_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txUrl.Text);
        }

        private void cmbSearchEngine_Click(object sender, EventArgs e)
        {
                  
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Confirm.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Navigate(txUrl.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txUrl.Text = webBrowser1.Url.ToString();
                }

        private void txtUrlSearchEngine_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
