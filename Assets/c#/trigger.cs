using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    public GameObject dr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerStay2D(Collider2D tri) 
    {
        
        if (tri.gameObject.tag == "Player")
        {
            
            print("on");
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.92f, 0.016f, 0.5f);
            //GetComponent<door>().doorshow.SetActive(false);
            if (dr != null)
            {
                dr.SetActive(false);
            }
        }
       
    }
    public void OnTriggerExit2D(Collider2D tri) 
    {
        if (tri.gameObject.tag == "Player")
        {
            print("off");
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.92f, 0.016f, 1);
            if (dr != null)
            {
                dr.SetActive(true);
            }
        }
    }

}
