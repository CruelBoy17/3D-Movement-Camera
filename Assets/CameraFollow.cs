using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform Player;
	public float SmoothSpeed = 120f;
	public Vector3 offset;

	// Use this for initialization
	void LateUpdate () {
		transform.position = Player.position + offset;
	}
}
