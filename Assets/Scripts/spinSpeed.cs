using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class spinSpeed : MonoBehaviour
{
 private Quaternion lastPosition;
 private float totalDegrees;
 
 private void Start()
 {
    lastPosition = transform.rotation;
    Debug.Log("Starting Position:" + lastPosition );
    InvokeRepeating ("FindSpin", 5.0f, 5.0f);

 }
 
 private void Update()
 {
    float distance = Quaternion.Angle( lastPosition, transform.rotation );
    totalDegrees += distance;
    lastPosition = transform.rotation;
    //Debug.Log("Total distance travelled:" + totalDegrees );
 }
 
 private void FindSpin()
 {
    Debug.Log("Total degrees rotated: " + totalDegrees );
    totalDegrees = 0f;
 }
}
