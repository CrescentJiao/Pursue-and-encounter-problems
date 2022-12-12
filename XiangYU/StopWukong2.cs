using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWukong2: MonoBehaviour
{
    public GameObject Wukong;
    public GameObject SanZang;
    float dis;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider SanZang)
    {
       
        // 
    }
    private void OnTriggerExit(Collider SanZang)
    {

    }
    // Update is called once per frame
    void Update()
    {
        //dis = (SanZang.transform.position - Wukong.transform.position).sqrMagnitude;

        if (Vector3.Distance(SanZang.transform.position, Wukong.transform.position) < 22f)
        {
            WukongMove2.h = 0;
            SanZangMove2.h = 0;
            WukongMove2.m_moveSpeed = 0f;
            MyTimer7.isPause = true;
        }
    }
}
