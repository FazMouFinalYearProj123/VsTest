using SMS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btGetTeachers_Click(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = getTeachers();
        }

        public static void showFirstTeacher()
        {
            WebClient proxy = new WebClient();
            string serviceURL = "http://localhost:53695/TeacherService.svc/teacher";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj =
                        new DataContractJsonSerializer(typeof(Teacher));
            Teacher teacher = obj.ReadObject(stream) as Teacher;
            MessageBox.Show(teacher.firstName);
        }

        public static List<Teacher> getTeachers()
        {
            WebClient proxy = new WebClient();
            string serviceURL = "http://localhost:53695/TeacherService.svc/teachers/all";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj =
                        new DataContractJsonSerializer(typeof(List<Teacher>));
            List<Teacher> teacher = obj.ReadObject(stream) as List<Teacher>;
            return teacher;
        }

      
    }
}
