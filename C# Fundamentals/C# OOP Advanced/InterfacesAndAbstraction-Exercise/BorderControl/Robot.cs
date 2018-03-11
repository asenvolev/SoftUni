using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Id { get; private set; }
        public string Model { get; private set; }
        public Robot(string model, string id)
        {
            this.Id = id;
            this.Model = model;
        }
    }
}
