using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            var obj = FindObjectsOfType<audiobgm>();


            if (obj.Length < 1)
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

}