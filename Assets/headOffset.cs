using UnityEngine;
using System.Collections;

public class headOffset : MonoBehaviour {
    public GameObject body;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - body.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = body.transform.position + offset;
    }
}
