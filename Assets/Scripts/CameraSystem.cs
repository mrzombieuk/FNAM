using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [Header("Cameras")]
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
    [SerializeField] private GameObject Office;

    [Header("GUIS and Images")]
    [SerializeField] private GameObject OfficeGUI;
    [SerializeField] private GameObject TurnAroundImage;

    [Header("Open or Close")]
    [SerializeField] private KeyCode OpenCloseCamera;
    [SerializeField] private bool CamOpen;
    [SerializeField] private float Time;

    [Header("Pause Menu")]
    [SerializeField] private GameObject PauseGui;
    [SerializeField] private KeyCode OpenClosePause;
    [SerializeField] private bool IsPaused;
   
    // Start is called before the first frame update
    public void Start()
    {
        IsPaused = false;
        PauseGui.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        CamOpen = false;
        Time = 1f;
        StartCoroutine(GameLoop());
    }

    public void ContinueGame()
    {
        IsPaused = false;
        PauseGui.SetActive(false);
    }
    
    public void Cam1Active()
    {
        Office.SetActive(false);
        Cam1.SetActive(true);
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
    }
    public void Cam2Active()
    {
        Office.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(true);
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
    }

    public void Cam3Active()
    {
        Office.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(true);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
    }
    public void Cam4Active()
    {
        Office.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(true);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
    }
    public void Cam5Active()
    {
        Office.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(true);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
    }

    IEnumerator GameLoop()
    {
        while (true)
        {
            if (Input.GetKeyDown(OpenClosePause) && IsPaused == false)
            {
                PauseGui.SetActive(true);
                StartCoroutine(Debounce(Time));
                IsPaused = true;
            }
            else if(Input.GetKeyDown(OpenClosePause) && IsPaused == true)
            {
                PauseGui.SetActive(false);
                StartCoroutine(Debounce(Time));
                IsPaused = false;
            }

            //if (Input.GetKeyDown(OpenCloseCamera) && IsPaused == false)
            //{
            //    if (CamOpen == true)
            //    {
            //        CurrentCamera.SetActive(true);
            //        OfficeCamera.SetActive(false);
            //        OfficeGUI.SetActive(false);
            //        TurnAroundImage.SetActive(false);
            //        StartCoroutine(Debounce(Time));
            //        CamOpen = false;
            //    }
            //    else if (CamOpen == false)
            //    {
            //        CurrentCamera.SetActive(false);
            //        OfficeCamera.SetActive(true);
            //        OfficeGUI.SetActive(true);
            //        TurnAroundImage.SetActive(true);
            //        StartCoroutine(Debounce(Time));
            //        CamOpen = true;
            //    }
            //}
            
        yield return null;

        }
        
    }

    IEnumerator Debounce(float Time)
    {
        yield return new WaitForSeconds(Time);
    }
}
