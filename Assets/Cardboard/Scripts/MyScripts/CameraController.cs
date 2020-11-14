using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private Vector3 offset;
	// Use this for initialization
	void Start () {
	}
	
	void LateUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal,0f,moveVertical);
		transform.position += movement;
	}
}
