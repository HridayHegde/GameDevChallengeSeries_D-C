using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoints : MonoBehaviour {
    public Transform[] Points;
    public Transform Main;
    public int currPoint=0;
    Vector3 DirectionToGo;
    Vector3 velocity = Vector3.zero;
    public float speed;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
        DirectionToGo  = Points[currPoint].position - Main.position;
        DirectionToGo = DirectionToGo.normalized;
        if (Main.position != Points[currPoint].position)
        {
            transform.position = Vector3.SmoothDamp(transform.position, Points[currPoint].position,ref  velocity,Time.deltaTime,speed);
        }
        else
        {
            currPoint++;
        }


    }

    
}
