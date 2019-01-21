using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Service_Giris.UrunServiceReference;//servisi ekledik.

//Service referans ekleyince aşağıdaki dll'leri ekledi.
//System.Runtime.Serialization
//System.Service.model dll 'leri eklendi
namespace Service_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunlerServisSoapClient client = new UrunlerServisSoapClient();

            string msg = client.HelloWorld();

            MessageBox.Show(msg);


        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunlerServisSoapClient client = new UrunlerServisSoapClient();

            //Kimlik bilgilerini girerek bu listeye ulaşabiliriz.SoapHeader ile güvenliği sağladık
            dataGridView1.DataSource = client.UrunlerListesi(new Kimlik { KullaniciAdi = "admin", Parola = "123" });


        }



    }
}


/*
 * Tc kimlik webservis
 https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?wsdl
 */