using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Domain.Command
{
    public class RelayCommand : ICommand
    {
        private readonly Func<object, bool> canExecute;
        private readonly Action<object> execute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        
        public RelayCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        public RelayCommand(Action<object> execute)
        {
            this.canExecute = _ => true;
            this.execute = execute;
        }

        public bool CanExecute(object parameter) => canExecute(parameter);

        public void Execute(object parameter) => execute(parameter);
    }
}
