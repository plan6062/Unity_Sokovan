using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameOver == true){
            return;
        }
        // if(Input.GetKey(KeyCode.W)){
        //     playerRigidbody.AddForce(0,0,speed);
        // }
        // if(Input.GetKey(KeyCode.A)){
        //     playerRigidbody.AddForce(-speed,0,0);
        // }
        // if(Input.GetKey(KeyCode.S)){
        //     playerRigidbody.AddForce(0,0,-speed);
        // }
        // if(Input.GetKey(KeyCode.D)){
        //     playerRigidbody.AddForce(speed,0,0);
        // }
        float inputX = Input.GetAxis("Horizontal"); //조이스틱 대응은 아날로그로 받아야 하기 때문
        
        float inputZ = Input.GetAxis("Vertical");

        //playerRigidbody.AddForce(inputX*speed, 0, inputZ*speed); 
        //addforce는 말그대로 힘을 주는 거라 힘이 누적됨, 속도가 아님

        float fallSpeed = playerRigidbody.velocity.y;
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity*speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;
        
    }
}
