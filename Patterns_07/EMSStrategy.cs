namespace Patterns_07
{
    /// <summary>
    /// EMS доставка
    /// </summary>
    public class EMSStrategy : IShippingStrategy
    {
        /// <summary>
        /// Расчет доставки
        /// </summary>
        /// <param name="order">заказ</param>
        /// <returns>цена доставки</returns>
        public double Calculate(Order order) => 3;
    }
}
