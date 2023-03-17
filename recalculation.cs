using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class recalculation
    {
        public string Amortization_bux(double residual_cost, int spi, double planned_production, double real_production, double coefficient_bux, string method)
        {
            if (method == "linear_bux")
            {
                return (residual_cost  / spi).ToString();

            }
            else if (method == "remains")
            {
                return (residual_cost / spi * coefficient_bux).ToString();
            }
            else if (method == "write_downs")
            {
                return (residual_cost  * (real_production / planned_production)).ToString();
            }
            return "error";
        }
        public string Amortization_nal(double residual_cost, int spi, double coefficient_nal, double standart_amor, string method)
        {
            if (method == "linear_nal")
            {
                return (residual_cost * (1.0 / spi) * coefficient_nal).ToString();
            }
            
            else if (method == "non_linear_nal")
            {
                return (residual_cost * (standart_amor * 0.01) * coefficient_nal).ToString();
            }
            return "error";
        }
    }
}
