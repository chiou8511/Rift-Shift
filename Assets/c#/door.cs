using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject doorshow;
    // Start is called before the first frame update
    void Start()
    {
        doorshow.SetActive(true);
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
    public void  d()
    {
        
        //this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.92f, 0.016f, 1);
    }
}
