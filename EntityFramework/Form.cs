using EntityFramework.Models;

namespace EntityFramework
{
    public partial class Form : System.Windows.Forms.Form
    {
        private CompanySdContext _dbContext;
        public Form()
        {
            InitializeComponent();
            _dbContext = new CompanySdContext();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _dbContext.Employees.Select(emp => new
            {
                FirstName = emp.Fname,
                LastName = emp.Lname,
                Birthdate = emp.Bdate,
                Department = _dbContext.Departments.Where(d => emp.Dno == d.Dnum).Single().Dname
            }).ToList();

            comboBox1.DataSource = _dbContext.Departments.ToList();
            comboBox1.ValueMember = "Dnum";
            comboBox1.DisplayMember = "Dname";
        }

        // when type anything search directly
        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = _dbContext.Employees.
                Where(
                    emp =>
                        (emp.Fname != null && emp.Fname.ToLower().Contains(searchTb.Text.ToLower())) ||
                        (emp.Lname != null && emp.Lname.ToLower().Contains(searchTb.Text.ToLower()))
                ).
                Select(emp => new
                {
                    FirstName = emp.Fname,
                    LastName = emp.Lname,
                    Birthdate = emp.Bdate,
                    Department = _dbContext.Departments.Where(d => emp.Dno == d.Dnum).Single().Dname
                }).
                ToList();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            #region insert user
            _dbContext.Employees.Add(
                new Employee()
                {
                    Ssn = _dbContext.Employees.Select(emp => emp.Ssn).Max() + 1, // this line because the db ☻
                    Fname = fnameTb.Text,
                    Lname = lnameTb.Text,
                    Bdate = birthdatePic.Value,
                    Dno = Convert.ToInt32(comboBox1.SelectedValue)
                }
            );

            _dbContext.SaveChanges();
            #endregion

            #region rechange everything
            fnameTb.Text = "";
            lnameTb.Text = "";
            comboBox1.TabIndex = 0;
            #endregion

            #region refresh data source
            dataGridView.DataSource = _dbContext.Employees.Select(emp => new
            {
                FirstName = emp.Fname,
                LastName = emp.Lname,
                Birthdate = emp.Bdate,
                Department = _dbContext.Departments.Where(d => emp.Dno == d.Dnum).Single().Dname
            }).ToList();
            #endregion
        }
    }
}