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

namespace Worldskills
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Grid CustomerGrid;
        public Grid MasterGrid;
        public Grid ManagerGrid;
        public Grid DirectorGrid;
        public Grid ZamDirGrid;

        public Window1()
        {
            InitializeComponent();
            CustomerGrid = CustomerScreen;
            MasterGrid = MasterScreen;
            ManagerGrid = ManagerScreen;
            DirectorGrid = DirectorScreen;
            ZamDirGrid = ZamDirectorScreen;
            //if (this.Closed)
            //{
            //    return DialogResult = true;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
