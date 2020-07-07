using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    float timer;
    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameControl>().gameHasEnded == false)
        {
            timer += (Time.deltaTime * 17.5f);
            scoretext.text = ((int)(timer)).ToString();
        }
        
    }
}
