using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class movement : MonoBehaviour
{
    public float maxSpeed;
    public float JumpPower;
   

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        //Jump
        if (Input.GetButtonDown("Jump") && !anim.GetBool("isjump"))
        {
            rigid.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            anim.SetBool("isjump", true);
        }
        //Stop speed
        if (Input.GetButtonUp("Horizontal"))
        { rigid.velocity = new Vector2(rigid.velocity.normalized.x*0.5f, rigid.velocity.y);
        }
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if (Mathf.Abs (rigid.velocity.x) < 0.1)
            anim.SetBool("iswalk", false);
        else
            anim.SetBool("iswalk", true);

       
        
    }


        private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "trigger": ScoreText.scoreValue += 10;
                break;
            case "TriggerObject": ScoreText.scoreValue += 20;
                break;

            case "return to main manu": ScoreText.scoreValue = 0;
                break;

                case "maintab": ScoreText.scoreValue = 0;
                break;
        }
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        //move speed
        //moved by key control
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
       
        //maxspeed 
        if (rigid.velocity.x > maxSpeed) //right max speed
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed*(-1)) //left max speed 
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
        //Landing Platform 
        if (rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, Vector3.down * 2, new Color(0, 1, 0));

            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector2.down * 2, LayerMask.GetMask("paltform"));



            if (rayHit.collider != null)
                Debug.Log(rayHit.collider.name);
            {
                if (rayHit.distance < 2.8)
                    anim.SetBool("isjump", false);


            }


        }
    }
}
