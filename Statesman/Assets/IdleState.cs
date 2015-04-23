using UnityEngine;
using System.Collections;

public class IdleState : I_Playerstate {
	private float time;
	void I_Playerstate.onEnter(Transform player)
	{
		player.GetComponent<Renderer>().material.color = Color.blue;
		player.localScale = new Vector3(1,1,1);
	}
	void I_Playerstate.onExit (Transform player)
	{
	}
	
	// Update is called once per frame
	I_Playerstate I_Playerstate.Update (Transform player, float dt)
	{
		time+=dt;
		return null;
	}
	I_Playerstate I_Playerstate.handleInput(Transform player)
	{
		if(Input.GetKeyDown(KeyCode.D))
		{
			return new DuckState();
		}
		return null;
	}
	I_Playerstate I_Playerstate.onCollisionEnter(Transform player, Collision c)
	{
		return null;
	}
}
