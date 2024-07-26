using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_C_.Generics
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Salary: {Salary}";
        }
        public static bool operator ==(Employee left, Employee right) 
        {
        return left.Equals(right);      
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left.Equals(right));
        }
        public override bool  Equals(object? obj)
        {
            Employee? employee =(Employee?) obj;
            return (this.Id == employee?.Id)&& (this.Name == employee?.Name)&& (this.Salary == employee?.Salary);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
        }


        public int CompareTo(Employee? other)
        {
            if (other is null)
                return 1;
            else
                return this.Salary.CompareTo(other.Salary);
        }
    }
}