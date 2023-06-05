namespace code.Entities
{
    public class PaymentService
    {
        public IOnlinePaymentService OnlinePaymentService { get; set; }

        public PaymentService(IOnlinePaymentService onlinePaymentService)
        {
            OnlinePaymentService = onlinePaymentService;
        }
    }
}