namespace VetMed.Model.Medical
{
    public class MedicalMedicalLifeStyle : IMedicalLifeStyle
    {
        private readonly IMedicalLifeStyle _medicalLifeStyle;

        public MedicalMedicalLifeStyle()
        {
            
        }

        public MedicalMedicalLifeStyle(IMedicalLifeStyle medicalLifeStyle)
        {
            this._medicalLifeStyle = medicalLifeStyle;
        }
    }
}