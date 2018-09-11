using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_OnAxis : MonoBehaviour {
   
    public float Speed = 50;//Challenge 1 Code
    public float height = 0.5f;
    public float UpDSpeed = 1;
    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * Time.deltaTime * Speed,Space.World);//Challenge 1 Code

        
        Vector3 pos = transform.position;
        
        float newY = Mathf.Sin(Time.time * UpDSpeed);
    
        transform.position = new Vector3(pos.x, newY + 3.5f, pos.z) * height;
    }
}
