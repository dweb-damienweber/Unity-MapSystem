using System;

namespace MapSystem
{
    public class Map<TMapObject>
    {
        #region Constructors

        public Map(int width, int height, Func<TMapObject> createMapObject)
        {
            _width = width;
            _height = height;

            _map = new TMapObject[_width, _height];

            InitMap(createMapObject);
        }

        #endregion


        #region Methods

        /// <summary>
        /// Create a base map, default values
        /// </summary>
        private void InitMap(Func<TMapObject> createMapObject)
        {
            for (int y = 0; y < _height; y++)
                for (int x = 0; x < _width; x++)
                    _map[x, y] = createMapObject();
        }

        /// <summary>
        /// Return content of this position of the map
        /// </summary>
        public TMapObject GetAt(int width, int height)
        {
            return _map[width, height];
        }

        #endregion


        #region Private fields

        private int _width;
        private int _height;

        private TMapObject[,] _map;

        #endregion
    }
}