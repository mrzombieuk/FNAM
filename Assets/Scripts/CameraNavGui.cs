using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraNavGui : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject CameraNavGUI;
    [SerializeField] private GameObject OfficeNavGUI;
    [SerializeField] private GameObject OfficeCamera;
    [SerializeField] private GameObject Cam1;
    [SerializeField] private GameObject Cam2;
    [SerializeField] private GameObject Cam3;
    [SerializeField] private GameObject Cam4;
    [SerializeField] private GameObject Cam5;
    [SerializeField] private GameObject Cam6;
    [SerializeField] private GameObject Cam7;
    [SerializeField] private GameObject Cam8;
    [SerializeField] private GameObject Cam9;
    [SerializeField] private GameObject Cam10;
    [SerializeField] private GameObject Cam11;
    [SerializeField] private GameObject Cam12;

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        if(OfficeNavGUI.activeSelf == true)
        {
            OfficeNavGUI.SetActive(false);
            CameraNavGUI.SetActive(true);
            
            StartCoroutine(Delay());
        }
        else if(OfficeNavGUI.activeSelf == false)
        {
            OfficeNavGUI.SetActive(true);
            CameraNavGUI.SetActive(false);
            OfficeCamera.SetActive(true);
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
            Cam8.SetActive(false);
            Cam9.SetActive(false);
            Cam10.SetActive(false);
            Cam11.SetActive(false);
            Cam12.SetActive(false);
            
            StartCoroutine(Delay());
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(Delay());
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
    }
}
