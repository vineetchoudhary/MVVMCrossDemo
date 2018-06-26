using System;
using System.Collections.Generic;
using System.Text;

namespace CrossMVVM.Services
{
    public class CalculationService: ICalculationService
    {
        int ICalculationService.TipAmmount(int subTotle, int generosity)
        {
            return (int)(subTotle * (((double)generosity) / 100.0));
        }
    }
}
