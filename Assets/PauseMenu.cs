using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject simulationUI;
    public GameObject GeneralSettingsUI;
    public GameObject FieldsPanelUI;
    public GameObject ParticlesPanelUI;
    public GameObject creditsPanelUI;
    public GameObject aLaCarteUI;


    public GameObject extraCannons;

    public bool isGamePaused = false;
    public bool extra = false;
    // Start is called before the first frame update
    void Start()
    {
        Pause();
        extraCannons.SetActive(true);
        extra = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            UnityEngine.Debug.Log(" Menu");
            if (isGamePaused ==false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
            
            //rb.gravityScale *= -1;
        }
    }


    public void Pause()
    {
        simulationUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        showGeneral();
        isGamePaused = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        simulationUI.SetActive(true);
        isGamePaused = false;
        Time.timeScale = 1f;
        
    }

    public void showGeneral()
    {
        GeneralSettingsUI.SetActive(true);
        FieldsPanelUI.SetActive(false);
        ParticlesPanelUI.SetActive(false);
        creditsPanelUI.SetActive(false);
    }
    public void showFields()
    {
        GeneralSettingsUI.SetActive(false);
        FieldsPanelUI.SetActive(true);
        ParticlesPanelUI.SetActive(false);
        creditsPanelUI.SetActive(false);

    }
    public void showParticles()
    {
        GeneralSettingsUI.SetActive(false);
        FieldsPanelUI.SetActive(false);
        ParticlesPanelUI.SetActive(true);
        creditsPanelUI.SetActive(false);
        hideALaCarte();

    }
    public void showCredits()
    {
        GeneralSettingsUI.SetActive(false);
        FieldsPanelUI.SetActive(false);
        ParticlesPanelUI.SetActive(false);
        creditsPanelUI.SetActive(true);

    }

    public void showALaCarte()
    {
        aLaCarteUI.SetActive(true);
        
    }
    public void hideALaCarte()
    {
        aLaCarteUI.SetActive(false);
    }

    public void toggleExtraCannons()
    {
        if (extra == true)
        {
            extraCannons.SetActive(false);
            extra = false;

        }
        else{
            extraCannons.SetActive(true);
            extra = true;
        }
    }
}
