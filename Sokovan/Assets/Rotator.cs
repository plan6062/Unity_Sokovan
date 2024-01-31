using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60*Time.deltaTime,60*Time.deltaTime,60*Time.deltaTime);
        //Time.deltaTime은 화면이 한 번 깜빡이는 시간 = 한 프레임의 시간
        //화면을 60번 깜빡이면 Time.deltaTime = 1/60
    }
}
