namespace DesignPattern
{
    /// <summary>
    /// Lớp director để chỉ đạo việc xây nhà. Nếu ko dùng thì chủ nhà hoặc chủ đầu tư (program) tự đi mà chỉ đạo xây nhà.
    /// </summary>
    public class BuidlerDirector
    {
        private readonly IHouseBuilder _houseBuilder;
        public BuidlerDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public House Construct()
        {
            _houseBuilder.MakeFoundation();
            _houseBuilder.BuildWalls();
            _houseBuilder.MakeRoof();
            return _houseBuilder.GetHouse();
        }
    }
}