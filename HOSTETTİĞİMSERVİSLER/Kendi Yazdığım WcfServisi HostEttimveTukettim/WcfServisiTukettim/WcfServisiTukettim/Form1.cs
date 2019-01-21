using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServisiTukettim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.KurServisClient client = new ServiceReference1.KurServisClient();
        private void Form1_Load(object sender, EventArgs e)
        {
            //http://mywcfservis.somee.com/KurServis.svc
            var data = client.ParaBirimleriGetir();
        }
    }
}
