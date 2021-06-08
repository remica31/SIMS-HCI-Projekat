using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RefaktorisaniSims.Validation
{
    public class IsNumber : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                int r;
                if (int.TryParse(s, out r))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unesite celobrojnu vrednost");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }
    public class IsLengthValid : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                if (s.Length > 4)
                { if (s.Length < 20)
                    {
                        return new ValidationResult(true, null);
                    }
                    return new ValidationResult(false, "Unesite rec kracu od 20 karaktera");
                }
                return new ValidationResult(false, "Unesite rec duzu od 4 karaktera");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }



}
