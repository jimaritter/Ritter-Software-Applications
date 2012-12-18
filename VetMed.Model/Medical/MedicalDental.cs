using VetMed.Model.Shared;

namespace VetMed.Model.Medical
{
    public class MedicalDental : IMedicalDental
    {
        private readonly IMedicalDental _medicalDental;
        private readonly IInternalCode _code = new InternalCode();

        public MedicalDental()
        {
            
        }

        public MedicalDental(IMedicalDental medicalDental)
        {
            _medicalDental = medicalDental;            
        }

        public string Code { get { return _code.GetName(); }}

        public string GetCode()
        {
            return Code;
        }
    }
}
