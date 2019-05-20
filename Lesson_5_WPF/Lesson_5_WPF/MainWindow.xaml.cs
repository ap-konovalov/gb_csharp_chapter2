using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lesson_5_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee Employee_1 = new Employee(1, "Ivan", "Kyzmin", "Ivanovich", 18);
            Employee Employee_2 = new Employee(2, "Petr", "Zaicev", "Igorevich", 35);
            Employee Employee_3 = new Employee(3, "Konstantin", "Averkin", "Petrovich", 49);
        }
    }
}
