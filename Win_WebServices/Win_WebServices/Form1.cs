using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_WebServices.UrunService;


//Service ekleyince aşağıdaki Dlleri eklendi 
//System.Runtime.Serialization;
// System.ServiceModel;
namespace Win_WebServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //NorthwindService deki UrunService classına SoapClient ekleyerek class oluşturulmuş
            UrunService.UrunServiceSoapClient urun = new UrunService.UrunServiceSoapClient();

            string msg = urun.HelloWorld();

            MessageBox.Show(msg);

        }

        private void btnUrunleriListele_Click(object sender, EventArgs e)
        {
            UrunService.UrunServiceSoapClient service = new UrunService.UrunServiceSoapClient();
            dataGridView1.DataSource = service.TumunuListele(new Oturum {KullaniciAdi="admin",Parola="123" });//bu metoda ulaşabilmek için Oturum bilgisi gerekiyor.Soapheader ile güvenlik yapısı yaptık
            
        }

        private void btnMusterilistele_Click(object sender, EventArgs e)
        {
            MusteriService.MusteriServiceSoapClient service = new MusteriService.MusteriServiceSoapClient();
            dataGridView1.DataSource = service.TumunuListele();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            TcknService.KPSPublicSoapClient service = new TcknService.KPSPublicSoapClient();
            bool sonuc=service.TCKimlikNoDogrula(Convert.ToInt64(txtTCKN.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), Convert.ToInt32(txtDogumYili.Text));//isim soyisim büyük olmalı


            if (sonuc==true)
            {
                MessageBox.Show("TcKn doğru");
            }
            else
            {
                MessageBox.Show("TcKn yanlış");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


  

}


//https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?wsdl