using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindFramework.API.ErrorDtos
{
    public class ErrorDto
    {
        public List<string> Errors { get; set; }
        public string Status { get; set; }
    }
}
