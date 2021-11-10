using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tflotante : MonoBehaviour
{
    // Start is called before the first frame update
    public float TiempoDeVida = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoDeVida -= Time.deltaTime;
        if(TiempoDeVida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
