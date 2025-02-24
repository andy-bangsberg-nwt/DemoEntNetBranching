namespace DemoEntNetBranching.Models
{
    public static class StudentDB
    {
        static List<Student> listStudent = new List<Student>()
        {
            new Student("Joe", "Kopacz"),
            new Student("Andy", "Bangsberg"),
            new Student("Rene", "Bylander"),
            new Student("Squirt", "Whispurr"),
            new Student("Dr.", "Severen"),
            new Student("James", "Kirk"),
            new Student("Kyara", "Miller"),
      		new Student("Ollie", "TheCat"),
            new Student("Chelcie", "Feiten"),
            new Student("Draden", "Jensen"),
            new Student("Ollie", "TheCat"),
            new Student("Bart", "Lund"),
            new Student("Cal", "Crowder"),
            new Student("John", "Hirsch"),
            new Student("Jayden", "Visocky"),
            new Student("Alyssa", "Sherman"),
            new Student("Christian", "Eikam"),
            new Student("Robbie", "Lorenz")
            
          };

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            students = listStudent;


            return students;

        }


        public static Student getStudentByLastName(string lastName)
        {
            Student foundStudent = new Student("","");
            List<Student> students = GetStudents();

            // FirstOrDefault can return null, thus us var 
            var student = students.FirstOrDefault(x => x.LastName == lastName);


            if (student != null)
            {
                foundStudent = student;
            }


            return foundStudent;
        }

    }
}
