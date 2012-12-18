namespace VetMed.Model.Medical
{
    public class MedicalSurgical : IMedicalSurgical
    {
        private readonly IMedicalSurgical _medicalSurgical;

        public MedicalSurgical()
        {
            
        }

        public MedicalSurgical(IMedicalSurgical medicalSurgical)
        {
            _medicalSurgical = medicalSurgical;
        }
    }
}
