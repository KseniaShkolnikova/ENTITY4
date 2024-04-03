using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Entity2
{
    /// <summary>
    /// Логика взаимодействия для sushi.xaml
    /// </summary>
    public partial class sushi : Page
    {
        private PRAKT4Entities context = new PRAKT4Entities();
        public sushi()
        {
            InitializeComponent();
            ingridik.ItemsSource = context.SUSHI.ToList();
            combobox.ItemsSource = context.SUSHI_STORE.ToList();
        }

        private void button_serh_Click(object sender, RoutedEventArgs e)
        {
            ingridik.ItemsSource = context.SUSHI.ToList().Where(item => item.NANE_SUSHI.Contains(serch.Text));
            serch.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ingridik.ItemsSource = context.SUSHI.ToList();
            combobox.Text = null;
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                //var selecteds = combobox.SelectedItem as SUSHI_STORE;
                //ingridik.ItemsSource=context.INGREDIENTS.ToList().Where(items=> selecteds==items.SUSHI_STORE);
                var selected = (combobox.SelectedItem as SUSHI_STORE).SUSHI_ID;
                ingridik.ItemsSource = context.SUSHI.ToList().Where(item => item.ID_SUSHI == selected).ToList();

            }
        }
    }
}

