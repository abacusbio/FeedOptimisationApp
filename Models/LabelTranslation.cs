﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedOptimisationApp.Models;

public class LabelTranslation
{
    [PrimaryKey]
    public int TranslationId { get; set; } // Primary key

    [Required]
    public int LabelId { get; set; } // Reference to Labels.Id

    [Required]
    [StringLength(2)]
    public string LanguageCode { get; set; } // NOT NULL

    [Required]
    [StringLength(255)]
    public string TranslatedText { get; set; } // NOT NULL
}