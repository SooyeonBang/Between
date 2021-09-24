using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dontdestoy : MonoBehaviour
{

    //[SerializeField]
    //private GameObject playerObject;
    // Start is called before the first frame update
    private void Awake()
    {
        var obj = FindObjectsOfType<Dontdestoy>();


        if (obj.Length == 0) 
        {
            DontDestroyOnLoad(gameObject);
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







       


    





