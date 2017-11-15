using System.Windows;
using System.Windows.Input;
using Tobii.Interaction.Wpf;

namespace Interaction_Wpf_101
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _amountOfActivations = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                ((App)Application.Current).Host.Commands.Input.SendActivationModeOn();
            }
        }

        private void MainWindow_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                ((App)Application.Current).Host.Commands.Input.SendActivation();
                ((App)Application.Current).Host.Commands.Input.SendActivationModeOff();
            }
        }

        private void Grid_OnActivated(object sender, ActivationRoutedEventArgs e)
        {
            _amountOfActivations++;
            NumberOfActivations.Text = _amountOfActivations.ToString();
        }
    }
}
