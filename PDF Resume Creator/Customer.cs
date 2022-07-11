using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace PDF_Resume_Creator
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        
    
    }
}
