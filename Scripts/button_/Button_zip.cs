using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button_zip : MonoBehaviour
{
    
    public GameObject catles_panel;

    /*****************스크립트********************/
    public interectorble_grip interectorble_Grip;
    public boat_fuel boat_Fuel;
    public Player_inven player_Inven;
    public vending_machine vending_Machine;
    public cales_text_move text_Move;
    public caltles Caltles;
    public Robot_Ai[] ai_ment;
    public GameObject minimap;
    public GameObject boatcamera;
    /*****************스크립트********************/

    public Image[] item_images; // 아이템 이미지
    public Image[] map_images; // 맵 이미지

    public float item_number_change; // 아이템 변경 number
    public float map_number_change; // 맵 변경 number    
    public float time; // 시간    

    private bool aicomponentcheck; // ai_ment 존재유무
    private Vector3 caltles_Open_Position; // 문이 열리는 위치
    private void Awake()
    {
        minimap.SetActive(false);

        if (ai_ment == null)
        {
            aicomponentcheck = false;
            Debug.Assert(aicomponentcheck, "현재 ai_ment의 컴포넌트가 존재하지 않습니다");
        }
    }

    private void Start()
    {
        item_number_change = 0;
        map_number_change = 0;
        caltles_Open_Position = new Vector3(-690.0661f, 180f, -559.2167f);
    }

    private void Update()
    {
        time = Time.deltaTime;        
    }
    public void Item_image_Button()
    {
        if (item_number_change == 0)
        {
            item_images[0].gameObject.SetActive(true);
            item_images[1].gameObject.SetActive(true);

            item_number_change = 1;
        }
        else if (item_number_change == 1)
        {
            item_images[0].gameObject.SetActive(false);
            item_images[1].gameObject.SetActive(false);

            item_number_change = 0;
        }
    }

    public void Map_Button()
    {
        if (map_number_change == 0)
        {
            item_images[0].gameObject.SetActive(true); 
            item_images[1].gameObject.SetActive(false); 

            map_number_change = 1;
        }
        else if (map_number_change == 1)
        {
            item_images[0].gameObject.SetActive(false);
            item_images[1].gameObject.SetActive(true);

            map_number_change = 2;
        }
        else if (map_number_change == 2)
        {
            item_images[0].gameObject.SetActive(false);
            item_images[1].gameObject.SetActive(false);

            map_number_change = 0;
        }
    }

    public void AI_Robot_Button_OK_method(int num)
    {     
        if (player_Inven.fuel > 0)
        {            
            player_Inven.fuel--;
            ai_ment[num].ainowfeul++;            
            ai_ment[num].agent_start();
            interectorble_Grip.delde();
            print("연료가 소모되었습니다");
        }        
        else
        {
            print("현재 연료가 부족합니다");
        }
    }

    public void AI_Robot_Button_OFF_method(int num)
    {
        ai_ment[num].agent_stop();
    }

    public void Caltles_Robot_Button_ON_method()
    {        
        if (Caltles.caltles_Robot_feul >= 5)
        {            
            text_Move.talk_box.text = "";
            text_Move.after_catles_Text_animation();
            StartCoroutine(Button_caltle_open());
            StartCoroutine(caltle_UI_delete());            
        }
        else
        {
            Debug.Log("현재 feul의 갯수가 부족합니다");
        }                
    }

    public void Caltles_Robot_Button_OFF_method()
    {
        Caltles.talk_panel.SetActive(false);
    }

    public void Caltles_Robot_fuel_plus()
    {
        if (player_Inven.fuel > 0 && Caltles.caltles_Robot_feul < 5)
        {
            player_Inven.fuel--;
            Caltles.caltles_Robot_feul++;
            interectorble_Grip.delde();
            text_Move.nowfuel(Caltles.caltles_Robot_feul);
        }        
    }

    public void Vending_machine_rice_buy_Button()
    {       
        vending_Machine.Rice_buy();
        interectorble_Grip.delde();

    }

    public void Boat_go_button()
    {
        boat_Fuel.Boatgo();        
    }
    public void Boat_Fuel_Plus_Button() 
    {
        if (player_Inven.fuel > 0)
        {
            player_Inven.fuel--;
            boat_Fuel.Boatfuelplus();
            interectorble_Grip.delde();
        }
    }

    public void Boat_Wheel_Plus_Button()
    {
        if (player_Inven.steering_wheel > 0)
        {
            print("조타륜 증가");
            player_Inven.steering_wheel--;
            boat_Fuel.Boatwheelplus();
            interectorble_Grip.delde();
        }
    }

    public void telescopebutton()
    {
        if (boat_Fuel.boatnowwheel == 1 && boat_Fuel.boatnowfuel == 10)
        {            
            boatcamera.SetActive(false);
            minimap.SetActive(true);
        }
    }

    public void telescopeexitbutton()
    {
        boatcamera.SetActive(true);
        minimap.SetActive(false);        
    }

    

    IEnumerator Button_caltle_open()
    {               
        while (Caltles.castle_object.gameObject.transform.position != caltles_Open_Position)
        {
            Debug.Log("성문 열기");
            yield return new WaitForSeconds(1f);
            Caltles.castle_object.gameObject.transform.position = Vector3.Lerp(Caltles.castle_object.gameObject.transform.position, caltles_Open_Position, Caltles.open_speed * Time.deltaTime);
        }        
    }

    IEnumerator caltle_UI_delete()
    {
        while (Caltles.talk_panel.activeSelf)
        {
            yield return new WaitForSeconds(3f);
            Caltles.talk_panel.SetActive(false);
        }
    }
    #region
    //public void onclick(Event clickobject)
    //{
    //    GameObject 복사할 오브젝트;

    //    복사할 오브젝트 = clickobject;

    //    if (빈칸)
    //    {
    //        빈칸 = Instantiate(복사할 오브젝트);
    //    }
    //    빈칸++;
    //}
    #endregion
}
