using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTiles : MonoBehaviour
{
	public GameObject fieldPrefab;	
	public GameObject playerPrefab;
	public int fieldsAmountHorizontal;
	public int fieldsAmountVertical;

	private float counter;
	private float counter2;
	private float counter3;
	public static RenderTiles instance;

	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);

		}
	}

	void Start()
	{
		counter3 = 4;
		for(counter2 = 0; counter2 < fieldsAmountVertical; counter2++)
		{
			for(counter = counter3; counter < fieldsAmountHorizontal + counter3; counter++)
			{
				var add = new Vector3(transform.position.x + counter, transform.position.y - counter2, 0);
				Instantiate(fieldPrefab, add, fieldPrefab.transform.rotation).SetActive(true);
			}
			counter3 -= 1;
		}
		//Debug.Log(transform.position.x);
	}

	// Update is called once per frame
	void Update()
	{
		/*if(GameObject.Find("Player(Clone)") == null)
			Instantiate(playerPrefab, new Vector3(5,5,0), playerPrefab.transform.rotation);*/
	}
}
