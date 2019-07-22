using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CambiarEscena : MonoBehaviour{

    public GameObject canvas;

    float secondsCounter = 0;
    float secondsToCount = 10;
    void Update()
    {
        secondsCounter += Time.deltaTime;
        if (secondsCounter >= secondsToCount)
        {
            Destroy(canvas);
        }
        
    }
   

}
