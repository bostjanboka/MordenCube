using UnityEngine;
using System.Collections;

public class RotiranjeKocke : MonoBehaviour {

	// Use this for initialization
	Vector2 rotacija;

	Vector2 oldPos;
	void Start () {
		oldPos = Vector2.zero;
		rotacija = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if(touch.phase.Equals(TouchPhase.Began) || touch.phase.Equals(TouchPhase.Ended)){
				oldPos = touch.position;

			}
			else if(touch.phase.Equals(TouchPhase.Moved)){
				rotacija = oldPos - touch.position;
				oldPos = touch.position;
			}
		}

		gameObject.transform.Rotate (new Vector2(rotacija.y,-rotacija.x));

		rotacija = Vector2.zero;
	}
}
