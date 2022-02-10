using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject trash;
    public GameObject parentOfTrash;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Spawn()
    {
        float randomX = Random.Range(-420, 421);
        float randomY = Random.Range(610, 611);

        Vector2 random2DPositionTarget = new Vector2(randomX, randomY);

        GameObject Trash = Instantiate(trash, parentOfTrash.transform);
        Trash.transform.localPosition = random2DPositionTarget;

        Debug.Log(random2DPositionTarget);
    }
}