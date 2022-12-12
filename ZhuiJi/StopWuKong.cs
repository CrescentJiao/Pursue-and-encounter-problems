using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWuKong : MonoBehaviour
{
  public   GameObject Wukong;
    public GameObject SanZang;
    float dis;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider SanZang)
    {
        print("---------------------------");
        WukongMove.h = 0;
        SanZangMove.h = 0;
        // SanZangMove.m_moveSpeed = 0f;
        MyTimer6.isPause = true;

        // 
    }
    private void OnTriggerExit(Collider SanZang)
    {

    }
    // Update is called once per frame
    void Update()
    {
       //dis = (SanZang.transform.position - Wukong.transform.position).sqrMagnitude;
        
        if (Vector3.Distance(SanZang.transform.position, Wukong.transform.position) < 18f)
        {
            WukongMove.h = 0;
            SanZangMove.h = 0;
            // SanZangMove.m_moveSpeed = 0f;
            MyTimer6.isPause = true;
        }
    }
}
