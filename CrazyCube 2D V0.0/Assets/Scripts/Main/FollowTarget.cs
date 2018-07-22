using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowTarget : MonoBehaviour {
        
     [SerializeField]
     private Transform target;
     private Vector3 offsetPosition;
     private Space offsetPositionSpace = Space.Self;

     //[SerializeField]
     //private bool lookAt = true;
 
     private void Update()
     {
         Refresh();
     }
 
     public void Refresh()
     {
         if(target == null)
         {
             Debug.LogWarning("Missing target ref !", this);
 
             return;
         }
         if(offsetPositionSpace == Space.Self)
         {
             transform.position = target.TransformPoint(offsetPosition);
         }
         else
         {
             transform.position = target.position + offsetPosition;
         }
     }
        // public Transform target;
        // public float distance = 3.0f;
        // public float height = 3.0f;
        // public float damping = 5.0f;
        // public bool followBehind = true;
 
        // void Update ()
        // {
        // Vector3 wantedPosition;
        // if(followBehind)
        // wantedPosition = target.TransformPoint(0, height, -distance);

        // else
        // wantedPosition = target.TransformPoint(0, height, distance);
        // transform.position = Vector3.Lerp (transform.position, wantedPosition, Time.deltaTime * damping);
 
        // }  
}
