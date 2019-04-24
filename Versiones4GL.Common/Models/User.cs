
namespace Versiones4GL.Common.Models
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    using System.ComponentModel.DataAnnotations.Schema;

    public class Estacion

    {

        [Key]

        public int EstacionId { get; set; }



        [Display(Name = "NameES")]

        [Required(ErrorMessage = "The field {0} is requiered.")]

        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]

        public string NameES { get; set; }



       

        [Display(Name = "Province")]

        [Required(ErrorMessage = "The field {0} is requiered.")]

        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]

        public string Province { get; set; }


        
        public int VersionXadId { get; set; }



        [JsonIgnore]

        public virtual VersionXad VersionXad { get; set; }



    }


}
