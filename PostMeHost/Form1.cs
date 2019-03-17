using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostMeHost
{
    public partial class Form1 : Form
    {
        ServiceHost sh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sh = new ServiceHost(typeof(PostMeService.PostMeService));
            sh.Open();
            label1.Text = "Service Running!!! Start Posting";
        }
    }
}
