namespace CSharpAdvancedDay3
{
    public partial class LoginForm : Form
    {
        const string username = "admin";
        const string password = "admin";

        public LoginForm() => InitializeComponent();

        private void Login_btn_Click(object sender, EventArgs e)
        {
            // Validation section
            if (username_txt.Text.Trim() == "" || password_txt.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please fill all field's.",
                    "Error input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // offer remember msg
            if (!remember_cb.Checked)
            {
                var result = MessageBox.Show(
                    "Remember you to login automatic second time?",
                    "Remember me alert",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes) remember_cb.Checked = true;
            }

            // check username and password is correct or not
            if (username_txt.Text != username || password_txt.Text != password)
            {
                MessageBox.Show(
                    "Username or password is wrong, try again.",
                    "Error input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // this all up is true and do what do you want
            MessageBox.Show(
                "Your are login in",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }
    }
}
