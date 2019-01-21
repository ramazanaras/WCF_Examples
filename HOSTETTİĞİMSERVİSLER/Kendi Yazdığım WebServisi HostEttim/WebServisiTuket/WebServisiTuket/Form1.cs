using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WebServisiTuket.ServiceReference1;

namespace WebServisiTuket
{
    public partial class Form1 : Form
    {
        UrunlerServisSoapClient client = new UrunlerServisSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //http://benimwebservisim.somee.com/UrunlerServis.asmx
          
            var data=client.UrunlerListesi(new Kimlik { KullaniciAdi = "admin", Parola = "123" });
            dataGridView1.DataSource = data;
        }
    }
}
