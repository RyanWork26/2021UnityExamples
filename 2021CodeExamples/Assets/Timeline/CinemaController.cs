using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class CinemaController : MonoBehaviour
{
    bool Playing;
    CinemaControls cinemaControl;
    public PlayableDirector director;
    
    // Start is called before the first frame update
    void StartUp()
    {
        cinemaControl = new CinemaControls();
        
        cinemaControl.CinemaControlsBasic.PlayPause.performed += PlayPause;
        
    }

    public void OnEnable()
    {
        if (cinemaControl == null)
        {
            StartUp();
        }
        cinemaControl.Enable();
    }

    void OnDisable()
    {
        cinemaControl.Disable();

    }

    public void PlayPause(InputAction.CallbackContext cc)
    {
        if (cc.performed)
        {
            if (!Playing)
            {
                director.Play();
                //director.Pause();
                Playing = true;
            }
            else
            {
                director.Pause();
                Playing = false;
            }
        }
    }
}
