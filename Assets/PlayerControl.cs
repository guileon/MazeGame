using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    private Rigidbody rb;
    private float x;
    private float y;
	// Use this for initialization
	void Start () {
        x = 0;
        y = 0;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.AddForce(x, 0, y);
         
	}
}
