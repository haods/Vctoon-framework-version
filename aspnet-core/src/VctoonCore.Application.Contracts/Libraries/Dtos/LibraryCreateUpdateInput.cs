using System.ComponentModel.DataAnnotations;
using VctoonCore.Enums;

namespace VctoonCore.Libraries.Dtos;

[Serializable]
public class LibraryCreateUpdateInput
{
    /// <summary>
    /// 
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Required]
    [MinLength(1)]
    public string[] Paths { get; set; }

    public LibraryType LibraryType { get; set; }
}