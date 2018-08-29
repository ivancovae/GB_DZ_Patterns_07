namespace Patterns_07
{
    /// <summary>
    /// FeDex доставка
    /// </summary>
    public class FEDEXStrategy : IShippingStrategy
    {
        /// <summary>
        /// Расчет доставки
        /// </summary>
        /// <param name="order">заказ</param>
        /// <returns>цена доставки</returns>
        public double Calculate(Order order) => 5;
    }
}
