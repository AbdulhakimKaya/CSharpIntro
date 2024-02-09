// variables -> camelCase

using Intro.Business;
using Intro.Entities;

string message = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = false;

Console.WriteLine(message);


// condition
if (isAuthenticated)  // isAuthenticated == true
{
    Console.WriteLine("Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");
}

Console.WriteLine("Kod Bitti");


// arrays
string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3" };

string[] loans2 = new string[2];
loans2[0] = "Kredi1";
loans2[1] = "Kredi2";


// loops
//       start  condition         increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine("Eleman 1 -> " + loans[i]);
}


// OOP
Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net8 vs ...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 21 vs ...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12 vs ...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price); 
}

foreach (var course in courses)
{
    Console.WriteLine(course.Name + " / " + course.Price);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

