using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsers.cef.winform
{
    public partial class Form1 : Form
    {
        private readonly ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser("www.baidu.com")
            {
                Dock = DockStyle.Fill,
            };
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "CefSharp.WinFom";
            WindowState = FormWindowState.Maximized;
           
            this.Controls.Add(browser);
        }
    }
}
