namespace DesignPattern
{
    /// <summary>
    /// Class để tạo Object
    /// </summary>
    public class House
    {
        public string Foundation { get; set; } = ""; // Móng
        public string Walls { get; set; } = ""; // Tường
        public string Roof { get; set; } = ""; // Mái

        // In thông tin ngôi nhà. Bạn có thể sử dụng 1 method Print hoặc Display thay vì override method ToString này
        public override string ToString()
        {
            return $"Ngôi nhà đang xây được mô tả như sau: {Foundation}. {Walls}. {Roof}.";
        }
    }
}