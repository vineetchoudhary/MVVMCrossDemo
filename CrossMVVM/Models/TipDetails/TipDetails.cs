using System;
using System.Collections.Generic;
using System.Text;

namespace CrossMVVM.Models.TipDetails
{
    public class TipDetails : ITipDetails
    {
        public int SubTotal { get; set; }
        public int TipAmmount { get; set; }
    }
}
