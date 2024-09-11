using OnStyle.Communication.Enums;

namespace OnStyle.Communication.Response;

public class ResponseRegisterRevenueJson
{
    public int Id { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public DateTime ServiceDate { get; set; }
    public decimal ServicePrice { get; set; }
    public string BarberName { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public PaymentType PaymentType { get; set; }
}
