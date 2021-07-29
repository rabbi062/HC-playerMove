using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FXnRXn
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMove : MonoBehaviour
    {

        #region Variable
        
        [SerializeField] private float _moveSpeed = .1f;
        
        
        private CharacterController _controller;
        private float _inputX;
        private float _inputZ;
        private Vector3 v_movement;

        #endregion

        private void Start()
        {
            _controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _inputX = InputHandler.singleton.InputVector.x;
            _inputZ = InputHandler.singleton.InputVector.y;
        }

        private void FixedUpdate()
        {
            v_movement = new Vector3(_inputX * _moveSpeed, 0, _inputZ * _moveSpeed);
            _controller.Move(v_movement);
        }
    }
}

