using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    internal class Robot : Identifier
    {
        private string model;
        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }
        public string Id { get;}
        public string Model { get; set; }
    }
}
