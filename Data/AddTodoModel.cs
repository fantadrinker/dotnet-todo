namespace BlazorApp.Data;
using System.ComponentModel.DataAnnotations;

public class AddTodoModel
{
  [Required]
  [StringLength(30, ErrorMessage = "Description is too long.")]
  public string Desc { get; set; } = string.Empty;
}