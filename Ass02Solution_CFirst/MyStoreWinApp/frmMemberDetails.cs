using DataAccess.Repository;
using System;
using System.Windows.Forms;
using BusinessObject;
namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        //-----------------------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfor { get; set; }
        //----------------------------------------------
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtMemberID.Text = MemberInfor.MemberId.ToString();
                txtMemberName.Text = MemberInfor.CompanyName;
                cboCity.Text = MemberInfor.City;
                txtEmail.Text = MemberInfor.Email;
                cboCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    CompanyName = txtMemberName.Text,
                    City = cboCity.Text,
                    Email = txtEmail.Text,
                    Country = cboCountry.Text,
                    Password = txtPassword.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
