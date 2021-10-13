using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public int modulo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch (modulo)
            {
                case 1:
                    SceneManager.LoadScene(2);
                    break;
                case 2:
                    SceneManager.LoadScene(3);
                    break;
            }
            
        }
    }
}
