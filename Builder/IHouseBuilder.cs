namespace DesignPattern
{
    /// <summary>
    /// Interface cung cấp phương thức xây dựng từng phần (thuộc tinh) của ngôi nhà
    /// </summary>
    public interface IHouseBuilder
    {
        // Làm móng
        void MakeFoundation();
        // Xây tường
        void BuildWalls();
        // Làm mái
        void MakeRoof();

        // Trả về đối tượng ngôi nhà
        House GetHouse();
    }
}