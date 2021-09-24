using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deltesdore : MonoBehaviour
{
    //ResetDestroyOnLoad(gameObject);
    protected Scene defaultScene;
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    public void ResetDestroyOnLoad()
    {
        
        
         if (SceneManager.GetActiveScene().name =="defalut map")
         {
            var obj = FindObjectsOfType<Dontdestoy>();
            //SceneManager.MoveGameObjectToScene(gameObject, defaultScene);
            //Destroy(gameObject);
            gameObject.GetComponent<Dontdestoy>().enabled = true;
         }

        if (SceneManager.GetActiveScene().name ==  "dark map")
        {
            var obj = FindObjectsOfType<Dontdestoy>();
            //SceneManager.MoveGameObjectToScene(gameObject, defaultScene);
            //Destroy(gameObject);
            gameObject.GetComponent<Dontdestoy>().enabled = true;
        }

        if (SceneManager.GetActiveScene().name == "sky map")
        {
            var obj = FindObjectsOfType<Dontdestoy>();
            //SceneManager.MoveGameObjectToScene(gameObject, defaultScene);
            //Destroy(gameObject);
            gameObject.GetComponent<Dontdestoy>().enabled = true;
        }


        if (SceneManager.GetActiveScene().name == "main")


        { 
        
            gameObject.GetComponent<Dontdestoy>().enabled = false;
          
        }
    }
        
}


