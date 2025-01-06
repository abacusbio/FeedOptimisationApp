using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FeedOptimisationApp.Models;

public class Feed
{
    [PrimaryKey]
    public Guid Id { get; set; } // Primary key

    [Required]
    public string Name { get; set; } // NOT NULL

    public int DryMatterPercentage { get; set; } // NOT NULL
    public int MEMcalKg { get; set; } // NOT NULL
    public int MEMJKg { get; set; } // NOT NULL
    public int TDNPercentage { get; set; } // NOT NULL
    public int CPPercentage { get; set; } // NOT NULL
    public int DCPPercentage { get; set; } // NOT NULL
}