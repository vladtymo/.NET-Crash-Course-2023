using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examproject
{
    internal class CheckFile
    {
        public void Create()
        {
            JObject data = new JObject();
            data["Pizza"] = new JArray();
            data["Fillings"] = new JArray();

            File.WriteAllText("Pizza.json", data.ToString());
        }
    }
}
