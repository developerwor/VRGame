## 🤖 천공섬 VR 게임

- VR 환경 프로젝트

## 💻 개발환경
- Unity
- Microsoft visual studio

## 📂 주요 코드 기능



```bash
< 코드 설명(정리중) >
   |-- AI_ment.cs                  // 로봇의 작동 및 정지
   |-- Robot_Ai.cs                 // 로봇을 특정위치에 랜덤 이동 및 코멘트 표시
   |-- fuel_post.cs                // 로봇이 연료를 받기위한 기능
   |-- petrobot.cs                 // 아이템을 들어주는 펫 로봇을 움직이게 하기위한 기능
   |-- refrigeratorarm.cs          // 냉장고 로봇이 팔을 지속적으로 회전하는 기능
   |-- refrigertormove.cs          // 또 다른 냉장고 로봇이 특정 조건에 이동하기 위한 기능
   |-- vending_machine.cs          // 밥을 구입하기 위한 자판기 로봇
   |-- washer.cs                   // 아이템 획득을 위해 발판이 되어주는 세탁기 로봇
   |-- 
   |-- ItemSlot.cs                 // 펫 로봇에게 아이템을 주었을때 위치 지정
   |-- itemslot_test.cs            // 펫 로봇이 가진 아이템의 유무 체크
   |-- 
   |-- Player_input.cs             // 플레이어 이동(Move, JUMP, Fly, Gravity)
   |-- Player_inven.cs             // 플레이어의 상태 표시(아이템 보유, 공복 및 만복)
   |-- areaContents.cs             // 플레이어 리스폰(에리어 이탈, 강가)
   |-- 
   |-- Avata_ik.cs                 // 플레이어의 발 위치와 회전을 조정
   |-- VRRig_copy.cs               // VR 환경에서 플레이어가 자연스럽게 동작
   |-- 
   |-- watch.cs                    // 시간 컨트롤
   |-- 
   |-- boat_fuel.cs                // 보트의 현재 상황 및 이벤트(조타륜 및 배터리 현황)
   |-- 
   |-- Button_zip.cs               // 보트 연료 및 조타륜 충전, 성문 열기
   |-- interectorble_grip.cs       // 아이템 획득
   |-- 
   |-- caltles.cs                  // 플레이어 감지 및 그에 따른 이벤트
   |-- 
   |-- Button_rotation.cs          // 3D 버튼의 회전 및 ON/OFF
   |-- cloud_rotation.cs           // 구름 오브젝트 이동
   |-- item_rotation.cs            // 아이템 모션
   |--   
   |-- loadsecen.cs                // 씬 이동
   |-- 
   |-- cales_text_move.cs          // 텍스트 입력 모션   
   |-- 
   |-- tree_delete.cs              // 나무가 작아지는 모션
   |--    
```

<br />

## 📚 사용된 라이브러리

- `UnityEngine` : 유니티의 기본적인 라이브러리 게임 오브젝트, 컴포넌트, 물리 시뮬레이션 등을 다루는 기능
- `UnityEngine.XR` : 가상현실 (VR), 증강현실 (AR) 및 혼합현실 (MR)과 같은 XR 기술을 구현하기 위한 공식 패키지.

