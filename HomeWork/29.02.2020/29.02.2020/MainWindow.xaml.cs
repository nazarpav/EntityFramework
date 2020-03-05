using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _29._02._2020
{
    public partial class MainWindow : Window
    {
        Thread WBT_T;
        private void WindowBackgroundTransfusion()
        {
            const float MIN_OFFSET = 0.1f;
            const float MAX_OFFSET = 1f;
            Color color= new Color();
            color.B = 10;
            //color.R = 10;
            //color.G = 10;
            while (true)
            {
                for (float i = MIN_OFFSET; i < MAX_OFFSET; i+=0.005f)
                {
                    Dispatcher.Invoke(() => WinBackgGS.Offset=i);
                    Dispatcher.Invoke(() => WinBackgGS.Color+= color);
                    Thread.Sleep(50);
                }
                for (float i = MAX_OFFSET; i > MIN_OFFSET; i-= 0.005f)
                {
                    Dispatcher.Invoke(() => WinBackgGS.Offset=i);
                    Dispatcher.Invoke(() => WinBackgGS.Color += color);
                    Thread.Sleep(50);
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            ThreadStart WindowBackgroundTransfusion_TS = new ThreadStart(WindowBackgroundTransfusion);
            WBT_T = new Thread(WindowBackgroundTransfusion_TS);
            WBT_T.Start();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            WBT_T.Abort();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    Create_UpdateStudent win1 = new Create_UpdateStudent(((Button)sender).Content.ToString());
                    win1.Show();
                    break;
                case 1:
                    Create_UpdateSpecialization win2 = new Create_UpdateSpecialization(((Button)sender).Content.ToString());
                    win2.Show();
                    break;
                case 2:
                    Create_UpdateSubjects win3 = new Create_UpdateSubjects(((Button)sender).Content.ToString());
                    win3.Show();
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    Create_UpdateStudent win1 = new Create_UpdateStudent(((Button)sender).Content.ToString());
                    win1.Show();
                    break;
                case 1:
                    Create_UpdateSpecialization win2 = new Create_UpdateSpecialization(((Button)sender).Content.ToString());
                    win2.Show();
                    break;
                case 2:
                    Create_UpdateSubjects win3 = new Create_UpdateSubjects(((Button)sender).Content.ToString());
                    win3.Show();
                    break;
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (UniversityEntities en = new UniversityEntities())
            {
                List<int> DelId = new List<int>();
                int id;
                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        foreach (var i in StusentListView.SelectedItems)
                        {
                            try
                            {
                                 id = int.Parse(i.ToString().Remove(i.ToString().IndexOf("#")));
                            }
                            catch
                            {
                                continue;
                            }
                            var res = en.Students.Where(q=>q.Id==id)?.FirstOrDefault();
                            if (res == null)
                            {
                                continue;
                            }
                            en.Students.Remove(res);
                        }
                        break;
                    case 1:
                        foreach (var i in SpecializationListView.SelectedItems)
                        {
                            try
                            {
                                id = int.Parse(i.ToString().Remove(i.ToString().IndexOf("#")));
                            }
                            catch
                            {
                                continue;
                            }
                            var res = en.Specializations.Where(q => q.Id == id).FirstOrDefault();
                            if(res==null)
                            {
                                continue;
                            }
                            en.Specializations.Remove(res);
                        }
                        break;
                    case 2:
                        foreach (var i in SubjectListView.SelectedItems)
                        {
                            try
                            {
                                id = int.Parse(i.ToString().Remove(i.ToString().IndexOf("#")));
                            }
                            catch
                            {
                                continue;
                            }
                            var res = en.Subjects.Where(q => q.Id == id)?.FirstOrDefault();
                            if (res == null)
                            {
                                continue;
                            }
                            en.Subjects.Remove(res);
                        }
                        break;
                }
                try
                {
                    await en.SaveChangesAsync();
                }
                catch
                {
                    MessageBox.Show("Selected item(s) is not deleted because is foreign key use");
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    using (UniversityEntities en = new UniversityEntities())
                    {
                        StusentListView.Items.Clear();
                        StusentListView.Items.Add("Id | Name | Surname | Phone | Address | Specialization Id");
                        foreach (var i in en.Students)
                        {
                            StusentListView.Items.Add(i.Id + "# | " + i.Name + " | " + i.Surname + " | " + i.Phone + " | " + i.Address + " | " + i.Specialization_Id);
                        }
                    }
                    break;
                case 1:
                    using (UniversityEntities en = new UniversityEntities())
                    {
                        SpecializationListView.Items.Clear();
                        SpecializationListView.Items.Add("Id | Name");
                        foreach (var i in en.Specializations)
                        {
                            SpecializationListView.Items.Add(i.Id+"# | "+ i.Name);
                        }
                    }
                    break;
                case 2:
                    using (UniversityEntities en = new UniversityEntities())
                    {
                        SubjectListView.Items.Clear();
                        SubjectListView.Items.Add("Id | Name | Amount Of Hour | Specialization Id");
                        foreach (var i in en.Subjects)
                        {
                            SubjectListView.Items.Add(i.Id + "# | " + i.Name + " | "+i.AmountOfHour + " | "+i.Specialization_Id);
                        }
                    }
                    break;
            }
        }
    }
}
