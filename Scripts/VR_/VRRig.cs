using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRmap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map()
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }
}

public class VRRig : MonoBehaviour
{
    public VRmap head; // 머리
    public VRmap leftHand; // 왼손
    public VRmap rightHand; // 오른손    

    public Transform headConstraint;
    public Vector3 headBodyOffset;
    public float turnSmooth;

    private void Start()
    {
        headBodyOffset = transform.position - headConstraint.position;
    }

    private void LateUpdate()
    {
        transform.position = headConstraint.position + headBodyOffset;
        transform.forward = Vector3.Lerp(transform.forward, Vector3.ProjectOnPlane(headConstraint.up, Vector3.up).normalized, Time.deltaTime * turnSmooth);

        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}