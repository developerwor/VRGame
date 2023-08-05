using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator; // ĳ������ ���� �ִϸ�����
    private Vector3 vector3; // ĳ������ �Ӹ� ��ġ
    private VRRig_copy Vr_rig; // VRRig_copy ��ũ��Ʈ
    [SerializeField]
    private float speed = 0.1f; // �Ӹ� �̵��� �ΰ���

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
