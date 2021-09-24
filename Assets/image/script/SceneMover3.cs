using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneMover3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("sky"))
        {
           
            SceneManager.LoadScene("sky map");
           
        }


        if (collision.gameObject.CompareTag("sky"))
        {

         
            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        }






    }





}