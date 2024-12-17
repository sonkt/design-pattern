namespace Strategy
{
    /// <summary>
    /// Thuật toán thứ 2
    /// </summary>
    public class SecondAlgorithm : IAlgorithm
    {
        public void Execute(string? message)
        {
            Console.WriteLine($"Thuật toán thứ hai thức hiện với dữ liệu: {message}");
        }
    }
}