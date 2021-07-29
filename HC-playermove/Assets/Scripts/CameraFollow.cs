using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FXnRXn
{
    public class CameraFollow : MonoBehaviour
    {
        
        [Header("Basic Camera Properties")]
        public float height = 2f;
        public float distance = 2f;
        public float smoothSpeed = 0.35f;
        
        
        [Header("Base Camera Properties")]
        public Rigidbody rb;
        public Transform lookAtTarget;

         Vector3 wantedPos;
         Vector3 refVelocity;
         Vector3 targetFlatFwd;
        
        
         void FixedUpdate()
         {
             if (rb)
             {
                 //Get Flat Forward of the Target
                 targetFlatFwd = rb.transform.forward;
                 targetFlatFwd.y = 0f;
                 targetFlatFwd = targetFlatFwd.normalized;

                 UpdateCamera();
             }
         }
         
         
        
        public void UpdateCamera()
        {
            //wanted position
            wantedPos = rb.position + (-targetFlatFwd * distance) + (Vector3.up * height);

            //lets position the camera
            transform.position = Vector3.SmoothDamp(transform.position, wantedPos, ref refVelocity, smoothSpeed);
            transform.LookAt(lookAtTarget);
        }

    }
}

