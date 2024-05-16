
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CatchTrackerNetMVC.Web.Data.Entities;

[Table("catch_details")]
public class CatchDetail
{

    [Key][Column("id")] 
    public int? Id { get; set; }

    [Column("latitude")] 
    public double Latitude { get; set; }

    [Column("longitude")] 
    public double Longitude { get; set; }
    
    [Column("catch_date")] 
    public DateTime CatchDate{ get; set; }
    
    [Column("species")] 
    public string Species{ get; set; }

    [Column("weight")] 
    public double Weight { get; set; }
    
    [Column("water_temperature")] 
    public double WaterTemperature { get; set; }

    [Column("water_depth")] 
    public double WaterDepth { get; set; }

    [Column("sky_conditions")] 
    public string? SkyConditions{ get; set; }
    
    [Column("air_temperature")] 
    public double AirTemperature { get; set; }

    [Column("terminal_tackle")] 
    public string? TerminalTackle{ get; set; }
    
    [Column("technique")] 
    public string? Technique { get; set; }
    
    [Column("bait")] 
    public string? Bait { get; set; }

    [Column("rod")] 
    public string? Rod { get; set; }

    public Collection<Media>? Media { get; set; }

    public CatchDetail(double latitude, double longitude, DateTime catchDate, string species)
    {
        Latitude = latitude;
        Longitude = longitude;
        CatchDate = catchDate;
        Species = species;
    }
    
   
}