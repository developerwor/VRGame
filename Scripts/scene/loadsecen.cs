using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsecen : MonoBehaviour
{
    [SerializeField] private Camera camera; // �÷��̾��� ī�޶�
    [SerializeField] private AudioSource nextstagesound; // ���� ���������� �Ѿ���� ����

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
