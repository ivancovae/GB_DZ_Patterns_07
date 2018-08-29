namespace Patterns_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // доставка по EMS
            var emsStrategy = new EMSStrategy();
            // доставка по USP
            var upsStrategy = new UPSStrategy();
            // доставка по FeDex
            var fedexStrategy = new FEDEXStrategy();

            var shippingCostCalculator = new ShippingCostCalculator();

            // расчет для EMS
            shippingCostCalculator.Strategy = emsStrategy;
            var result = shippingCostCalculator.Calculate(new Order());

            // расчет для USP
            shippingCostCalculator.Strategy = upsStrategy;
            result = shippingCostCalculator.Calculate(new Order());

            // расчет для FeDex
            shippingCostCalculator.Strategy = fedexStrategy;
            result = shippingCostCalculator.Calculate(new Order());
        }
    }
}
