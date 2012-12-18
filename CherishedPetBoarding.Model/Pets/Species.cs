using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherishedPetBoarding.Model.Pets
{
    [Serializable]
    public enum Species
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        [Description("Canine")]
        Canine,
        [Description("Feline")]
        Feline,
        [Description("Bird")]
        Bird,
        [Description("Reptile")]
        Reptile,
        [Description("Other")]
        Other
    }
}
