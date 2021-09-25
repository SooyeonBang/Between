using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class audiobgm : MonoBehaviour





{

    void Start()
    {
        var obj = FindObjectsOfType<audiobgm>();


        if (obj.Length < 2)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            //var objs = FindObjectsOfType<gameObject>();
            // if (objs.Length == 1)
            // {

            Destroy(gameObject);
        }
      


    }
}
