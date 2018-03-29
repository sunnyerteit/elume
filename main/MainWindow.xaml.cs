using System;
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

namespace main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static pages.gripper GRIPPER;
        public static pages.rov ROV;
        public static pages.report REPORT;
        public MainWindow()
        {
            InitializeComponent();
            GRIPPER = new pages.gripper();
            ROV = new pages.rov();
            REPORT = new pages.report();
            FRAME.Content = ROV;
        }

        private void BUTTON_ROV_Click(object sender, RoutedEventArgs e)
        {
            FRAME.Content = ROV;
        }

        private void BUTTON_GRIPPER_Click(object sender, RoutedEventArgs e)
        {
            FRAME.Content = GRIPPER;
        }

        private void BUTTON_REPORT_Click(object sender, RoutedEventArgs e)
        {
            FRAME.Content = REPORT;
        }

        public void Change_Tab(int tab)
        {
            if (tab == 0)
            {
                FRAME.Content = ROV;
            }
            else if (tab == 1)
            {
                FRAME.Content = GRIPPER;
            }
            else
            {
                FRAME.Content = REPORT;
            }
        }
    }
}
