using UnityEngine;
using System.Collections;

public interface I_Playerstate {

	void onEnter(Transform player);
	void onExit (Transform player);

	// Update is called once per frame
	void Update (Transform player, float dt);
	void handleInput(Transform player);
}
