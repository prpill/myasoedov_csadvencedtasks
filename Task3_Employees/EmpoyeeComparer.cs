namespace ComparerEmployee
{
    class NameComparer : IComparer<Employee>
    {
        public int Compare(Employee? emp1, Employee? emp2)
        {
            if (emp1 is null || emp2 is null)
                throw new ArgumentException("Incorrect parameter value");
            return emp1.Name[0] - emp2.Name[0];
        }  
    }
    
    class SalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee? emp1, Employee? emp2)
        {
            if (emp1 is null || emp2 is null)
                throw new ArgumentException("Incorrect parameter value");
            return emp1.Salary - emp2.Salary;
        }
    }

    class AgeComparer : IComparer<Employee>
    {
        public int Compare(Employee? emp1, Employee? emp2)
        {
            if (emp1 is null || emp2 is null)
                throw new ArgumentException("Incorrect parameter value");
            return emp1.Age - emp2.Age;
        }
    }
    class WorkExperienceComparer : IComparer<Employee>
    {
        public int Compare(Employee? emp1, Employee? emp2)
        {
            if (emp1 is null || emp2 is null)
                throw new ArgumentException("Incorrect parameter value");
            return emp1.WorkExperience - emp2.WorkExperience;
        }
    }
}
