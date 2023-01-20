using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] tetrominoes;
    public GameObject[] ghostTetrominoes;
    public List<GameObject> imagesTetrominoes = new List<GameObject>();
    private int nextTetromino;

    // Start is called before the first frame update
    void Start()
    {
        nextTetromino = Random.Range(0, tetrominoes.Length);
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(tetrominoes[3], transform.position, Quaternion.identity);
        Instantiate(ghostTetrominoes[3], transform.position, Quaternion.identity);
        nextTetromino = Random.Range(0, tetrominoes.Length);

        for(int i = 0; i < imagesTetrominoes.Count; i++)
        {
            imagesTetrominoes[i].SetActive(false);
        }

        imagesTetrominoes[nextTetromino].SetActive(true);
    }
}
