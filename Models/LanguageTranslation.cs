using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedOptimisationApp.Models;

public class LanguageTranslation
{
    [PrimaryKey]
    public Guid LanguageId { get; set; } // Reference to Ref_Language.Id

    [Required]
    [StringLength(2)]
    public string LanguageCode { get; set; } // NOT NULL

    [Required]
    [StringLength(255)]
    public string TranslatedDescription { get; set; } // NOT NULL
}