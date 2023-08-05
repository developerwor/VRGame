using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsecen : MonoBehaviour
{
    [SerializeField] private Camera camera; // 플레이어의 카메라
    [SerializeField] private AudioSource nextstagesound; // 다음 스테이지로 넘어갈떄의 사운드

    private void Start()
    {
        camera = GetComponent<Camera>();
    }
    public void Playbutton()
    {
        StartCoroutine(Scenechnage());
        StopCoroutine(Scenechnage());
    }

    IEnumerator Scenechnage()
    {
        camera.farClipPlane = 20;
        nextstagesound.Play();
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Playdisplay");
        yield break;
    }
}
