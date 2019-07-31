using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{   
    [Table("contatos")]
    public class Contato
    {
        [Key, Column("tipo")]
        public string Tipo { get; set; }

        [Key,Column("valor")]
        public string Valor { get; set; }

        [ForeignKey("id_cliente")]
        public Cliente Cliente { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
    }
}
