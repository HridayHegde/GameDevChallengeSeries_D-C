using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomstuff : MonoBehaviour {
    public Transform Cube;
    public float Speed = 5;
    public Vector3 cubepos;
    public float x, y, z;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cubepos = Cube.position;
        x = cubepos.x;
        y = cubepos.y;
        z = cubepos.z;
        transform.Rotate(Vector3.up * Time.deltaTime * Speed, Space.World);//Challenge 1 Code


    }
}
