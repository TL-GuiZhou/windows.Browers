using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsers.Firefox.winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            this.Controls.Add(geckoWebBrowser);
            geckoWebBrowser.Navigate("www.baidu.com");
            InitializeComponent();
        }
    }
}
