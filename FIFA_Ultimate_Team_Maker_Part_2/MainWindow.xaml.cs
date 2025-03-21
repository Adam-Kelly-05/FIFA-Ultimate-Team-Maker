using System.Windows;

namespace FIFA_Ultimate_Team_Maker_Part_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double budget = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartGame_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(Budget_TXTBX.Text) != 0)
                budget = double.Parse(Budget_TXTBX.Text);

            MainGameWindow GameWindow = new MainGameWindow(this);
            GameWindow.Owner = this;

            GameWindow.ShowDialog();
        }
    }
}
