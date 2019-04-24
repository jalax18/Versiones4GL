namespace Versiones4GL.Common.Models
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    using System.ComponentModel.DataAnnotations.Schema;

    public class Station

    {

        [Key]

        public int stationId { get; set; }



        [Display(Name = "Name")]

        [Required(ErrorMessage = "The field {0} is requiered.")]

        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]

        public string Name { get; set; }


        [Display(Name = "Province")]

        [Required(ErrorMessage = "The field {0} is requiered.")]

        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]

        public string Province { get; set; }


        public int UserTypeId { get; set; }

        [JsonIgnore]

        public virtual UserType UserType { get; set; }

        public int XadId { get; set; }

        [JsonIgnore]

        public virtual Xad Xad { get; set; }
    }


}
