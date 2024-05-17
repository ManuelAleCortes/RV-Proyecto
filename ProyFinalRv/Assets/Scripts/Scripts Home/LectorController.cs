using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectorController : MonoBehaviour
{
    public GameObject puerta;
    private Animator puertaAnim;
    int numero;

    // Start is called before the first frame update
    void Start()
    {
        puertaAnim = puerta.GetComponent<Animator>();
        numero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tarjeta"))
        {
            puertaAnim.enabled = true;
            if (numero % 2 == 0)
            {
                puertaAnim.SetBool("DoorClosing", false);
            }
            else
            {
                puertaAnim.SetBool("DoorClosing", true);
            }
            numero++;
        }
    }
}
