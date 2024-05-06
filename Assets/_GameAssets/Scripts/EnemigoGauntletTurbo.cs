using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGauntletTurgo : MonoBehaviour
{
    [Header("Velocidad al andar")]
    public float walkSpeed;
    [Header("Velocidad al correr")]
    public float runSpeed;
    [Header("Distancia a partir de la cual empieza a correr")]
    public float runDistance;
    [Header("Distancia a partri de la cual se detiene")]
    public float stopDistance;
    [Header("Tag del GameObject al que va a seguir")]
    public string targetTag = "Player";

    private Transform transformPlayer;
    private float currentSpeed;
    private float distancia;
    void Start()
    {
        transformPlayer = GameObject.FindGameObjectWithTag(targetTag).transform;
    }

    // Update is called once per frame
    void Update()
    {
        distancia = (transformPlayer.position - transform.position).magnitude;
        if (distancia <= runDistance)
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
        transform.LookAt(transformPlayer);
        if (distancia > stopDistance)
        {
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        }
        else {
            //Disparar?
            //GetComponentInChildren<Animator>().SetTrigger("nombredeltrigger");
        }
    }
}
