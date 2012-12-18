namespace VetMed.Model.Medical
{
    public class MedicalDermatology : IMedicalDermatology
    {
        private readonly IMedicalDermatology _medicalDermatology;

        public MedicalDermatology()
        {
            
        }

        public MedicalDermatology(IMedicalDermatology medicalDermatology)
        {
            _medicalDermatology = medicalDermatology;
        }
    }
}
