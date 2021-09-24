using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("return"))
        {

          
            SceneManager.LoadScene("default map");
           
        }

        if (collision.gameObject.CompareTag("return"))
        {

            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
           

        }
    }
}
