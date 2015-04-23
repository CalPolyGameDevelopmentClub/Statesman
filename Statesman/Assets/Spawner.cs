using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject cube;
	float spawnTime = 3;
	float spawnTimer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if(spawnTimer > spawnTime)
		{
			Instantiate(cube,transform.position,Quaternion.identity);
			spawnTimer = 0;
		}
	}
}
