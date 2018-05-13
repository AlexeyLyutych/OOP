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
using Zoo.Models;
using System.Data.Entity;

namespace Zoo
{
    /// <summary>
    /// Логика взаимодействия для Animal_Window.xaml
    /// </summary>
    public partial class Animal_Window : Window
    {
        ZooContex db;
        public Animal_Window()
        {
            InitializeComponent();
            db = new ZooContex();
            db.Animals.Load();
            AnimalList.ItemsSource = db.Animals.Local.ToBindingList();


        }
        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal p = (Animal)AnimalList.SelectedItem;
            KindText.Text = p.KindOfAnimal;
            NumberText.Text = Convert.ToString(p.Number);
            AviaryText.Text = Convert.ToString(p.AviaryNum);
            KeeperText.Text = Convert.ToString(p.KeeperID);
            select_img.Source = new BitmapImage(new Uri(p.ImagePath, UriKind.Absolute)); ;
        }
    }
}
