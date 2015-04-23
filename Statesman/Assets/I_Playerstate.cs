using UnityEngine;
using System.Collections;

public interface I_Playerstate {

	void onEnter(Transform player);
	void onExit (Transform player);

	// Update is called once per frame
	I_Playerstate Update (Transform player, float dt);
	I_Playerstate handleInput(Transform player);
	I_Playerstate onCollisionEnter(Transform player, Collision c);
}
