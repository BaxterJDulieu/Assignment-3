using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Variable
    
    int[,] levelMap = {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7}, // array[0, ?]                                                   0 = nothing
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4}, // array[1, ?]                                                   1 = outside corner
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4}, // array[2, ?]                                                   2 = outside wall
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4}, // array[3, ?]                                                   3 = Inside corner
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3}, //                                                               4 = Inside wall
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5}, //                                                               5 = Standard pellet
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4}, //                                                               6 = Power Pellet
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3}, //                                                               7 = Junction
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };

    int Rows = 15;
    int Columns = 14;


    public GameObject outCorner, outWall, insideCorner, insideWall, pellet, powPellet, junction;
    float align = 0.32f; // aligns all of the wall prefabs to be exacty next to eachother - The calculations were correct 
    

    void Awake()
    {

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                if (levelMap[row, col] == 1)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(outCorner, new Vector3(x, -y, 0), Quaternion.identity);
                }
                else if (levelMap[row, col] == 2)
                {
                    //int count = col;
                    float y = row * align; // swapped x & y
                    float x = col * align;
                    //if (count == 0)
                    //{
                        Instantiate(outWall, new Vector3(x, -y, 0), Quaternion.identity);
                    //}
                }
                else if (levelMap[row, col] == 3)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(insideCorner, new Vector3(x, -y, 0), Quaternion.identity);
                }
                else if (levelMap[row, col] == 4)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(insideWall, new Vector3(x, -y, 0), Quaternion.identity);
                }
                else if (levelMap[row, col] == 5)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(pellet, new Vector3(x, -y, 0), Quaternion.identity);
                }
                else if (levelMap[row, col] == 6)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(powPellet, new Vector3(x, -y, 0), Quaternion.identity); //if (the row is horizontal, rotate the object (if row = this; rotate)
                }
                else if (levelMap[row, col] == 7)
                {
                    float y = row * align;
                    float x = col * align;
                    Instantiate(junction, new Vector3(x, -y, 0), Quaternion.identity);
                }   
            }
        }


    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
