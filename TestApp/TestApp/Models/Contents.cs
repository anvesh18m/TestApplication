using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    class Contents
    {
        public int ContentID { get; set; }
        public string ContentData { get; set; }
        public string ContentArtical { get; set; }
        public string ContentImage { get; set; }
        public Contents(int _contentID, string _contentData, string _contentArtical, string _contentImage)
        {
            this.ContentID = _contentID;
            this.ContentData = _contentData;
            this.ContentArtical = _contentArtical;
            this.ContentImage = _contentImage;
        }
    }
}
