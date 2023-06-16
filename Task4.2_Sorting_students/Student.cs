namespace SortingCollection
{
    public enum Gender
    {
        Male, Female
    }
    class Student
    {
        public string Name {get;}
        public int Age {get; set;}
        public Gender Gender {get;}
        public Student(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}