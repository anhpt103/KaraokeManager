namespace KaraokeManage.Models
{
    public class LoaiHangModel
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public bool IsDelete { get; set; }
        public string IsDelete_Text { get; set; }
    }
}
