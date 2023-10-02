using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerAnimations : MonoBehaviour
{
   private Animator _animator;

   private void Awake()
   {
      _animator = GetComponent<Animator>();
   }

   public void Attack()
   {
      _animator.SetBool("Attack",true);
   }
   
   public void Idle()
   {
      _animator.SetTrigger("Idle");
   }

   public void Mock()
   {
      _animator.SetTrigger("Mock");
   }


}
