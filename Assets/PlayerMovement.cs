using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	#region Variables
	[Header("Transform")]
    public Rigidbody rb;
	public float ForwardForce = 500f;
    public float SideForce = 400f;
	public float JumpForce = 400f;
	#endregion

	// Use this for initialization
	void Start () {
		rb.AddForce(ForwardForce, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(0, 0, SideForce);
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            rb.AddForce(0, 0, -SideForce);
        }
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(0, JumpForce, 0);
		}
	}
}
