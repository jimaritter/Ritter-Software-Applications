namespace VetMed.Model.Medical
{
    public class MedicalRecord : IMedicalRecord
    {
        private readonly IMedicalRecord _medicalRecord;
        private int _id;
        private int _weight;
        private MedicalMedicalLifeStyle _medicalMedicalLifeStyle;

        public MedicalRecord()
        {
            
        }

        public MedicalRecord(IMedicalRecord medicalRecord)
        {
            _medicalRecord = medicalRecord;
        }
    }
}
