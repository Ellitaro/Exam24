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
using System.Windows.Shapes;

namespace Exam24.Теория
{
    /// <summary>
    /// Логика взаимодействия для _4.xaml
    /// </summary>
    public partial class _4 : Window
    {
        public _4()
        {
            InitializeComponent();

            // Загрузка данных в listbox
            UsersLb.ItemsSource = App.context.User.ToList();
        }
    }
}
