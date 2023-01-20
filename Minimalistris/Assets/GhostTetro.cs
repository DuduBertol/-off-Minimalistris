using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTetro : MonoBehaviour
{
    private GameManager gameManager;
    private int rotationValue;
    public GameObject verticalUp;
    public GameObject verticalDown;
    public GameObject horizontalRight;
    public GameObject horizontalLeft;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (FindObjectOfType<TetrisBlock>().GetComponent<Transform>().position.x, FindObjectOfType<TetrisBlock>().GetComponent<Transform>().position.y, 0);

        if(FindObjectOfType<TetrisBlock>().GetComponent<Transform>().eulerAngles == new Vector3 (0, 0, 0))
        {
            verticalUp.SetActive(true); //ATIVO
            verticalDown.SetActive(false);
            horizontalLeft.SetActive(false);
            horizontalRight.SetActive(false);
        }

        if(FindObjectOfType<TetrisBlock>().GetComponent<Transform>().eulerAngles == new Vector3 (0, 0, 180))
        {
            verticalUp.SetActive(false);
            verticalDown.SetActive(true); //ATIVO
            horizontalLeft.SetActive(false);
            horizontalRight.SetActive(false);
        }

        if(FindObjectOfType<TetrisBlock>().GetComponent<Transform>().eulerAngles == new Vector3 (0, 0, -90))
        {
            verticalUp.SetActive(false);
            verticalDown.SetActive(false);
            horizontalLeft.SetActive(true); //ATIVO
            horizontalRight.SetActive(false);
        }

        if(FindObjectOfType<TetrisBlock>().GetComponent<Transform>().eulerAngles == new Vector3 (0, 0, 90))
        {
            verticalUp.SetActive(false);
            verticalDown.SetActive(false);
            horizontalLeft.SetActive(false);
            horizontalRight.SetActive(true); // ATIVO
        }
    }
}
