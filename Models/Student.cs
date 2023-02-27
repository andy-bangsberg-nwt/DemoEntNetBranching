namespace DemoEntNetBranching.Models
{
    public class Student
    {
        private static int count;
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string ImagePath   // Property is a method
        {
            get
            {
               return  LastName + ".png";
            }

        }

    public Student(string firstName, string lastName)
    {
       
        ID = ++count; // Notice ++count   not count++
        FirstName = firstName;
        LastName = lastName;

    }

   }
}
