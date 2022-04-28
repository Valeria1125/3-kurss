using couse_work_web.ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace couse_work_web.ViewModels
{
    class CustomCommand : ICommand
    {
        Action action;
        public event EventHandler CanExecuteChanged;

        public CustomCommand(Action action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}


