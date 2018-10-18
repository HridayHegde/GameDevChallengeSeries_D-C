using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStuff2 : MonoBehaviour {
    public Transform[] destis;
    public float Speed;
    Vector3 velo = new Vector3(0,0,0);
    //Transform target;
    public int currtar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position != destis[currtar].position)
        {
            transform.position = Vector3.SmoothDamp(transform.position, destis[currtar].position, ref velo, Time.deltaTime,Speed);
            //transform.position = destis[currtar].position;
            
        }
        else { currtar++; }
	}
}
