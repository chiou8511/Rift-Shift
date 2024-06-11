using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class playermove : MonoBehaviour
{
    private Rigidbody2D rb2;
    private SpriteRenderer sp;
    public static int trafficlight_touch = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb2 != null)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb2.velocity = new Vector2(-5, rb2.velocity.y);
                sp.flipX = true;
            }
           
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb2.velocity = new Vector2(5, rb2.velocity.y);
                sp.flipX = false;
            }
            
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb2.velocity = new Vector2(rb2.velocity.x, 5);
            }
           
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb2.velocity = new Vector2(rb2.velocity.x, -5);
            }
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Goal")
        {
            print("rescenes");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
