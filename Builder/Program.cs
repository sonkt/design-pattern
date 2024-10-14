namespace DesignPattern
{
    /// <summary>
    /// Builder Pattern là mật Pattern thuộc nhóm Creational Pattern trong Gang Of Four.
    /// Buidler pattern được sử dụng khi việc khởi tạo một đối tượng quá phức tạp với nhiều thuộc tính.
    /// Builder pattern giúp tạo đối tượng theo từng bước để cung cấp giá trị cho từng thuộc tính hoặc 1 nhóm các thuộc tính một cách clear.
    /// Builder dịch ra có nghĩa là xây dựng, vì vậy trong ví dụ này, mình sẽ dùng đúng khái niệm xây dựng mốt ngôi nhà để minh họa.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Dòng này là để show tiếng Việt font Unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo đối tượng builder
            var builder = new HouseBuilder();
            // Khai báo đối tượng chỉ đạo thi công. Đối tượng này nếu ko dùng thì dùng thẳng Builder trong này luôn,
            var dicrector = new BuidlerDirector(builder);
            // Đối tượng director sẽ tạo ngồi nhà
            var house = dicrector.Construct();
            // Báo cáo kết quả
            Console.WriteLine(house.ToString());
        }
    }
}