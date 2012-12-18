namespace VetMed.Model.Medical
{
    public class MedicalVaccination : IMedicalVaccination
    {
        private readonly IMedicalVaccination _medicalVaccination;

        public MedicalVaccination()
        {
            
        }

        public MedicalVaccination(IMedicalVaccination medicalVaccination)
        {
            _medicalVaccination = medicalVaccination;
        }
    }
}
