using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Medical
{
    public class MedicalHematology : IMedicalHematology
    {
        private readonly IMedicalHematology _hematology;

        public MedicalHematology()
        {
            
        }

        public MedicalHematology(IMedicalHematology hematology)
        {
            _hematology = hematology;
        }
    }
}
