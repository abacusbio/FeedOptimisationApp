using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedOptimisationApp.Models;

public class RefSpecies
{
    [PrimaryKey]
    public Guid Id { get; set; } // Primary key

    [Required]
    public string Name { get; set; } // NOT NULL
}