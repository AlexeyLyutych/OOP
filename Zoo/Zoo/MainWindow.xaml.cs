using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
using Zoo.Models;

namespace Zoo
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            ZooContex db = new ZooContex();
            db.Employess.Load();
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Associate_btn_Click(object sender, RoutedEventArgs e)
        {
            Employees employees = new Employees(this);

            employees.Show();
            
            
            



        }

        private void Animals_btn_Click(object sender, RoutedEventArgs e)
        {
            Animal_Window animal = new Animal_Window();
            animal.Show();
        }
    }
}
