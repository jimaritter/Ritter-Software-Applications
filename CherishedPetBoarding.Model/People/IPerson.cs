using System.Collections.Generic;

namespace CherishedPetBoarding.Model.People
{
    public interface IPerson
    {
        Person Get();
        IList<Person> GetAll();
        Person GetById(int id);
        void Save(Person person);
        void Delete(Person person);
    }
}