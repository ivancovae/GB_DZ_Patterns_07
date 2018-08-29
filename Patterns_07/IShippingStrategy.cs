namespace Patterns_07
{ 
    /// <summary>
    /// Интерфейс расчета
    /// </summary>
    public interface IShippingStrategy
    {
        /// <summary>
        /// расчет доставки
        /// </summary>
        /// <param name="order">заказ</param>
        /// <returns>цена доставки</returns>
        double Calculate(Order order);
    }
}
