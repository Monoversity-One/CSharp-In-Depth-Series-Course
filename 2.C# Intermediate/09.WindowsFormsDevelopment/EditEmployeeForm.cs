namespace _09.WindowsFormsDevelopment
{
    public partial class EditEmployeeForm : Form
    {
        private Employee _employee;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;

            txtName.Text = _employee.Name;
            txtPosition.Text = _employee.Position;
            nudAge.Value = _employee.Age;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _employee.Name = txtName.Text.Trim();
            _employee.Position = txtPosition.Text.Trim();
            _employee.Age = Convert.ToInt32(nudAge.Value);

            DialogResult = DialogResult.OK;
        }
    }
}
