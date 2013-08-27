namespace SimpleMVVMApp.Windows.DataGridSample
{
    using System.Windows;

    public partial class DataGridSampleView : Window
    {
        public DataGridSampleView()
        {
            this.InitializeComponent();
            this.DataContext = new DataGridSampleViewModel();
        }
    }
}
