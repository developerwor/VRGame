using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refrigeratorarm : MonoBehaviour
{
    [SerializeField] private GameObject arm; // ≥√¿Â∞Ì ∆»
    [SerializeField] private float speed; // »∏¿¸ Ω∫««µÂ
    void Update()
    {
        arm.transform.Rotate(Vector3.right, speed);
    }
}
