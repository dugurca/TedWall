using UnityEngine;

namespace Assets._Project.Scripts
{
    public class WallGenerator : MonoBehaviour
    {
        public GameObject Brick;

        void Start () {
            GenerateWall(20, 40);
        }

        void GenerateWall(int numRows, int numCols)
        {
            Vector3 startPos = new Vector3(-numCols, 0.5f, numCols);
            for (int row = 0; row < numRows; row++)
            {
                Vector3 bulge = row%2 == 0 ? Vector3.left : Vector3.zero;
                for (int col = 0; col < numCols; col++)
                {
                    Vector3 pos = startPos + new Vector3(col * 3, row, 0) + bulge;
                    Instantiate(Brick, pos, Quaternion.identity);
                }
            }
        }
    }
}
