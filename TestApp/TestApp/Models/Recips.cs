using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    class Recips
    {
        public int RecipsID { get; set; }
        public string RecipsName { get; set; }
        public string RecipsImage { get; set; }
        public Recips(int _recipsID, string _recipsName, string _recipsImage)
        {
            this.RecipsID = _recipsID;
            this.RecipsName = _recipsName;
            this.RecipsImage = _recipsImage;
        }
    }
}
