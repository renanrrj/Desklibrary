// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Library.Model
{
    [Table("tb_Emprestimo")]
    public partial class TbEmprestimo
    {
        public TbEmprestimo()
        {
            TbRelacional = new HashSet<TbRelacional>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Objeto { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Cliente { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataDevolucao { get; set; }
        [Unicode(false)]
        public string Imagem { get; set; }

        [InverseProperty("IdEmprestimoNavigation")]
        public virtual ICollection<TbRelacional> TbRelacional { get; set; }
    }
}