using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool upClick;
    public bool downClick;
    public bool leftClick;
    public bool rightClick;
    public bool circleClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpButton()
    {
        upClick = true;
    }
    public void DownButton()
    {
        downClick = true;
    }

    public void LeftButton()
    {
        leftClick = true;
    }

    public void RightButton()
    {
        rightClick = true;
    }
    public void CircleButton()
    {
        circleClick = true;
    }
}
