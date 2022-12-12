using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start7 : MonoBehaviour
{
    public Sprite play;
    public Sprite timeout;
    // Start is called before the first frame update
    void Start()
    {
        WukongMove2.h = 0;
        SanZangMove2.h = 0;
        GetComponent<Toggle>().onValueChanged.AddListener(OnClick);
    }
    void OnClick(bool ison)
    {
        if (ison == true)
        {
            MyTimer7.isStart = true;
            MyTimer7.isPause = false;
            WukongMove2.h = 1;
            SanZangMove2.h = -1;
            WukongMove2.m_moveSpeed = 20f;
            this.GetComponentInChildren<Image>().sprite = play;
        }
        else  if (ison==false)
        {
            MyTimer7.isPause = true;
            WukongMove2.h = 0;
            SanZangMove2.h = 0;
            this.GetComponentInChildren<Image>().sprite = timeout;
                //Resources.Load("Textures/play" ) as Sprite;
        }
    }
    // Update is called once per frame
  

    void Update()
    {
        if (Mathf.Floor(MyTimer7.m_Timer) == 7f)
        {
            this.GetComponent<Toggle>().interactable = false;
        }
    }
}
