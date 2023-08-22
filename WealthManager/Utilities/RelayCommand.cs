﻿using System;
using System.Windows.Input;

namespace WeathManager.Utilities
{
    class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        private readonly Action<object>? _execute;
        private readonly Func<object, bool>? _canExecute;

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);


        public void Execute(object? parameter) => _execute(parameter);
    }
}
