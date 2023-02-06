using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.ProBuilder;

public class OfficeTurnAround : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private GameObject OfficeCamera;
    [SerializeField] private GameObject CameraNavImage;
    [SerializeField] private bool FacingPatio;

    void OnEnable()
    {

        OfficeCamera.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
        FacingPatio = false;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if(FacingPatio == true)
        {
            OfficeCamera.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
            CameraNavImage.SetActive(true);
            StartCoroutine(Debounce());
            
        }
        else if(FacingPatio == false)
        {
            OfficeCamera.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            CameraNavImage.SetActive(false);
            StartCoroutine(Debounce());
                 
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (FacingPatio == true)
        {
            
            StartCoroutine(Debounce());
            FacingPatio = false;

        }
        else if (FacingPatio == false)
        {
            
            StartCoroutine(Debounce());
            FacingPatio = true;

        }
    }


    IEnumerator Debounce()
    {
        yield return new WaitForSeconds(1f);
    }
}
