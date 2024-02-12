// variables -> camelCase

using Intro.Business;
using Intro.DataAccess.Concretes;
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

foreach (Course course in courses)
{
    Console.WriteLine(course.Name + " / " + course.Price);
}

CourseManager courseManager = new CourseManager(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Abdulhakim";
customer1.LastName = "KAYA";
customer1.NationalIdentity = "12345678901";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "12346";
customer2.FirstName = "Furkan";
customer2.LastName = "Oğuz";
customer2.NationalIdentity = "12345678902";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 1;
customer3.CustomerNumber = "12347";
customer3.Name = "Kodlamaio";
customer3.TaxNumber = "123456789";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 2;
customer4.CustomerNumber = "12348";
customer4.Name = "abc";
customer4.TaxNumber = "123456787";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

// Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
