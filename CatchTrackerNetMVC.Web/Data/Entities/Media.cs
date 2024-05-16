using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchTrackerNetMVC.Web.Data.Entities;

[Table("catch_media")]
public class Media
{
    [Key][Column("id")] 
    public int? Id { get; set; }
    
    [Column("file_size")]
    public int? FileSize { get; set; }

    [Column("filename")]
    public string? Filename { get; set; }
    
    [Column("extension")]
    public string? Extension { get; set; }
    
    [Column("mimetype")]
    public string? MimeType { get; set; }
    
    [Column("upload_date")]
    public DateTime? UploadDate { get; set; }
    
    [Column("catch_detail_id")]
    public int CatchDetailId { get; set; }

    public CatchDetail? CatchDetail { get; set; }

}