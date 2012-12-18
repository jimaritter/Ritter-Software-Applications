using System;
using System.ComponentModel;

namespace PerfectPet.Model.Pets
{
    [Serializable]
    public enum Species
    {
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
