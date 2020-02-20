using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace clientes_crmall.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Número")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
