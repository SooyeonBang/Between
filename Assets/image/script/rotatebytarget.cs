using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatebytarget : MonoBehaviour
 { 
    public Transform Target; 
    
    void Update() 
    { 
        transform.RotateAround(Target.position, Vector3.up, 20 * Time.deltaTime); 
    } 
}
