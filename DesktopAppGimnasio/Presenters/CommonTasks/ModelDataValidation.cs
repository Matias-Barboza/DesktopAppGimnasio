using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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
