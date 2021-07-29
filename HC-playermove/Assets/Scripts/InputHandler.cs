using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FXnRXn
{
    public class InputHandler : MonoBehaviour
    {
        #region Singleton

        public static InputHandler singleton;

        private void Awake()
        {
            if (singleton == null)
            {
                singleton = this;
            }
        }

        #endregion

        public FloatingJoystick _floatingJoystick;
        
        
        public Vector2 InputVector { get; private set; }
        
        public Vector3 MousePosition { get; private set; }

        private void Update()
        {
            var h = _floatingJoystick.Horizontal;
            var v = _floatingJoystick.Vertical;
            
            InputVector = new Vector2(h, v);

            MousePosition = Input.mousePosition;
        }
    }
}

