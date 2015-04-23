using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private I_Playerstate state;
	// Use this for initialization
	void Start () {
		state = new IdleState();
		state.onEnter(transform);
	}
	
	// Update is called once per frame
	void Update () {

		I_Playerstate newState = state.handleInput(transform);
		if(newState != null)
		{
			switchState(newState);
		}
		newState = state.Update(transform, Time.deltaTime);
		if(newState != null)
		{
			switchState(newState);
		}
	}
	void OnCollisionEnter(Collision c)
	{
		I_Playerstate newState = state.onCollisionEnter(transform,c);
		if(newState != null)
		{
			switchState(newState);
		}
	}
	private void switchState(I_Playerstate newState)
	{
		state.onExit(transform);
		newState.onEnter(transform);
		state = newState;
	}
	}
