using System.ComponentModel.DataAnnotations;
using System.Linq;
using Atacadista.Models;

namespace Atacadista.Validacao
{
    public class CodEmUso : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string codigo = (string)value;

            DataContext context =
                (DataContext)
                validationContext.
                GetService(typeof(DataContext));

            Itens resultado =
                context.Itens.FirstOrDefault
                (
                    f => f.Codigo.Equals(codigo)
                );
            return resultado == null ?
                ValidationResult.Success :
                new ValidationResult("O código desse produto já existe! Altere ou cadastre um novo!");
                //teste teste
        }
    }
}
