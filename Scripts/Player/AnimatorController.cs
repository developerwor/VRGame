using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator; // 캐릭터의 현재 애니메이터
    private Vector3 vector3; // 캐릭터의 머리 위치
    private VRRig_copy Vr_rig; // VRRig_copy 스크립트
    [SerializeField]
    private float speed = 0.1f; // 머리 이동의 민감도

    void Start()
    {
        animator = GetComponent<Animator>();
        Vr_rig = GetComponent<VRRig_copy>();
        vector3 = Vr_rig.head.vrTarget.position;
    }

    void Update()
    {
        Vector3 head_set_Speed = (Vr_rig.head.vrTarget.position - vector3) / Time.deltaTime;
        head_set_Speed.y = 0;

        Vector3 headsetlocalspeed = transform.InverseTransformDirection(head_set_Speed);
        vector3 = Vr_rig.head.vrTarget.position;

        animator.SetBool("move", headsetlocalspeed.magnitude > speed);
        animator.SetFloat("directionX", Mathf.Clamp(headsetlocalspeed.x,-1,1));
        animator.SetFloat("directionY", Mathf.Clamp(headsetlocalspeed.z,-1,1));
    }
}
