using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public LivesData l;
    public Image lifeImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Calls the function to get the current amount of lives
    void Update()
    {
        l.GetLives();
    }
}
