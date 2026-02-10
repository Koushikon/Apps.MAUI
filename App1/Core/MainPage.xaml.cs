using Model;

namespace Core
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        Shop s1 = new Shop();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                Hello.Text = $"{s1.Id}";
                CounterBtn.Text = $"Clicked {count} time";
            }
            else
            {
                Hello.Text += "🤑";
                CounterBtn.Text = $"Clicked {count} times";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}