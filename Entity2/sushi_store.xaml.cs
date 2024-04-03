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
    /// Логика взаимодействия для sushi_store.xaml
    /// </summary>
    public partial class sushi_store : Page
    {
        private PRAKT4Entities context = new PRAKT4Entities();
        public sushi_store()
        {
            InitializeComponent();
            ingridik.ItemsSource = context.SUSHI_STORE.ToList();
            combobox.ItemsSource = context.SUSHI.ToList();
        }

        private void button_serh_Click(object sender, RoutedEventArgs e)
        {
            //ingridik.ItemsSource = context.SUSHI_STORE.ToList().Where(item => item.NAME_POVARA.Contains(serch.Text));
            ingridik.ItemsSource = context.SUSHI_STORE.ToList().Where(item => item.NAME_POVARA != null && item.NAME_POVARA.Contains(serch.Text)).ToList();
            serch.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ingridik.ItemsSource = context.SUSHI_STORE.ToList();
            combobox.Text= null;
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                var selecteds = combobox.SelectedItem as SUSHI;
                ingridik.ItemsSource=context.SUSHI_STORE.ToList().Where(items=> items.SUSHI==selecteds);

            }
        }
    }
}
