﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitHubTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("First commit");
            Console.WriteLine("second commit");
            Console.WriteLine("New commit");
            Console.WriteLine("New New commit");
            Console.WriteLine("New New New commit");
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
        }
    }
}
