using System;
using Newtonsoft.Json;

namespace BlogLabModels.Exception
{
    public class ApiException
    {
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this)
;        }
    }
}
