using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avata_ik : MonoBehaviour
{
    private Animator animator; // 캐릭터 오브젝트의 애니메이터
    public Vector3 Offset;
    [Range(0, 1)]
    public float rightFootPosWeight = 1;
    [Range(0, 1)]
    public float leftFootPosWeight = 1;
    [Range(0, 1)]
    public float rightFootRotWeight = 1;
    [Range(0, 1)]
    public float leftFootRotWeight = 1;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnAnimatorIK(int layerIndex)
    {
        Vector3 rightFootPos = animator.GetIKPosition(AvatarIKGoal.RightFoot);
        RaycastHit hit;

        bool hashit = Physics.Raycast(rightFootPos + Vector3.up, Vector3.down, out hit);
        if (hashit)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, rightFootPosWeight);
            animator.SetIKPosition(AvatarIKGoal.RightFoot, hit.point + Offset);

            Quaternion rightfootRotation = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward,hit.normal),hit.normal);
            animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, rightFootRotWeight);
            animator.SetIKRotation(AvatarIKGoal.RightFoot, rightfootRotation);
        }
        else
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 0);
        }

        Vector3 leftFootPos = animator.GetIKPosition(AvatarIKGoal.LeftFoot);
        
        hashit = Physics.Raycast(leftFootPos + Vector3.up, Vector3.down, out hit);
        if (hashit)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, leftFootPosWeight);
            animator.SetIKPosition(AvatarIKGoal.LeftFoot, hit.point + Offset);

            Quaternion leftfootRotation = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, hit.normal), hit.normal);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, leftFootRotWeight);
            animator.SetIKRotation(AvatarIKGoal.LeftFoot, leftfootRotation);
        }
        else
        {
            animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 0);
        }
    }
    #region animator
    public void animator_method()
    {
        //if (/*캐릭터가 움직이면*/)
        //{
        //    animator.SetBool("move",true);
        //}
        //else
        //{
        //animator.SetBool("move", false);
        //}
    }        
        #endregion
}
