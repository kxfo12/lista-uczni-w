using System.Collections.ObjectModel;
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

namespace listOfStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();
        public List<string> parentsJob { get; set; } = new List<string> { "Technik prądowiec", "Technik Programatyk", "Technik Informejtyk" };
        public MainWindow()
        {
            InitializeComponent();
            addStudents();
            DataContext = this;
        }
        public void addStudents()
        {
            Students.Add(new Student("Adam Krak", 17, false, parentsJob.ElementAt(1)));
            Students.Add(new Student("Kacper Istelski", 17, true, parentsJob.ElementAt(1)));
            Students.Add(new Student("Alicja Jałowiecka", 13, false, parentsJob.ElementAt(1)));
            Students.Add(new Student("Koziołek Matołek", 34, false, parentsJob.ElementAt(0)));
            Students.Add(new Student("Rambek UwU", 4, false, parentsJob.ElementAt(2)));
            Students.Add(new Student("Znajde cię i...", 21, true, parentsJob.ElementAt(2)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int wiek;
            if (int.TryParse(ageTextColumn, out wiek))
            {

            }
        }
    }
}
