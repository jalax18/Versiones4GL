namespace Versiones4GL.Common.Models

{
    using Newtonsoft.Json;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;



public class Maccliente

{

    [Key]

    public int MacclienterId { get; set; }



    [Required(ErrorMessage = "The field {0} is requiered.")]

    [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]

    [Index("Macserver_Version_Index", IsUnique = true)]

    public string Version { get; set; }



   // [JsonIgnore]

   // public virtual ICollection<Station> Stations { get; set; }

}
