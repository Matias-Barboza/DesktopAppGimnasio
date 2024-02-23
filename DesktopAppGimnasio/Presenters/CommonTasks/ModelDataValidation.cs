using System.ComponentModel.DataAnnotations;

namespace DesktopAppGimnasio.Presenters.CommonTasks
{
    public class ModelDataValidation
    {
        public void Validate(object model) 
        {
            String errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context  = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);

            if(!isValid) 
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                }

                throw new Exception(errorMessage);
            }
        }
    }
}
