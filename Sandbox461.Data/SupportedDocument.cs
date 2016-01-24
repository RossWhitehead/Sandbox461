using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class SupportedDocument
    {
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
    }
}