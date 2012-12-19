using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using PerfectPet.Model.Pets;

namespace MyPetStatus.Service
{
    [ServiceContract]
    public interface IPetStatus
    {
        [OperationContract]
        IList<PetStatus> GetPetStatus(int petid, DateTime startdate, DateTime enddate);
    }
}