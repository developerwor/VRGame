//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class inventori : MonoBehaviour
//{
//    public Player_inven player_Inven;
//    public name_postion name_Postion;
//    public GameObject[] item_inventori_location; // 위치 정보
//    public bool item_check;

//    private Vector3 one_vector3;
//    private Vector3 two_vector3;
//    private Vector3 tree_vector3;
//    private void Start()
//    {
//        one_vector3 = new Vector3(-634.4f, 226.2f, -450.3f);
//        two_vector3 = new Vector3(-634.4f, 245.5f, -450.3f);
//        tree_vector3 = new Vector3(-634.4f, 264.4f, -450.3f);

//        item_check = false;
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (!item_check) // 비어있는 상태
//        {
//            if (name_Postion.Position_Name == Position_name.one || other.gameObject.name.Contains("feul") || other.gameObject.name.Contains("rice") || other.gameObject.name.Contains("wheel"))
//            {                
//                other.gameObject.transform.position = one_vector3;
//                if (other.gameObject.transform.position == one_vector3)
//                {
//                    other.GetComponent<Rigidbody>().isKinematic = true;
//                }               
//                item_check = true;          
//            }
//            else if (name_Postion.Position_Name == Position_name.two || other.gameObject.name.Contains("feul") || other.gameObject.name.Contains("rice") || other.gameObject.name.Contains("wheel"))
//            {
//                other.gameObject.transform.position = two_vector3;
//                if (other.gameObject.transform.position == two_vector3)
//                {
//                    other.GetComponent<Rigidbody>().isKinematic = true;
//                }
//                item_check = true;
//            }
//            else if (name_Postion.Position_Name == Position_name.tree || other.gameObject.name.Contains("feul") || other.gameObject.name.Contains("rice") || other.gameObject.name.Contains("wheel"))
//            {
//                other.gameObject.transform.position = tree_vector3;
//                if (other.gameObject.transform.position == tree_vector3)
//                {
//                    other.GetComponent<Rigidbody>().isKinematic = true;
//                }
//                item_check = true;
//            }
//            else if (other.gameObject.CompareTag("Player"))
//            {

//            }
//        }        
//    }

//    private void OnTriggerStay(Collider other)
//    {
//        other.GetComponent<Rigidbody>().isKinematic = false;
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        item_check = false;        
//    }
//}
