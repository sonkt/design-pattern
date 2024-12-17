namespace Singleton;

    public class Singleton
    {
        // Biến chứa object để đảm bảo tính duy nhất
        private static Singleton _instance;
        // Biến chứa khóa để đảm bảo tạo object không bị trùng bởi các thread trong đa luồng
        private static readonly object _lock = new object();

        private string _name;

        // Constructor private để tránh tạo instance từ bên ngoài
        private Singleton() { }

        // Thuộc tính trả về Object. Nếu chưa có sẽ tạo luôn bên trong.
        public static Singleton Instance
        {
            get
            {
                // Check xem install đã tạo chưa
                if (_instance == null)
                {
                    // Lock để đảm bảo an toàn trong môi trường đa luồng
                    lock (_lock)
                    {
                        // Check instance lần nữa để đảm bảo nó null
                        if (_instance == null)
                        {
                            // khởi tạo đối tượng.
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
        public void SetName(string name)
        {
            _name = name;
        }
        // Method in ra câu thông báo
        public void PrintMessage()
        {
            Console.WriteLine($"Đây là tên của Object: {_name}");
        }
    }
