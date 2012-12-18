namespace VetMed.Model.Medical
{
    public class MedicalParasitology : IMedicalParasitology
    {
        private readonly IMedicalParasitology _parasitology;

        public MedicalParasitology()
        {
            
        }

        public MedicalParasitology(IMedicalParasitology parasitology)
        {
            _parasitology = parasitology;
        }
    }
}
