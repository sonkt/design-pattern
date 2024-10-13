using System.Collections.Generic;

namespace DesignPattern
{
    /// <summary>
    /// Class chứa kết quả kiểm tra ở từng handler
    /// </summary>
    public class CheckResult{
        public bool IsValid { get; set; }
        public List<string>? Messages { get; set; }
    }
}