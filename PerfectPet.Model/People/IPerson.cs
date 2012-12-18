using System.Collections.Generic;

namespace PerfectPet.Model.People
{
    public interface IPerson
    {
        Person Get();
        IList<Person> GetAll();
        Person GetById(int id);
        void Save(Person person);
        void Delete(Person person);
        IEnumerable<Person> ManagerList(string persontype);
        IEnumerable<Person> EmployeeList(string persontype);
        IEnumerable<Person> CustomerList(string persontype);
    }
}