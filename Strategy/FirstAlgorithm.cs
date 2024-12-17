namespace Strategy
{
    /// <summary>
    /// Thuật toán thứ nhất
    /// </summary>
    public class FirstAlgorithm : IAlgorithm
    {
        public void Execute(string? message)
        {
            Console.WriteLine($"Thuật toán thứ nhất thức hiện với dữ liệu: {message}");
        }
    }
}