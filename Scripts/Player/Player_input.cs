using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

using TMPro;

public class Player_input : MonoBehaviour
{
    private CharacterController Controller; // 캐릭터 컨트롤러
    public XRController controller = null; // XR 컨트롤러

    [SerializeField] private float jump_power; // 점프 파워
    private float Vel_y; // 점프시의 중력적용 값
    private float Gravity = -9.21f;
    public float energy; // 점프 에너지
    public float energymax = 1f; // 점프 에너지 최대값
    public bool check; // 캐릭터가 공중에 떠있는지 땅에 붙어있는지 체크

    [SerializeField]
    public Vector3 velvv; // 캐릭터 속도값

    
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        energy = energymax;

    }

    void Update()
    {
        if(Controller.isGrounded)
            check = Controller.isGrounded;

        velvv = Controller.velocity;

        GravityAndJump();

        Controller.Move(Vector3.up * Vel_y );
        
        /*
        //Debug.Log(Controller.isGrounded);
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position))
        {
            //Debug.Log(position);
            Debug.Log("" + position);
        }        
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool valueB)) // B버튼
        {

        }        
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryTouch, out bool valueAt)) // A버튼T
        {
            //Debug.Log(valueAt);
            textDebug[3].text = "ATouch" + valueAt;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool valueBt)) // A버튼T
        {
            //Debug.Log(valueAt);
            textDebug[4].text = "BTouch" + valueBt;
        }

        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool valueM)) // A버튼T
        {
            //Debug.Log(valueAt);
            textDebug[5].text = "valueM" + valueM;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool ValueT)) // A버튼T
        {
            //Debug.Log(valueAt);
            textDebug[6].text = "ValueT" + ValueT;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool ValueG)) // A버튼T
        {
            //Debug.Log(valueAt);
            textDebug[7].text = "ValueG" + ValueG;
        }
        */        
    }       

    void GravityAndJump()
    {
        bool OnFly = false;

        if (energy > 0.3f)
        {
            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))
            {
                if (AButton)
                {
                    OnFly = true;

                    check = false;
                }
            }
        }

        if (OnFly)
        {
            Vel_y = jump_power * 2.0f * -Gravity * Time.deltaTime;

            if(energy > 0)
                energy -= Time.deltaTime;
        }   
        else
        {            
            Vel_y += Gravity * Time.deltaTime * 0.25f;

            if (check)
            {
                if (energy < energymax)
                    energy = energymax;
            }

        }
    }
}
