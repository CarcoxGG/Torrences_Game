using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantRandomly : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objetoInstantaneo;
    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0, objetoInstantaneo.Length);
        Instantiate(objetoInstantaneo[n], pos.position, objetoInstantaneo[n].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
