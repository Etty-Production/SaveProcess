using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEvent : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SER SIP = animator.gameObject.GetComponent<SER>();
        SIP.Shoot = true;
    }
}
