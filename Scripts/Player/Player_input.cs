using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

using TMPro;

public class Player_input : MonoBehaviour
{
    private CharacterController Controller; // ĳ���� ��Ʈ�ѷ�
    public XRController controller = null; // XR ��Ʈ�ѷ�

    [SerializeField] private float jump_power; // ���� �Ŀ�
    private float Vel_y; // �������� �߷����� ��
    private float Gravity = -9.21f;
    public float energy; // ���� ������
    public float energymax = 1f; // ���� ������ �ִ밪
    public bool check; // ĳ���Ͱ� ���߿� ���ִ��� ���� �پ��ִ��� üũ

    [SerializeField]
    public Vector3 velvv; // ĳ���� �ӵ���

    
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
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool valueB)) // B��ư
        {

        }        
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryTouch, out bool valueAt)) // A��ưT
        {
            //Debug.Log(valueAt);
            textDebug[3].text = "ATouch" + valueAt;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool valueBt)) // A��ưT
        {
            //Debug.Log(valueAt);
            textDebug[4].text = "BTouch" + valueBt;
        }

        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool valueM)) // A��ưT
        {
            //Debug.Log(valueAt);
            textDebug[5].text = "valueM" + valueM;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool ValueT)) // A��ưT
        {
            //Debug.Log(valueAt);
            textDebug[6].text = "ValueT" + ValueT;
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool ValueG)) // A��ưT
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
