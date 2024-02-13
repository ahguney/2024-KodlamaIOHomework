using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


ICategoryService categoryService = new CategoryManager(new EfCategoryDal());

ICourseService courseService = new CourseManager(new EfCourseDal());

IInstructorService instructorService = new InstructorManager(new EfInstructorDal());

Category category = new Category()
{
    Id = 1,
    Name = "Programlama"
};

categoryService.Add(category);

Instructor instructor = new()
{
    Id = 1,
    FirstName = "Engin",
    LastName = "Demiroğ"
};

instructorService.Add(instructor);

Course dotNetCourse = new()
{
    InstructorId = 1,
    CategoryId = 1,
    Name = "2024 Yazılım Geliştirici Yetiştirme Kampı",
    Description = "2024 Yazılım Geliştirici Yetiştirme Kampı ödevleri buradan verilecektir",
};

courseService.Add(dotNetCourse);

Course seniorCourse = new()
{
    Id = 2,
    InstructorId = 1,
    CategoryId = 1,
    Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",
    Description = "Senior Yazılım Geliştirici Yetiştirme Kampı ödevleri buradan verilecektir",
};

courseService.Add(seniorCourse);

foreach (var course in courseService.GetList())
{
   Console.WriteLine($"{course.Name},{course.Description},{course.InstructorId}");
}
Console.ReadLine();








