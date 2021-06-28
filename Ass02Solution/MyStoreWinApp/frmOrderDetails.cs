using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        public bool isAdmin { get; set; }

        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;

                txtShippedDate.Enabled = false;
                txtRequiredDate.Enabled = false;
                txtOrderDate.Enabled = false;
                txtMemberID.Enabled = false;
                txtFreight.Enabled = false;
                txtOrderID.Enabled = false;
                dgvMemberList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
