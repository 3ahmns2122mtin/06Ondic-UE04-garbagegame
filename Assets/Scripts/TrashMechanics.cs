using UnityEngine;
using System.Collections;

public class TrashMechanics : MonoBehaviour
{

	public float distance = 1f;
	public GameObject trash;
	[SerializeField] private int secToDestroy;
	private GameManager gameManager;
	// Use this for initialization
	void Start()
	{
        gameManager = FindObjectOfType<GameManager>();
        secToDestroy = 15;
        Destroy(gameObject, secToDestroy);
	}

	// Update is called once per frame
	void Update()
	{
		Physics2D.queriesStartInColliders = false;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);
	}
}