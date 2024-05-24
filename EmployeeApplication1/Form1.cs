namespace EmployeeApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void compute_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(firstNametxt.Text, lastNametxt.Text, departmenttxt.Text, jobTitletxt.Text);

            outputName.Text = partTimeEmployee.FirstName;
            lastNameOutput.Text = partTimeEmployee.LastName;
            double hour = Convert.ToDouble(ratePerHourtxt.Text);
            int totalHour = Convert.ToInt32(totalHoursWorkedtxt.Text);

            partTimeEmployee.computeSalary(totalHour,hour);
            double salary = Convert.ToDouble(partTimeEmployee.getSalary());

            salaryOutput.Text = salary.ToString();
        

        }
    }
}
