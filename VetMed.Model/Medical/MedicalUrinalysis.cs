using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Medical
{
    class MedicalUrinalysis : IMedicalUrinalysis
    {
        private readonly IMedicalUrinalysis _urinalysis;

        public MedicalUrinalysis()
        {
            
        }

        public MedicalUrinalysis(IMedicalUrinalysis urinalysis)
        {
            _urinalysis = urinalysis;
        }
    }
}
