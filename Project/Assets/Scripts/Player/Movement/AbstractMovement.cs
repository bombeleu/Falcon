﻿/*******************************************************************
 * 
 * Copyright (C) 2015 Frozen Metal Studios - All Rights Reserved
 * 
 * NOTICE:  All information contained herein is, and remains
 * the property of Frozen Metal Studios. The intellectual and 
 * technical concepts contained herein are proprietary to 
 * Frozen Metal Studios are protected by copyright law.
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from Frozen Metal Studios.
 * 
 * *****************************************************************
 * 
 * Filename: AbstractMovement.cs
 * 
 * Description: Default Movement structure and methods.
 * 
 *******************************************************************/
using UnityEngine;
using System.Collections;
using Assets.Scripts.CustomEditor;

namespace Assets.Scripts.Player.Movement
{
    /// <summary>
    /// Describes the base requirements for a Player's movement.
    /// </summary>
    public abstract class AbstractMovement : MonoBehaviour
    {
        /// <summary>
        /// The speed that the player will move at.
        /// </summary>
        public float speed = 6f;

        /// <summary>
        /// Flags if movement is occuring.
        /// </summary>
        [ReadOnly]
        public bool moving = false;

        /// <summary>
        /// Flag if rotation is occuring.
        /// </summary>
        [ReadOnly]
        public bool rotating = false;

        /// <summary>
        /// Reference to the animator component.
        /// </summary>
        // [ReadOnly]
        // public Animator anim;

        /// <summary>
        /// Reference to the player's rigidbody.
        /// </summary>
        [ReadOnly]
        public Rigidbody playerRigidbody;

        /// <summary>
        /// Default Initialization
        /// </summary>
        public virtual void InitMovement()
        {
            // At base, gather the Component References
            //anim = GetComponent<Animator>();
            playerRigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// Player Movement must be performed in Fixed Update.
        /// </summary>
        public abstract void FixedUpdate();

        /// <summary>
        /// The movement must update its state.
        /// </summary>
        public abstract void DetermineState();

        /// <summary>
        /// The movement must update its position.
        /// </summary>
        public abstract void UpdatePosition();

        /// <summary>
        /// The movement must update its rotation.
        /// </summary>
        public virtual void UpdateRotation()
        {
            // Perform any rotation necessary.
        }

        /// <summary>
        /// The movement must update its rotation.
        /// </summary>
        public abstract void UpdateAnimation();
    }
}