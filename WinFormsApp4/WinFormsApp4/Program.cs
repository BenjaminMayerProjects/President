using System;
using System.Windows.Forms;

namespace PresidentialGUI
//Touro ID T00348278
{
    public class MainForm : Form
    {
        private CheckBox ageBox;
        private CheckBox citizenshipBox;
        private CheckBox residencyBox;
        private Button checkEligibility;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialize form components
            this.ageBox = new CheckBox();
            this.citizenshipBox = new CheckBox();
            this.residencyBox = new CheckBox();
            this.checkEligibility = new Button();

            this.Text = "Presidential Eligibility Checker";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ageBox.Text = "At least 35 years old";
            this.citizenshipBox.Text = "Natural-born U.S. citizen";
            this.residencyBox.Text = "14 years of residency in the U.S.";

            this.checkEligibility.Text = "Check Eligibility";
            this.checkEligibility.Click += new EventHandler(checkEligibilityButton_Click);

            this.ageBox.Location = new System.Drawing.Point(10, 10);
            this.citizenshipBox.Location = new System.Drawing.Point(10, 40);
            this.residencyBox.Location = new System.Drawing.Point(10, 70);
            this.checkEligibility.Location = new System.Drawing.Point(10, 100);

            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.citizenshipBox);
            this.Controls.Add(this.residencyBox);
            this.Controls.Add(this.checkEligibility);
        }

        private void checkEligibilityButton_Click(object sender, EventArgs e)
        {
            bool meetsRequirements =
                ageBox.Checked &&
                citizenshipBox.Checked &&
                residencyBox.Checked;

            if (meetsRequirements)
            {
                MessageBox.Show("Congratulations! You meet the requirements to become President of the United States.");
            }
            else
            {
                MessageBox.Show("Sorry, you can't be President without an Amendment. ");
            }
        }

       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

