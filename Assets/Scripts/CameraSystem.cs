using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.Video;

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

    [SerializeField] public GameObject ActiveCam;

    [Header("Sounds")]
    [SerializeField] private AudioSource CameraChange;

    [Header("Static Screens")]
    [SerializeField] private GameObject CameraStatic;
    [SerializeField] private GameObject CameraStaticVideo;

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
        StartCoroutine(ShowStatic());
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
        ActiveCam = Cam1;
        

    }
    public void Cam2Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        ActiveCam = Cam2;
    }

    public void Cam3Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        ActiveCam = Cam3;
    }
    public void Cam4Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        ActiveCam = Cam4;
    }
    public void Cam5Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        ActiveCam = Cam5;
    }
    public void Cam6Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(true);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
        ActiveCam = Cam6;
    }
    public void Cam7Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(true);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
        ActiveCam = Cam7;
    }
    public void Cam8Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(true);
        Cam9.SetActive(false);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
        ActiveCam = Cam8;
    }
    public void Cam9Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(true);
        Cam10.SetActive(false);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
        ActiveCam = Cam9;
    }
    public void Cam10Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(false);
        Cam6.SetActive(false);
        Cam7.SetActive(false);
        Cam8.SetActive(false);
        Cam9.SetActive(false);
        Cam10.SetActive(true);
        Cam11.SetActive(false);
        Cam12.SetActive(false);
        ActiveCam = Cam10;
    }
    public void Cam11Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        Cam11.SetActive(true);
        Cam12.SetActive(false);
        ActiveCam = Cam11;
    }
    public void Cam12Active()
    {
        Office.SetActive(false);
        StartCoroutine(ShowStatic());
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
        Cam12.SetActive(true);
        ActiveCam = Cam12;
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

    IEnumerator ShowStatic()
    {
        CameraStatic.SetActive(true);
        CameraChange.Play();
        CameraStaticVideo.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        CameraStatic.SetActive(false);
        CameraStaticVideo.SetActive(false);
    }


    IEnumerator Debounce(float time)
    {
        

        yield return new WaitForSecondsRealtime(time);
    }
}
