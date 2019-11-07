using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject character; // GameObject camera follows

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set the x position of the camera to the character, but leave the y and z position unchanged.
        // Get character x
        float x = character.transform.position.x;

        // Get camera y and z (since these will not change)
        float y = transform.position.y;
        float z = transform.position.z;

        // Move camera to that position
        transform.position = new Vector3(x, y, z);
    }
}
