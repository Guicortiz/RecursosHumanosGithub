using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecursosHumanosGithub.Model
{
    public class Employee
    {
		public int id { get; set; }
		[DisplayName("Nome")]
		[Required(ErrorMessage = "Nome é obrigatorio")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter de 3 a 100 caracteres")]
		public string Name { get; set; }
		[DisplayName("Github")]
		[Required(ErrorMessage = "Github é obrigatorio")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Github deve ter de 3 a 50 caracteres")]
		public string Github { get; set; }
		[DisplayName("Linkedin")]
		[Required(ErrorMessage = "Linkedin é obrigatorio")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Linkedin deve ter de 3 a 50 caracteres")]
		public string Linkedin { get; set; }
		[DisplayName("Celular")]
		[Required(ErrorMessage = "Celular é obrigatorio")]
		[StringLength(11, MinimumLength = 10, ErrorMessage = "Numero do celular deve ter 10 a 11 digitos")]
		public string Fone { get; set; }
		[DisplayName("Aniversario")]
		public DateTime BirthDay { get; set; }
	}
}
