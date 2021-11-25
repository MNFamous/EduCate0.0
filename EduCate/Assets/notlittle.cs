using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notlittle : MonoBehaviour
{
    // Start is called before the first frame update
    public float runSpeed = 10.0f;
    Rigidbody2D body;
    float horizontal;
    string galp;
    int i = 2;
    Animator anim;
    public GameObject over;
    bool show = false;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("pressed");
        }
        if(horizontal == -1)
        {
            transform.eulerAngles = Vector3.up * 180;
        }
        if (horizontal == 1)
        {
            transform.eulerAngles = Vector3.up * 0;
        }
    }
    private void FixedUpdate()
    {
        anim.SetBool("moving", false);
        if(horizontal == 1 || horizontal == -1)
        {
            anim.SetBool("moving", true);
        }
        body.velocity = new Vector2(horizontal * runSpeed, 0);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        new WaitForSeconds(1f);
        if (collision.gameObject.name == "carredanim(Clone)")
        {
            galp = "galp-Sheet_0" + " " + "(" + i + ")";
            if (i >= -2)
            {
                i--;
            }
            if (i <= -1 && show == false)
            {
                show = true;
                GameObject gameover = GameObject.Instantiate(over, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            }
            Destroy(GameObject.Find(galp));
        }
        if (collision.gameObject.name == "cargreenanim(Clone)")
        {
            galp = "galp-Sheet_0" + " " + "(" + i + ")";
            if (i >= -2)
            {
                i--;
            }
            if (i <= -1 && show == false)
            {
                show = true;
                GameObject gameover = GameObject.Instantiate(over, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            }
            Destroy(GameObject.Find(galp));
        }
    }
}
