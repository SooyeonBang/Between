using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movetocredit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("credit"))
        {

            SceneManager.LoadScene("CREDIT");
        }

    }
}
