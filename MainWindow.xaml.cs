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

namespace Jumper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JumperEntities db = new JumperEntities();

        public MainWindow()
        {
            InitializeComponent();

            ListAgents.ItemsSource = db.Agents.ToList();

            ComboboxOrderBy.ItemsSource = new List<string>
            {
                "Сброс", "По возрастанию", "По убыванию"
            };

            ComboBoxFilter.ItemsSource = db.AgentTypes.Select(t => t.Name).ToList();
        }

        private void ComboboxOrderBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboboxOrderBy.SelectedIndex)
            {
                case 0:
                    {
                        ListAgents.ItemsSource = db.Agents.ToList();
                        break;
                    }
                case 1:
                    {
                        ListAgents.ItemsSource = db.Agents.OrderBy(x => x.Priority).ToList();
                        break;
                    }
                case 2:
                    {
                        ListAgents.ItemsSource = db.Agents.OrderBy(x => x.Priority).ToList();
                        break;
                    }
            }
        }

        private void ComboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var typeId = db.AgentTypes.ToList().Find(t => t.Name == ComboBoxFilter.SelectedValue.ToString()).Id;
            ListAgents.ItemsSource = db.Agents.ToList().FindAll(a => a.AgentTypeId == typeId);
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListAgents.ItemsSource = db.Agents.ToList().FindAll(a => a.AgentName.Contains(Search.Text));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var deleteItem = (sender as Button).DataContext as Agents;

            try
            {
                db.Agents.Remove(deleteItem);
                db.SaveChanges();
                ListAgents.ItemsSource = db.Agents.ToList();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new EditCreateWindow((sender as Button).DataContext as Agents, true).Show();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new EditCreateWindow(new Agents(), false).Show();
        }
    }
}
