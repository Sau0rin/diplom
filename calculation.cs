using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class calculation
    {
        public string Amortization_bux(double quantity, double cost, int spi, double liquidated_cost, double planned_production, double real_production, double coefficient_bux, string method)
        {
            if (method =="linear_bux")
            {
                return (quantity * (cost - liquidated_cost) / spi).ToString();

            }
            else if (method=="remains")
            {
                return (quantity * (cost - liquidated_cost) / spi * coefficient_bux).ToString();
            }
            else if (method=="write_downs")
            {
                return (quantity * (cost - liquidated_cost) * (real_production / planned_production)).ToString();
            }
            return "error";
        }
        public string Amortization_nal(double quantity, double cost, int spi, double coefficient_nal, double standart_amor, string method)
        {
            if (method=="linear_nal")
            {
                return (quantity * cost * (1.0 / spi) * coefficient_nal).ToString();
            }
            else if (method=="non_linear_nal")
            {
                return (quantity * cost * (standart_amor * 0.01) * coefficient_nal).ToString();
            }
            return "error";
        }
    }
}
