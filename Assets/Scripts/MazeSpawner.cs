using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeSpawner : MonoBehaviour
{
    public GameObject CellPrefab;
    // Start is called before the first frame update
    void Start()
    {
        MazeGenerator generator = new MazeGenerator();
        MazeGeneratorCell[,] maze = generator.GeneraneMaze();

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                Cell c = Instantiate(CellPrefab, new Vector2(x, y), Quaternion.identity).GetComponent<Cell>();

                c.LeftWall.SetActive(maze[x, y].WallLeft);
                c.BottomWall.SetActive(maze[x, y].WallBottom);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
