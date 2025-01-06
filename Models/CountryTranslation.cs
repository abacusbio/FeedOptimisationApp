using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedOptimisationApp.Models;

public class CountryTranslation
{
    [PrimaryKey]
    public Guid CountryId { get; set; } // Reference to Ref_Country.Id

    [Required]
    [StringLength(2)]
    public string LanguageCode { get; set; } // NOT NULL

    [Required]
    [StringLength(255)]
    public string TranslatedDescription { get; set; } // NOT NULL
}