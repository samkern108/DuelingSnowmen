using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	
	//## CURRENT INPUT VALUES ##//
	private float hAxis = 0, vAxis = 0, hWarp = 0, vWarp = 0;
	private bool sprintButtonDown, jumpButtonDown, jumpButtonUp, warpButtonDown;

	private Vector3 intermediatePosition;
	private Vector3 currentSpeedVector;

	private bool playerInputEnabled = true;

	//## UPDATE ##//
	void Update () 
	{
		if (playerInputEnabled) 
		{
			//1: Conduct Linecasts
			Linecasts ();

			intermediatePosition = transform.position;

			//2: Update Input Values
			vAxis = InputWrapper.GetVerticalAxis ();
			hAxis = InputWrapper.GetHorizontalAxis ();

			//3: Handle Regular Movement
			Move();
		
			//4: Apply Movement Vectors to Transform

			transform.position = CheckNewPosition (transform.position + currentSpeedVector * Time.deltaTime, transform.position);
		}
	}

	private void Move()
	{
		currentSpeedVector.x = hAxis * walkSpeed;
	}

	//## RUNNING ##//
	private float walkSpeed = 2f;

	private Vector3 CheckNewPosition(Vector3 newPos, Vector3 oldPos)
	{
		return newPos;
	}

	// Maybe I can get LinecastNonAlloc to work someday.
	private void Linecasts()
	{
	}

} 