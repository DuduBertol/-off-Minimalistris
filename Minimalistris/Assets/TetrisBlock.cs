using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public GameManager gameManager;

    public Vector3 rotationPoint;
    private float previousTime;
    public float fallTime = 0.8f;
    public static int height = 20;
    public static int width = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.rightClick)
        {
            transform.position += new Vector3(1, 0, 0);
            gameManager.rightClick = false;
            if(!ValidMove())
            {
                transform.position -= new Vector3(1, 0, 0);
            }  
        }

        if(gameManager.leftClick)
        {
            transform.position += new Vector3(-1, 0, 0);
            gameManager.leftClick = false;
            if(!ValidMove())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }  
        }

        //ROTATE
        if(gameManager.circleClick)
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3 (0, 0, 1), 90);
            gameManager.circleClick = false;
             if(!ValidMove())
            {
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3 (0, 0, 1), -90);
            } 
        }

        if(Time.time - previousTime > (gameManager.downClick ? fallTime / 10 : fallTime))
        {
            transform.position += new Vector3(0, -1, 0);
            if(!ValidMove())
            {
                transform.position -= new Vector3(0, -1, 0);
            }  
            previousTime = Time.time;
            gameManager.downClick = false;
        }
    }

    bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if(roundedX < 0 || roundedX >= width || roundedY < 0 || roundedY >= height)
            {
                return false;
            }
        }

        return true;
    }
}
