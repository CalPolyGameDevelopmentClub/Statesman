using UnityEngine;
using System.Collections;

public class AirState : I_Playerstate {
	private float time;
	void I_Playerstate.onEnter(Transform player)
	{
		player.GetComponent<Renderer>().material.color = Color.yellow;
		player.localScale = new Vector3(0.8f,1.1f,0.8f);
	}
	void I_Playerstate.onExit (Transform player)
	{
	}
	
	// Update is called once per frame
	I_Playerstate I_Playerstate.Update (Transform player, float dt)
	{

		return null;
	}
	I_Playerstate I_Playerstate.handleInput(Transform player)
	{
		return null;
	}
	I_Playerstate I_Playerstate.onCollisionEnter(Transform player, Collision c)
	{
		if(c.gameObject.tag == "Block")
		{
			player.GetComponent<ParticleSystem>().Emit(50);
		}

		return new IdleState();
	}
}
