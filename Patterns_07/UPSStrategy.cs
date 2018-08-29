namespace Patterns_07
{
    /// <summary>
    /// USP доставка
    /// </summary>
    public class UPSStrategy : IShippingStrategy
    {
        /// <summary>
        /// Расчет доставки
        /// </summary>
        /// <param name="order">заказ</param>
        /// <returns>цена доставки</returns>
        public double Calculate(Order order) => 4;
    }
}
