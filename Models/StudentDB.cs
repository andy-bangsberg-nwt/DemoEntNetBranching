namespace DemoEntNetBranching.Models
{
    public static class StudentDB
    {
        static List<Student> listStudent = new List<Student>()
        {
            new Student("Andy", "Bangsberg"),
//<<<<<<< HEAD
            new Student("Rene", "Bylander"),
//=======
            new Student("Rene", "Bylander"),
            new Student("Kyle", "Madlon"),
            new Student("Squirt", "Whispurr"),
            new Student("Ollie", "TheCat"),
            new Student("Kirk", "Herbison"),
            new Student("Evan", "Friberg"),
            new Student("Tetyana", "Oldham"),
            new Student("Toni", "Paffel")
//>>>>>>> origin/master

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
