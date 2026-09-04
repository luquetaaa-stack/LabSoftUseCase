using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models;
[Table("Tarefa")]
public partial class Tarefa
{
    [Key]
    public int Codigo { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime DataPlanejada { get; set; }

    public DateTime? DataIniciada { get; set; }

    public DateTime? DataFinalizada { get; set; }

    public DateTime? DataCancelada { get; set; }

    public string StatusTarefa { get; set; } = null!;

    public string Prazo { get; set; } = null!;

    public int FuncionarioId { get; set; }

    public virtual Funcionario? Funcionario { get; set; } = null!;
}