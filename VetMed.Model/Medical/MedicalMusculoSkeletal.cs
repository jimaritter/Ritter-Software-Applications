using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Medical
{
    public class MedicalMusculoSkeletal : IMedicalMusculoSkeletal
    {
        private readonly IMedicalMusculoSkeletal _medicalMusculoSkeletal;

        public MedicalMusculoSkeletal()
        {
            
        }

        public MedicalMusculoSkeletal(IMedicalMusculoSkeletal medicalMusculoSkeletal)
        {
            _medicalMusculoSkeletal = medicalMusculoSkeletal;
        }
    }
}
