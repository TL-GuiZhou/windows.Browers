using Hbd.BlinkBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsers.miniblink.winfrom
{
    public partial class Form1 : Form
    {
        private BlinkBrowser _blinkBrowser;
        public Form1()
        {
            _blinkBrowser = new BlinkBrowser()
            {
                Dock=DockStyle.Fill
            };
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _blinkBrowser.GlobalObjectJs = this;
            this.Controls.Add(_blinkBrowser);
            _blinkBrowser.Url = "http://www.baidu.com";
        }
    }
}
