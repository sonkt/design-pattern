namespace DesignPattern
{
    /// <summary>
    /// Lớp builder cung cấp các phương thức xây từng phần ngôi nhà và trả về thông tin ngôi nhà.
    /// </summary>
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();
        public void MakeFoundation()
        {
            _house.Foundation = "Móng bê tông cốt thép";
        }

        public void BuildWalls()
        {
            _house.Walls = "Tường gạch 20 với khung dầm bê tông";
        }

        public void MakeRoof()
        {
            _house.Roof = "Mái gỗ kết hợp chống nóng";
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}