using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading_Start_menu : MonoBehaviour
{


    public GameObject prograss;

    AsyncOperation async;


    // Use this for initialization
    void Start()
    {

        prograss.GetComponent<Image>().rectTransform.localScale = new Vector3(0, 1, 1);
        StartCoroutine(LoadMainGame());


    }

    IEnumerator LoadMainGame()
    {

        yield return new WaitForSeconds(0.5f);

        async = SceneManager.LoadSceneAsync("mainMenu");
        async.allowSceneActivation = false;

        while (!async.isDone)
        {

            Debug.Log(async.progress);
            prograss.GetComponent<Image>().rectTransform.localScale = new Vector3(async.progress, 1, 1);

            if (async.progress == 0.9f)
            {

                async.allowSceneActivation = true;

            }

            yield return null;


        }









    }





}