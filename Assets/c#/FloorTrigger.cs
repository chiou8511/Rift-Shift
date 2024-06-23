using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FloorTrigger : MonoBehaviour
{
    public GameObject fl;
    public GameObject flHIDE;
    // Start is called before the first frame update
    void Start()
    {
        flHIDE.SetActive(false);
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
            //this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.92f, 0.016f, 0.5f);
            //GetComponent<door>().doorshow.SetActive(false);
            if (fl != null)
            {
                fl.SetActive(true);
            }
        }

    }
    /*public void OnTriggerExit2D(Collider2D tri)
    {
        if (tri.gameObject.tag == "Player")
        {
            print("off");
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.92f, 0.016f, 0);
            if (fl != null)
            {
                fl.SetActive(false);
            }
        }
    }*/

}
