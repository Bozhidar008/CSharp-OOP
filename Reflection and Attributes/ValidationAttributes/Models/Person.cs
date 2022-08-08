

namespace ValidationAttributes.Models
{
    using CustomAttributes;
    

    public class Person
    {
        public Person(string fullName, int age)
        {
            this.Fullname = fullName;
            this.Age = age;
        }
        [MyRequired]
        public string Fullname { get; set; }
        [MyRange(12,90)]
        public int Age { get; set; }
    }
}
