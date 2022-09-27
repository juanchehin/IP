using System.Net;
using System.Net.Sockets;

namespace IP
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            obtenerIp();
        }

        private void obtenerIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.lblIP.Text = ip.ToString();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}