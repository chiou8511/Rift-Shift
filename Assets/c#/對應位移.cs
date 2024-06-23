using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 對應位移 : MonoBehaviour
{
    /*
     Player角色 與 對應Shadow 之間的位移同步
    CamA 若有 Player
    CamB 就有 Shadow
    且兩者同步
    同樣會預到 Collider的阻礙
    機關 也要有 shadow，才可以被踩到
     */
    public GameObject myPlayer;
    public GameObject myShadow;
    public GameObject planeA;
    public GameObject planeB;
   
    Vector3 playerPos = Vector3.zero;
    Vector3 shadowPos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (this.transform.name == "平面1")
            {
                other.transform.SetParent(this.transform);
                myShadow.SetActive(true);
                myShadow.transform.SetParent(planeB.transform);
                myShadow.transform.localPosition = other.transform.localPosition;
            }
            if (this.transform.name == "平面2")
            {
                other.transform.SetParent(this.transform);
                myShadow.SetActive(true);
                myShadow.transform.SetParent(planeA.transform);
                myShadow.transform.localPosition = other.transform.localPosition;
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.SetParent(null);
            myShadow.transform.SetParent(null);
            myShadow.SetActive(false);
        }
    }
}
