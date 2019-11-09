using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public LivesData l;
    Image meter;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the image component for the life bar
        meter = GetComponent<Image>();

        //Fills the life bar fully
        meter.fillMethod = Image.FillMethod.Horizontal;
        meter.type = Image.Type.Filled;
        meter.fillAmount = 1;
    }

    void Update()
    {
        //Fills the life bar by the amount of player lives divided by 5
        meter.fillAmount = (float)l.GetLives() / 5;
    }
}
