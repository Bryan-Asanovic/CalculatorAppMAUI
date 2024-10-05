namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculateSumClicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            ResultLabel.Text = $"{number1} + {number2} = {(number1 + number2)}";
        }
        private void OnCalculateDifferenceClicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            ResultLabel.Text = $"{number1} - {number2} = {(number1 - number2)}";
        }
        private void OnCalculateProductClicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            ResultLabel.Text = $"{number1} * {number2} = {(number1 * number2)}";
        }
        private void OnCalculateQuotientClicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            ResultLabel.Text = $"{number1} / {number2} = {(number1 / number2).ToString("F2")}";
        }
        private void OnCalculateRemainderClicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            ResultLabel.Text = $"{number1} % {number2} = (number1 % number2)";
        }
    }

}
