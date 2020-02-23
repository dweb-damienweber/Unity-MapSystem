using UnityEngine;
using MapSystem;

public class TestWorld : MonoBehaviour
{
    #region System methods

    private void Awake()
    {
        // Maps creation
        _map = new Map<int>(_mapWidth, _mapHeight, () => 0);
        _cellMap = new Map<Cell>(_mapWidth, _mapHeight, () => new Cell(_cellMap, false, 0));

        // Maps visualization
        MapCellVisualizer();
        MapIntVisualizer();
    }

    #endregion


    #region Methods

    /// <summary>
    /// Exemple to display an int map
    /// </summary>
    private void MapIntVisualizer()
    {
        for (int y = 0; y < _mapHeight; y++)
        {
            for (int x = 0; x < _mapWidth; x++)
            {
                // Get the value at this position
                int value = _map.GetAt(y, x);

                Debug.Log($"Cell x:{x}y:{y} is {value}", this);

                // Display it like you want (Text, ...)
            }
        }
    }

    /// <summary>
    /// Exemple to display a cell map (custom type)
    /// </summary>
    private void MapCellVisualizer()
    {
        for (int y = 0; y < _mapHeight; y++)
        {
            for (int x = 0; x < _mapWidth; x++)
            {
                // Get the value at this position
                Cell cell = _cellMap.GetAt(y, x);

                Debug.Log($"Cell x:{x}y:{y} Is walkable ? {cell.IsWalkable} Floor type ? {cell.FloorType}", this);

                // Display it like you want (Cell prefab, ...)
            }
        }
    }

    #endregion


    #region Private fields

    private Map<int> _map;
    private Map<Cell> _cellMap;

    [Header("Map size")]
    [SerializeField] private int _mapWidth = 5;
    [SerializeField] private int _mapHeight = 5;

    #endregion
}
