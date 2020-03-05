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
    /// <summary>
    /// Логика взаимодействия для Create_UpdateStudent.xaml
    /// </summary>
    public partial class Create_UpdateStudent : Window
    {
        public Create_UpdateStudent(string type)
        {
            InitializeComponent();
            Create_UpdateSpecializationLabel.Content = type + " Specialization";
            Create_UpdateSpecializationButton.Content = type;
            if (type == "Update")
            {
                UpdateSpecializatinIDLabel.Visibility = Visibility.Visible;
                UpdateSpecializatinID.Visibility = Visibility.Visible;
            }
        }

        private async void Create_UpdateSpecializationButton_Click(object sender, RoutedEventArgs e)
        {
            using (UniversityEntities en = new UniversityEntities())
            {
                int SpId;
                if (Create_UpdateSpecializationButton.Content.ToString() == "Create")
                {
                    if(!int.TryParse(Create_UpdateSpecializatinTextBoxSpecialization_Id.Text, out SpId))
                    {
                        MessageBox.Show("Inkorect Inputed data");
                        return;
                    }
                    en.Students.Add(new Student { Name = Create_UpdateSpecializatinTextBoxName.Text, Surname= Create_UpdateSpecializatinTextBoxSurname.Text,Address=Create_UpdateSpecializatinTextBoxAddress.Text,Phone=Create_UpdateSpecializatinTextBoxPhone.Text, Specialization_Id = SpId });
                }
                else if (Create_UpdateSpecializationButton.Content.ToString() == "Update")
                {
                    int outId;
                    if (!int.TryParse(UpdateSpecializatinID.Text, out outId) ||
                    !int.TryParse(Create_UpdateSpecializatinTextBoxSpecialization_Id.Text, out SpId))
                    {
                        MessageBox.Show("Inkorect Inputed data");
                        return;
                    }
                    var sub = en.Students.Where(q => q.Id == outId).FirstOrDefault();
                    sub.Name = Create_UpdateSpecializatinTextBoxName.Text;
                    sub.Surname = Create_UpdateSpecializatinTextBoxSurname.Text;
                    sub.Phone = Create_UpdateSpecializatinTextBoxPhone.Text;
                    sub.Address = Create_UpdateSpecializatinTextBoxAddress.Text;
                    sub.Specialization_Id = SpId;
                }
                await en.SaveChangesAsync();
            }
        }

        private void UpdateSpecializatinID_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (UniversityEntities en = new UniversityEntities())
            {
                int outId;
                if (!int.TryParse(((TextBox)sender).Text.ToString(), out outId))
                {
                    return;
                }
                Create_UpdateSpecializatinTextBoxName.Text = en.Students.Where(q => q.Id == outId)?.FirstOrDefault()?.Name;
                Create_UpdateSpecializatinTextBoxSurname.Text = en.Students.Where(q => q.Id == outId)?.FirstOrDefault()?.Surname;
                Create_UpdateSpecializatinTextBoxPhone.Text = en.Students.Where(q => q.Id == outId)?.FirstOrDefault()?.Phone;
                Create_UpdateSpecializatinTextBoxAddress.Text = en.Students.Where(q => q.Id == outId)?.FirstOrDefault()?.Address;
                Create_UpdateSpecializatinTextBoxSpecialization_Id.Text = en.Students.Where(q => q.Id == outId)?.FirstOrDefault()?.Specialization_Id.ToString();
            }
        }
    }
}