using UnityEngine;
using System.Collections;

public class DuckState : I_Playerstate {
	private float time;
	void I_Playerstate.onEnter(Transform player)
	{
		player.GetComponent<Renderer>().material.color = Color.red;
		player.position -= new Vector3(0,0.45f,0);
		player.localScale = new Vector3(1,0.5f,1);
	}
	void I_Playerstate.onExit (Transform player)
	{
		player.localScale = new Vector3(1,1,1);
	}
	
	// Update is called once per frame
	I_Playerstate I_Playerstate.Update (Transform player, float dt)
	{
		time+=dt;
		player.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.green, time/2);

		return null;
	}
	I_Playerstate I_Playerstate.handleInput(Transform player)
	{
		if(!Input.GetKey(KeyCode.D))
		{
			player.GetComponent<Rigidbody>().AddForce(new Vector3(0,Mathf.Max (time,2)*200,0));
			return new AirState();
		}
		return null;
	}
	I_Playerstate I_Playerstate.onCollisionEnter(Transform player, Collision c)
	{
		return null;
	}
}
