

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
             "BS Information Technology",
             "BS Computer Science",
             "BS Information Systems",
             "BS in Accountancy",
             "BS in Hospitality Management",
             "BS in Tourism Management"
             };

            for (int i = 0; i < 6; i++)
            {
                cmbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        /////return methods 
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text,
            txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cmbPrograms.Text;

            StudentInformationClass.SetGender = cmbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContact.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = pickerBday.Value.ToString("yyyyMM-dd");

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            txtStudentNo.Text = 99888223.ToString();
            txtFirstName.Text = "Naruto";
            cmbPrograms.Text = "BS";
            txtAge.Text = 25.ToString();
            cmbGender.Text = cmbGender.SelectedItem.ToString();
            txtContact.Text = 98887776622.ToString();
            txtMiddleInitial.Text = "k";

            pickerBday.Text = pickerBday.Value.ToString("yyyyMM-dd");


        }
    }
}