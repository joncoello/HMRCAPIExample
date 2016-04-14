using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMRCAPIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdHelloWorld_Click(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.service.hmrc.gov.uk");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.hmrc.1.0+json"));
            
            var response = client.GetAsync("/hello/world").Result;

            response.EnsureSuccessStatusCode();

            var content = response.Content.ReadAsStringAsync().Result;

            MessageBox.Show(content);

        }
    }
}
