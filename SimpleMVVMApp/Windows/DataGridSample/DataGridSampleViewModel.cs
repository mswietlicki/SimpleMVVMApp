namespace SimpleMVVMApp.Windows.DataGridSample
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using SimpleMVVMApp.Common;
    using SimpleMVVMApp.Models;

    public class DataGridSampleViewModel
    {
        public ObservableCollection<Step2Data> Data { get; set; }
        public ICommand AddItemCommand { get; set; }

        public DataGridSampleViewModel()
        {
            this.Data = new ObservableCollection<Step2Data>();

            this.AddItemCommand = new ActionCommand
            {
                ExecuteDelegate = o => this.Data.Add(new Step2Data { LayerName = DateTime.Now.Ticks.ToString() })
            };
        }
    }
}
