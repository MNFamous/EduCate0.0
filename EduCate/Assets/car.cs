using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        StartCoroutine(delete());
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -7)
        {
            Destroy(gameObject);
        }
        
    }
    IEnumerator delete()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
