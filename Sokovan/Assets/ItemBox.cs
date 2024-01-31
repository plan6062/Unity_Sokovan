using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    public bool isOveraped = false;
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint"){
            isOveraped = true;
            myRenderer.material.color = touchColor;
     //       Debug.Log("엔드 포인트에 도달");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "EndPoint"){
            isOveraped = false;
            myRenderer.material.color = originalColor;
       //     Debug.Log("엔드 포인트에 도달");
        }
    }

    void OnTriggerStay(Collider other)
    {
         if(other.tag == "EndPoint"){
            isOveraped = true;
            myRenderer.material.color = touchColor;
           // Debug.Log("엔드 포인트에 도달");
        }
    }
    // void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log("충돌했음!");
    // }
}
