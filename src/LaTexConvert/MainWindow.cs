// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Windows.Forms;
using LaTexConvert.Business.ViewModels;

namespace LaTexConvert;

public partial class MainWindow : Form
{
    private MainWindowViewModel _viewModel;


    public MainWindow(MainWindowViewModel mainWindowViewModel)
    {
        _viewModel = mainWindowViewModel;

        InitializeComponent();
    }
}