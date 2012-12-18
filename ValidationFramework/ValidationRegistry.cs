#region Using Statements

using StructureMap.Configuration.DSL;
using ValidationFramework.Validators;

#endregion

namespace ValidationFramework
{
    public sealed class ValidationRegistry : Registry
    {
        #region C'tors

        public ValidationRegistry()
        {
            //ForRequestedType(typeof (ValidationBase<>)).CacheBy(InstanceScope.Singleton);                        
            Scan(scanner =>
                     {
                         // Scan the types in the assembly that contains this Registry class
                         scanner.AssemblyContainingType<EmailValidation>();

                         // Finds and adds all concrete implementations of the IValidation
                         // interface in the targetted assemblies
                         scanner.ConnectImplementationsToTypesClosing(typeof (IValidator<>));
                     });
        }

        #endregion
    }
}