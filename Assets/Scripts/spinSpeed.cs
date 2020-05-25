using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class spinSpeed : MonoBehaviour
{
 public Quaternion lastPosition;
 public static float totalDegrees;
 
 public void Start()
 {
    lastPosition = transform.rotation;
    Debug.Log("Starting Position:" + lastPosition );
    InvokeRepeating ("FindSpin", 5.0f, 15.0f);

 }
 
 public void Update()
 {
    float distance = Quaternion.Angle( lastPosition, transform.rotation );
    totalDegrees += distance;
    lastPosition = transform.rotation;
    //Debug.Log("Total distance travelled:" + totalDegrees );
 }
 
 public void FindSpin()
 {
    Debug.Log("Total degrees rotated: " + totalDegrees );
    totalDegrees = 0f;
 }
}
