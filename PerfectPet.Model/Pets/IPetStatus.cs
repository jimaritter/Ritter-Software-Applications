using System;
using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IPetStatus
    {
        PetStatus Get();
        IList<PetStatus> GetAll();
        PetStatus GetById(int id);
        IList<PetStatus> GetByPetIdandDate(int petid, DateTime dateTime);
        IList<PetStatus> GetByPetIdandBetweenDates(int petid, DateTime startdate, DateTime enddate); 
        void Save(PetStatus petStatus);
        void Delete(PetStatus petStatus);
    }
}