using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseControl : MonoBehaviour
{

    [SerializeField] private GameObject QuitGameYesNo;
    [SerializeField] private GameObject QuitGameButton;

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ShowYesNo()
    {
        if(QuitGameYesNo.activeInHierarchy == false)
        {
            QuitGameButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
            QuitGameYesNo.SetActive(true);
        }
        
    }

    public void HideYesNo()
    {
        QuitGameButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
        QuitGameYesNo.SetActive(false);
    }

}
