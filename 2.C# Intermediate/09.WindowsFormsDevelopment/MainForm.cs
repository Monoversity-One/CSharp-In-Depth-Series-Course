namespace _09.WindowsFormsDevelopment
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        private int nextId = 1;

        public MainForm()
        {
            InitializeComponent();

            // Initialize employees (dummy data for demonstration)
            employees.Add(new Employee { Id = nextId++, Name = "John Doe", Position = "Developer", Age = 30 });
            employees.Add(new Employee { Id = nextId++, Name = "Jane Smith", Position = "Manager", Age = 35 });

            // Bind data to DataGridView
            dgvEmployees.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                addForm.NewEmployee.Id = nextId++;
                employees.Add(addForm.NewEmployee);
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                Employee selectedEmployee = (Employee)selectedRow.DataBoundItem;

                EditEmployeeForm editForm = new EditEmployeeForm(selectedEmployee);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                Employee selectedEmployee = (Employee)selectedRow.DataBoundItem;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedEmployee.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    employees.Remove(selectedEmployee);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void RefreshGrid()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = employees;
        }
    }
}
