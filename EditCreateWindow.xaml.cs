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

namespace Jumper
{
    /// <summary>
    /// Логика взаимодействия для EditCreateWindow.xaml
    /// </summary>
    public partial class EditCreateWindow : Window
    {
        JumperEntities db = new JumperEntities();

        Agents _agent;

        bool _isEdit;

        public EditCreateWindow(Agents agent, bool isEdit)
        {
            InitializeComponent();

            _agent = agent;
            AgentGrid.DataContext = agent;
            _isEdit = isEdit;

            AgentTypeComBoBox.ItemsSource = db.AgentTypes.Select(x => x.Name).ToList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(_isEdit)
            {
                var editAgent = db.Agents.ToList().Find(x => x.Id == _agent.Id);
                editAgent.INN = INNTextBox.Text;
                editAgent.KPP = KPPTextBox.Text;
                editAgent.AgentName = NameAgentTexBox.Text;
                editAgent.AgentTypeId = db.AgentTypes.ToList().Find(x => x.Name == AgentTypeComBoBox.SelectedValue.ToString()).Id;
                editAgent.DirectorFio = DirectorNameTextBox.Text;
                editAgent.AgentPhone = AgentNumberTextBox.Text;
                editAgent.AgentEmail = AgentEmailTextBox.Text;
                editAgent.Priority = PriorityTextBox.Text;
                editAgent.AgentAddress = AddressTextBox.Text;

                db.SaveChanges();
            }
            else
            {
                _agent.AgentTypeId = db.AgentTypes.ToList().Find(x => x.Name == AgentTypeComBoBox.SelectedValue.ToString()).Id;
                _agent.Id = db.Agents.ToList().Count + 1;

                db.Agents.Add(_agent);
                db.SaveChanges();

                _isEdit = true;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new MainWindow().Show();
        }
    }
}
