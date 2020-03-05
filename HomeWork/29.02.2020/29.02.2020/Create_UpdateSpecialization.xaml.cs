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

namespace _29._02._2020
{
    public partial class Create_UpdateSpecialization : Window
    {
        public Create_UpdateSpecialization(string type)
        {
            InitializeComponent();
            Create_UpdateSpecializationLabel.Content = type+" Specialization";
            Create_UpdateSpecializationButton.Content = type;
            if(type=="Update")
            {
                UpdateSpecializatinIDLabel.Visibility = Visibility.Visible;
                UpdateSpecializatinID.Visibility = Visibility.Visible;
            }
        }

        private async void Create_UpdateSpecializationButton_Click(object sender, RoutedEventArgs e)
        {
            using (UniversityEntities en = new UniversityEntities())
            {
                if (Create_UpdateSpecializationButton.Content.ToString() == "Create")
                { 
                    en.Specializations.Add(new Specialization { Name = Create_UpdateSpecializatinTextBox.Text});
                }
                else if(Create_UpdateSpecializationButton.Content.ToString() == "Update")
                {
                    int outId;
                    if (!int.TryParse(UpdateSpecializatinID.Text, out outId))
                    {
                        return;
                    }
                    en.Specializations.Where(q => q.Id == outId).FirstOrDefault().Name = Create_UpdateSpecializatinTextBox.Text;
                }
               await en.SaveChangesAsync();
            }
        }

        private void UpdateSpecializatinID_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (UniversityEntities en = new UniversityEntities())
            {
                int outId;
                if(!int.TryParse(((TextBox)sender).Text.ToString(),out outId))
                {
                    return;
                }
                Create_UpdateSpecializatinTextBox.Text = en.Specializations.Where(q => q.Id == outId)?.FirstOrDefault()?.Name;
            }
        }
    }
}
