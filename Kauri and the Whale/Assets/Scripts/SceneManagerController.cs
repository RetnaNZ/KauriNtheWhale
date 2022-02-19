using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{

    public static SceneManagerController smc;

    public int PakiaHill = 1;
    public int HokiangaIndex = 2;
    public int Waipoa = 3;

    bool pakiaActive;
    bool hokiangaActive;
    bool waipoaActive;

    private void Awake()
    {
        smc = this;
    }

    // LOAD SCENES SECTION

    public void LoadSceneAt(int sceneIndex)
    {
        if (sceneIndex == HokiangaIndex)
        {
            if (hokiangaActive != true)
            {
                SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
                hokiangaActive = true;
            }

        }

        if (sceneIndex == PakiaHill)
        {
            if (pakiaActive != true)
            {
                SceneManager.LoadScene(PakiaHill, LoadSceneMode.Additive);
                pakiaActive = true;
            }
        }

        if (sceneIndex == Waipoa)
        {
            if (waipoaActive != true)
            {
                SceneManager.LoadScene(Waipoa, LoadSceneMode.Additive);
                waipoaActive = true;
            }
        }
    }

    // UNLOAD SCENES SECTION
    public void UnloadSceneAt(int sceneIndex)
    {

        if (sceneIndex == HokiangaIndex)
        {
            if (hokiangaActive)
            {
                SceneManager.UnloadSceneAsync(HokiangaIndex);
                hokiangaActive = false;
            }

        }

        if (sceneIndex == PakiaHill)
        {
            if (pakiaActive)
            {
                SceneManager.UnloadSceneAsync(PakiaHill);
                pakiaActive = false;
            }
        }

        if (sceneIndex == Waipoa)
        {
            if (waipoaActive)
            {
                SceneManager.UnloadSceneAsync(Waipoa);
                waipoaActive = false;
            }
        }

    }
}
