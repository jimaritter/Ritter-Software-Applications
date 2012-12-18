using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum PetSexes
    {
        [Description("Male")]
        Male,
        [Description("Male not Neutered")]
        MaleUnNeutered,
        [Description("Female")]
        Female,
        [Description("Female not Spayed")]
        FemailUnSpayed
    }
}
