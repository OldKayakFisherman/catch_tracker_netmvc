using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchTrackerNetMVC.Web.Data.Entities;

[Table("simple_search_index")]
public class SearchIndex
{
    [Key][Column("id")] 
    public int? Id { get; set; }

    [Column("catch_id")]
    public int? CatchId { get; set; }

    [Column("data")] 
    public string? Data { get; set; }

    [Column("catch_detail_id")]
    public int CatchDetailId { get; set; }

    public CatchDetail? CatchDetail { get; set; }


}