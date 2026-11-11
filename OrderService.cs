using System;


namespace DominonaPizzaKiosk
{
    public class OrderService
    {
        public Order[] Orders = new Order[100];
        public int OrderCount = 0;
        public int NextOrderNumber = 1001;

        public Order CreateOrder(Cart cart, double payment)
        {
            if (OrderCount >= Orders.Length)
            {
                return null;
            }

            Order order = new Order(
                NextOrderNumber,
                cart.GetItemsCopy(),
                cart.GetTotal(),
                payment
            );

            Orders[OrderCount] = order;

            OrderCount++;
            NextOrderNumber++;

            return order;
        }

        public Order GetOrder(int index)
        {
            return Orders[index];
        }
    }
}
