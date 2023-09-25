using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLimits : MonoBehaviour
{
   [SerializeField] private float leftLimit, rightLimit, forwardLimit, backLimit;
   
   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         other.gameObject.GetComponentInParent<PlayerController>().ChangeMovementLimits(leftLimit, rightLimit, forwardLimit, backLimit);
      }
   }
}
