using UnityEngine;
using System.Collections;

public class GameHandler : MonoBehaviour {

    [Header("Voxel settings")]
    public float size = 1;

    public int sizeX = 10;
    public int sizeZ = 10;
    [Tooltip("Height of the terrain.")]
    public int sizeY = 2;


    Material blockmaterial;
    GameObject groundVoxel;

	// Use this for initialization
	void Start () {

        blockmaterial = Resources.Load<Material>("Materials/brickTexture");
        groundVoxel = Resources.Load<GameObject>("Cube");

        GameObject parent = new GameObject();

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                for (int k = 0; k < sizeZ; k++)
                {
                    GameObject cube = (GameObject)Instantiate(groundVoxel, new Vector3(i * size, j * size, k * size), Quaternion.identity, parent.transform);
                    cube.transform.localScale *= size;
                }
            }
        }
	}
	
}
