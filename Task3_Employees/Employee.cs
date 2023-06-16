namespace ComparerEmployee
{
    class Employee /*: IComparable*/
    {
        public string Name {get;}
        public int Age {get;set;}
        public int Salary {get;set;}
        public int WorkExperience {get;set;}

        public Employee (string name, int age, int salary,int workExperience)
        {
            Name = name;

            Age = age;

            Salary = salary;

            WorkExperience = workExperience;
        }

        // public int CompareTo (object obj)
        // {
        //     Employee employee = obj as Employee;
        //     if (employee != null)
        //     {
        //         if (this.Age < employee.Age)
        //             return -1;
        //         else if (this.Age > employee.Age)
        //             return 1;
        //         else
        //             return 0;
        //     }
        //     else {throw new Exception("The parameter must be of type \"Employee\".");}
        // }
    }
}