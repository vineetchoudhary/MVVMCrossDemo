using System;
using System.Collections.Generic;
using System.Text;

namespace CrossMVVM.Services
{
    public interface ICalculationService
    {
        int TipAmmount(int subTotle, int generosity);
    }
}
