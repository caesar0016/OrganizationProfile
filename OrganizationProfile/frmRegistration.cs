
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
            try
            {

                _StudentNo = long.Parse(studNum);

            }
            catch (FormatException)
            {

                MessageBox.Show("Error: FormatException in student Number");

            }
            finally {

                Console.WriteLine("Finally: Format Exception");
            
            }
                return _StudentNo;
        }


        public long ContactNo(string Contact)
        {
            try
            {

                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else {

                    throw new IndexOutOfRangeException("Error: Out of range in contact");
                
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Error: Format Exception in contact");

            }
            catch (OverflowException)
            { //catches the overlowing numbers for long

                MessageBox.Show("Error: Overflowing Exception in contact");

            }
            finally {

                Console.WriteLine("Finalizing resource cleanup...");
            
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {

            try {

                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;

                }
                else {

                    throw new ArgumentNullException("Plss input in firstname, last name, and middle initial");
                
                }

            }
            catch (FormatException ) {

                MessageBox.Show("Error: Format Exception in name");
            
            }

            return _FullName;
        }

        public int Age(string age)
        {
            try {

                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                    
                }

            }
            catch (FormatException) {

                MessageBox.Show("Error: Format Exception in Age");

            }
            catch (OverflowException) {

                MessageBox.Show("Error: Overflowing Exception in age");
            
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
            frm.Show();
        }

   

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear() {

            txtStudentNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbPrograms.Text = "";
            txtAge.Text = "";
            cmbGender.Text = "";
            txtContact.Text = "";
            txtMiddleInitial.Text = "";

        }
    }
}