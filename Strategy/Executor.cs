namespace Strategy
{
    /// <summary>
    /// Lớp điều khiển và thực thi các thuật toán
    /// </summary>
    public class Executor
    {
        private IAlgorithm? _algorithm;
        private string? _data;
        public void SetAlgorithm(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }
        public void SetData(string data)
        {
            _data = data;
        }
        public void Execute()
        {
            if (_algorithm == null)
            {
                Console.WriteLine("Chưa thiết lập thuật toán cho chương trình");
            }
            else
            {
                _algorithm.Execute(_data);
            }
        }
    }
}