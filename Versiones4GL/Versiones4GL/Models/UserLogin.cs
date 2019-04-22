using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Versiones4GL.Models
{

    class UserLogin
    {
        [JsonProperty(PropertyName = "nombre")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "nivel")]
        public string Level { get; set; }

    }
}
