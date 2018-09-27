using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HierarchyWithTwoDataGrid.Models.Northwind
{
  [Table("Region", Schema = "dbo")]
  public partial class Region
  {
    [Key]
    public int RegionID
    {
      get;
      set;
    }


    [InverseProperty("Region")]
    public ICollection<Territory> Territories { get; set; }
    public string RegionDescription
    {
      get;
      set;
    }
  }
}