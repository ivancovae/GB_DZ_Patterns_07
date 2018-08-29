namespace Patterns_07
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Тип доставщика
        /// </summary>
        public ShippingOptions ShippingMethod { get; set; }
        /// <summary>
        /// Адрес доставки
        /// </summary>
        public Address Destination { get; set; }
        /// <summary>
        /// Адрес отправителя
        /// </summary>
        public Address Origin { get; set; }
    }
}
