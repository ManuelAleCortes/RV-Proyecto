using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class PalancaController : MonoBehaviour
{
    public XRLever elevator;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       // elevator.value = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        float upSpeed = speed * (elevator.value ? 1 : 0);

        Vector3 velocity = new Vector3(0, upSpeed, 0);

        transform.position += velocity * Time.deltaTime;
    }
}
