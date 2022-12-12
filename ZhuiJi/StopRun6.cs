using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRun6 : MonoBehaviour
{
    public GameObject Wukong;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider Wukong)
    {
        SanZangMove.h = 0;
       // SanZangMove.m_moveSpeed = 0f;
        MyTimer6.isPause = true;
       
        // 
    }
    private void OnTriggerExit(Collider Wukong)
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
