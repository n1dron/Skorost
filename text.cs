using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skorost
{
    internal class text
    {
        public void exel(chek user)
        {
            string json = JsonConvert.SerializeObject(user);
            File.WriteAllText(" ", json);
        }
    }
}
