namespace Patterns_07
{
    /// <summary>
    /// Класс расчета цены доставки
    /// </summary>
    public class ShippingCostCalculator
    {
        private IShippingStrategy _strategy;

        /// <summary>
        /// Свойство доставщика
        /// </summary>
        public IShippingStrategy Strategy
        {
            set { _strategy = value; }
        }
        /// <summary>
        /// Расчет цены доставки
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public double Calculate(Order order) => _strategy.Calculate(order);
    }
}
