namespace _09.WindowsFormsDevelopment
{
    public partial class AddEmployeeForm : Form
    {
        public Employee NewEmployee { get; private set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string position = txtPosition.Text.Trim();
            int age = Convert.ToInt32(nudAge.Value);

            NewEmployee = new Employee { Name = name, Position = position, Age = age };

            DialogResult = DialogResult.OK;
        }
    }
}
