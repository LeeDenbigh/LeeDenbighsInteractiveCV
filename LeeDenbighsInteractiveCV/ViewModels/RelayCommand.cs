using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        // Constructor that takes an Action to execute and an optional Func<bool> for canExecute
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        // Event that is raised when the ability to execute the command changes
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Determines whether the command can be executed
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        // Executes the command
        public void Execute(object parameter)
        {
            _execute();
        }
    }

}
