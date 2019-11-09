using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRock : MonoBehaviour
{
    public GameObject rockPrefab;
    public float x;
    private float y = -3.03f;
    private Vector3 rockPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Calls the function to spawn the rocks at the start
        for (int i = 0; i < 10; i++)
        {
            SpawnRocks();
        }
    }

    void Update()
    {

    }

    void SpawnRocks()
    {
        //Sets range for rocks to spawn in
        x = Random.Range(-5.5f, 5.5f);

        //Sets position for the rocks to spawn at
        rockPosition = new Vector3(x, y, 0);

        //Spawns the rocks
        Instantiate(rockPrefab, rockPosition, Quaternion.identity);
    }
}
