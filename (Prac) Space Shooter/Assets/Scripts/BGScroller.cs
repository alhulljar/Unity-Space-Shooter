using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPos;
	
	void Start ()
    {
        startPos = transform.position;
	}
	
	void Update ()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed,tileSizeZ);
        transform.position = startPos + Vector3.forward * newPosition;
	}
}
