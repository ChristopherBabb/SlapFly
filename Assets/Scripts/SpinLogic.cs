 using UnityEngine;
 using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SpinLogic : MonoBehaviour {
 
     float f_lastX = 0.0f;
     float f_difX = 0.0f;
     float i_direction = 0.0f;
 
     // Use this for initialization
     void Start () 
     {

     }
     
     
     // Update is called once per frame
     void Update () 
     {
         if (Input.GetMouseButtonDown(0))
         {
             f_difX = 0f;
         }
         else if (Input.GetMouseButton(0))
         {
             f_difX = Mathf.Abs(f_lastX - Input.GetAxis ("Mouse X"));
 
             if (f_lastX < Input.GetAxis ("Mouse X"))
             {
                 i_direction = -3;
                 transform.Rotate(Vector3.up, -f_difX);
             }
 
             if (f_lastX > Input.GetAxis ("Mouse X"))
             {
                 i_direction = 3;
                 transform.Rotate(Vector3.up, f_difX);
             }
 
             f_lastX = -Input.GetAxis ("Mouse X");
             
         }
         else 
         {
             if (f_difX > 0.0f) f_difX = f_difX * .9946f;
 
             transform.Rotate(Vector3.up, f_difX * i_direction);
         }
     }
 }
