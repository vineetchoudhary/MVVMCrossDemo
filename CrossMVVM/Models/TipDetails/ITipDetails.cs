using System;
using System.Collections.Generic;
using System.Text;

namespace CrossMVVM.Models.TipDetails
{
    public interface ITipDetails
    {
        int SubTotal { get; set; }
        int TipAmmount { get; set; }
    }
}
