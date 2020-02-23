namespace MapSystem
{
    public class Cell
    {
        #region Properties

        public bool IsWalkable
        {
            get;
            set;
        }

        public int FloorType
        {
            get;
            set;
        }

        /// <summary>
        /// The parent of this cell
        /// </summary>
        public Map<Cell> Map
        {
            get;
            private set;
        }

        #endregion

    
        #region Constructors

        public Cell(Map<Cell> map, bool isWalkable, int floorType)
        {
            Map = map;
            IsWalkable = isWalkable;
            FloorType = floorType;
        }

        #endregion
    }
}