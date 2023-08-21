﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeathManager.Model;
using WeathManager.Utilities;

namespace WealthManager.ViewModel
{
    class FinancesVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        public decimal TransactionAmout
        {
            get { return _pageModel.TransactionValue; }
            set { _pageModel.TransactionValue = value; OnPropertyChanged(); }
        }

        public FinancesVM()
        {
            _pageModel = new PageModel();
            TransactionAmout = 5638;
        }
    }
}