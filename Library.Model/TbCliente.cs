﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Library.Model
{
    [Table("tb_Cliente")]
    public partial class TbCliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(14)]
        [Unicode(false)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Cidade { get; set; }
        [Unicode(false)]
        public string Imagem { get; set; }
    }
}