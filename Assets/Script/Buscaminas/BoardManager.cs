using UnityEngine;

namespace Script.Buscaminas
{
    public class BoardManager : MonoBehaviour
    {
        public GameObject cellPrefab;
        public int rows = 5;
        public int columns = 5;
        public int mineCount = 5;

        private Cell[,] _grid;

        public void GenerateBoard()
        {
            _grid = new Cell[rows, columns];
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    GameObject cell = Instantiate(cellPrefab, new Vector3(x, -y, 0), Quaternion.identity);
                    cell.transform.SetParent(transform);
                    _grid[y, x] = cell.GetComponent<Cell>();
                    _grid[y, x].Init(x, y);
                }
            }
            PlaceMines();
        }

        private void PlaceMines()
        {
            int minesPlaced = 0;
            while (minesPlaced < mineCount)
            {
                int x = Random.Range(0, columns);
                int y = Random.Range(0, rows);
                if (!_grid[y, x].isMine)
                {
                    _grid[y, x].SetMine();
                    minesPlaced++;
                }
            }
        }
    }
}