using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destory : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject;
   
    // Start is called before the first frame update
    private void Awake()
    {
        
        if (SceneManager.GetActiveScene().name == "main")
        {
            Destroy(gameObject);
        }
    }

   


    // Update is called once per frame

}
