using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //     http://localhost:45241/Service1.svc?wsdl
        //servisi host etmek için Service1.svc dosyasına sağ tık yapıp view in browser demeliyiz

        //wcf servisi
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
      

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(client.register("ramazan", "aras", "dassds@hotmail.com").ToString());
        }
    }
}
