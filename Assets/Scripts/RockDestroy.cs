using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Rock"))
        {
            //Destroys the rock object
            GameObject.Destroy(g);

            // Instantiates an explosion prefab in the place of the rock
            GameObject exp = (GameObject)Instantiate(explosionPrefab, g.transform.position, Quaternion.identity);

            // Makes sure explosion destroyed in 2 seconds
            GameObject.Destroy(exp, 2);

            //Decrements the Lives counter

        }
    }
}
