using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Practice___Aggregation_and_Containment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            prog124.AddStudent(new Student("jeff", "muturi", 100, 100));
            prog124.AddStudent(new Student("jostin", "diaz", 27, 80));
            prog124.AddStudent("jamal", "kim ", 87, 90);


            string classInfo = $"{prog124.ClassName} {prog124.ClassNumber} - {prog124.RoomNumber} - {prog124.Instructor.FirstName} {prog124.Instructor.LastName} - Number of Students: {prog124.ClassRoster.Count}";
            string instructorInfo = $"Instructor: {prog124.Instructor.ToString()}";
            string studentInfo = "";

            foreach (Student student in prog124.ClassRoster)
            {
                studentInfo += $"{student.ToString()} - CSI Grade {student.CsiGrade} - GenEd Grade {student.GenEdGrade}\n";
            }

            MessageBox.Show($"{classInfo}\n{instructorInfo}\n{studentInfo}");


        }


    }
}
