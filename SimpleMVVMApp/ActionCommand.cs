namespace SimpleMVVMApp
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;

    public class ActionCommand : ICommand
    {
        public Boolean CommandSucceeded { get; set; }
        public Action<object> ExecuteDelegate { get; set; }
        public Predicate<object> CanExecuteDelegate { get; set; }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteDelegate == null) return true;

            return this.CanExecuteDelegate(parameter);
        }
        [DebuggerStepThrough]
        public void Execute(object parameter)
        {
            if (this.ExecuteDelegate == null) return;

            this.ExecuteDelegate(parameter);
            this.CommandSucceeded = true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}