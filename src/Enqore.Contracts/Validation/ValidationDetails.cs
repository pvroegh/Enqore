using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enqore.Contracts.Validation;
public class ValidationDetails
{
    public Dictionary<string, string[]>? Errors { get; set; } 
}
