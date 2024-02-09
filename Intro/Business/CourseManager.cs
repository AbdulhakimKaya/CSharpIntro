using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    // constructor
    public CourseManager()
    {
        Console.WriteLine("Başladı");
        
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

    }
    public Course[] GetAll()
    {
        // normalde veri kaynağından çekilir
        return courses;
    }
}