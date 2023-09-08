namespace CSharpAdvancedDay3
{
    public partial class CalculatorForm : Form
    {
        private double _result = 0;
        private bool _equal = false;

        private Func<double, double>? _callback;

        public CalculatorForm() => InitializeComponent();

        #region Helper function
        private void Operation(Func<double, double>? fn = null, char operation = ' ')
        {
            double number;
            // if first input or equal operation
            if (_callback == null)
            {
                // if input is numbers set result equal number
                if (double.TryParse(screen_txt.Text, out number)) _result = number;
            }
            // if last line is number call last operation
            else if (double.TryParse(screen_txt.Text.Split('\n')[^1], out number))
                _result = _callback(number);

            // show result in screen
            screen_txt.Text = $"{_result}\n";
            // if function send is not operation equal 
            _equal = fn == null;
            // set next call function
            _callback = fn;

            // show operator if is found
            if (!_equal) screen_txt.Text += $"{operation}\n";
        }
        #endregion

        #region Events
        private void Number_click(object sender, EventArgs e)
        {
            // if equal operation is last operator clear result, screen, callable, and equal 
            if (_equal) Btn_clear_Click(sender, e);

            screen_txt.Text += ((Button)sender).Text;
        }

        private void Btn_cls_Click(object sender, EventArgs e) => Close();

        private void Btn_clear_current_Click(object sender, EventArgs e)
        {
            if (screen_txt.Text == "" || screen_txt.Text[^1] == '\n') return;
            var lastLine = screen_txt.Text.LastIndexOf('\n') + 1;
            screen_txt.Text = lastLine == -1 ? "" : screen_txt.Text[..lastLine];
        }

        private void Btn_clear_Click(object sender, EventArgs e)
            => (screen_txt.Text, _callback, _result, _equal) = ("", null, 0, false);

        private void Btn_clear_element_Click(object sender, EventArgs e)
        {
            if (screen_txt.Text == "" || screen_txt.Text[^1] == '\n') return;
            screen_txt.Text = _equal ? "" : screen_txt.Text[..^1];
        }

        private void Btn_divide_Click(object sender, EventArgs e)
            => Operation(number => _result / number, '/');

        private void Btn_multi_Click(object sender, EventArgs e)
            => Operation(number => _result * number, '*');

        private void Btn_mins_Click(object sender, EventArgs e)
            => Operation(number => _result - number, '-');

        private void Btn_plus_Click(object sender, EventArgs e)
            => Operation(number => _result + number, '+');

        private void Btn_equal_Click(object sender, EventArgs e)
            => Operation();

        #endregion
    }
}
