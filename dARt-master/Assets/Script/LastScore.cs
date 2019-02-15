using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastScore : MonoBehaviour
{

    public static int Score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(700, 70, 100, 20), "Score: " + Score.ToString());
    }

}