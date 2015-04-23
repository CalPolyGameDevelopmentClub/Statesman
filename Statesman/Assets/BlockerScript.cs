using UnityEngine;
using System.Collections;

public class BlockerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(7.5f,Random.Range(1,5),1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position+=new Vector3(0,0,-0.1f);
		if(transform.position.z < -1)
		{
			Destroy(this.gameObject);
		}
	}
}
