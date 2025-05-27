public class TipRecord
{
    public int TableId { get; set; }
    public decimal BillAmount { get; set; }
    public decimal TipAmount { get; set; }
    public int TipPercent { get; set; }
    public string Email { get; set; }
    public int Rating { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool IsActive { get; set; }
}
