using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcfServisimiTuket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //host ettiğim servisin adresi
        //http://wcfservicekatmanli.somee.com/UrunlerService.svc

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.UrunlerServiceClient client = new ServiceReference1.UrunlerServiceClient();
            dataGridView1.DataSource = client.UrunListesi();
        }
    }
}
