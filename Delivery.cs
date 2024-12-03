namespace Exceptions
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Adress {  get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public override string ToString()
        {
            return $"{{\nId: {Id}   \nCustomerName: {CustomerName}\nAdress: {Adress} \nStatus: {DeliveryStatus} \n}}";
        }
    }
}