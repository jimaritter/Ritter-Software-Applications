namespace VetMed.Model.Shared
{
    public class InternalCode : IInternalCode
    {
        private readonly IInternalCode _internalCode;
        private int _id;
        private string _name;

        public InternalCode()
        {
            
        }

        public InternalCode(IInternalCode internalCode)
        {
            _internalCode = internalCode;
        }

        public string Name { get { return _name; } set { value = Name; } }

        public string GetName()
        {
            return "045a - Dental Cleaning and Polish";
        }
    }
}
