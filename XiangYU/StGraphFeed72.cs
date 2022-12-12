#define Graph_And_Chart_PRO
using UnityEngine;
using ChartAndGraph;

using System.Collections;
using UnityEngine.UI;


public class StGraphFeed72 : MonoBehaviour
{
    float lastTime = 0f;

    GraphChartBase graph;
    Text distancetext;
    public static float y;
    public static double yy;
    void Start()
    {
        // distancetext = GameObject.Find("distance").GetComponent<Text>();
        graph = GetComponent<GraphChartBase>();
        if (graph != null)
        {
            graph.Scrollable = false;
            graph.HorizontalValueToStringMap[0.0] = "0"; // example of how to set custom axis strings
            graph.DataSource.StartBatch();
            graph.DataSource.ClearCategory("Player 1");
            //  graph.DataSource.ClearAndMakeBezierCurve("Player 2");
            graph.DataSource.AddPointToCategory4("Player 5", 0, 0);



            graph.DataSource.EndBatch();
        }
        // StartCoroutine(ClearAll());
        //InvokeRepeating("MyAddPoint", 0.01f, 0.2f);
    }
    void Update()
    {
        MyAddPoint();
    }
    void MyAddPoint()
    {

        float curTime = MyTimer7.m_Timer;
        if (lastTime + 0.01f <= curTime)
        {
            lastTime = curTime;
            if (MyTimer7.isStart == true)
            {

                
                                                                                        
                //yy = 10 * (MyTimer7.m_Timer);
               // graph.DataSource.AddPointToCategory4("Player 5", (MyTimer7.m_Timer), yy); // each time we call AddPointToCategory
                yy = 76.2 - 10.0 * (MyTimer7.m_Timer);
                graph.DataSource.AddPointToCategory4("Player 2", (MyTimer7.m_Timer), yy); 
            }



        }
    }



    IEnumerator ClearAll()
    {
        yield return new WaitForSeconds(5f);
        GraphChartBase graph = GetComponent<GraphChartBase>();

        graph.DataSource.Clear();
    }
}
