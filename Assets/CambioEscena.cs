using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public int modulo;
    public Animator transitionAnimator;
    void Start()
    {
    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {

            switch (modulo)
            {
                case 1:
                    StartCoroutine(SceneLoad(modulo));
                    break;
                case 2:
                    StartCoroutine(SceneLoad(modulo));
                    break;
                case 3:
                    StartCoroutine(SceneLoad(modulo));
                    break;
                case 4:
                    StartCoroutine(SceneLoad(modulo));
                    break;
                case 5:
                    StartCoroutine(SceneLoad(modulo));
                    break;
            }
            
        }
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {   
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneIndex);
    }

    public void Cambio()
    {
        Debug.Log("click");
        StartCoroutine(SceneLoad(modulo));
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
