﻿using System.Windows.Controls;
using MenuBarProject.ViewModels;

namespace MenuBarProject.Views
{
    public partial class Blank3Page : Page
    {
        public Blank3Page(Blank3ViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
