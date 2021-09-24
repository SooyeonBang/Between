using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
   


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("return to main manu"))
        {
            SceneManager.LoadScene("main");

        }


    } 



    
}