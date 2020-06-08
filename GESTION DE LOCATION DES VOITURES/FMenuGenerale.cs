using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_LOCATION_DES_VOITURES
{
    public partial class FMenuGenerale : Form
    {
        public FMenuGenerale()
        {
            InitializeComponent();
        }

        private void FMenuGenerale_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FVoiture formV = new FVoiture();
          

            formV.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
