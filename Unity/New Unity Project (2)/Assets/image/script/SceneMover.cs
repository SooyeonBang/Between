using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("coin"))
        {
           
            SceneManager.LoadScene("dark map");
        }

        if (collision.gameObject.CompareTag("coin"))
        {
            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
          
        }
    }
}
