using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start6 : MonoBehaviour
{
    public Sprite play;
    public Sprite timeout;
    bool wukongisrun;
    // Start is called before the first frame update
    void Start()
    {
        WukongMove.h = 0;
        SanZangMove.h = 0;
        wukongisrun = false;
        WukongMove.m_moveSpeed = 0f;
        this.GetComponent<Toggle>().onValueChanged.AddListener(OnClick);
    }
    void OnClick(bool ison)
    {
        if (ison == true)
        {
            MyTimer6.isStart = true;
            MyTimer6.isPause = false;
          
            SanZangMove.h = 1;
            //   if ( )
            //   {
            //       Invoke("WukongRun",0);
            //   }
            //Invoke("WukongRun",15f);
            if (wukongisrun == true)
            {
                WukongMove.m_moveSpeed = 25f;
                WukongMove.h = 1;
            }
            else
            {
                WukongMove.h = 0;
            }
            
            this.GetComponentInChildren<Image>().sprite = play;
        }
        else if (ison == false)
        {
          
            MyTimer6.isPause = true;
            
            WukongMove.h = 0;
            SanZangMove.h = 0;
            this.GetComponentInChildren<Image>().sprite = timeout;
        }
    }
    // Update is called once per frame
    void WukongRun()
    {
        wukongisrun = true;
        WukongMove.m_moveSpeed = 25f;
        WukongMove.h = 1;
        //GameObject.Find("Rabbit").GetComponent<AnimatorController>().SetInt("animation,0");
        
    }
   
    void Update()
    {
        if (Mathf.Floor(MyTimer6.m_Timer) == 15)
        {
            if (this.GetComponent<Toggle>().isOn == true)
            {
                WukongRun();
            }else
            {
                WukongMove.h = 0;
            }
            
            // CancelInvoke("StopRabbit");
            
        }
        if (Mathf.Floor(MyTimer6.m_Timer) == 25)
        {
            this.GetComponent<Toggle>().interactable = false;
        }
    }
}
