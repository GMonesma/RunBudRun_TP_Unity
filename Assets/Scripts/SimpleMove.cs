using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    
    public Transform target;
    public float vitesse = 1.0f;
    private Vector3 randomTargetPos;
    public float randomTargetDistMin = 2;
    public float randomTargetDistMax = 10;
    public bool useRandomTarget = false;
    public int Sensisbility;
    private Vector3 DirectionDeplacement;
    

    void Start ()
    {
        SetRandomTargetPos();
    }

    void SetRandomTargetPos()
    {
        randomTargetPos = Random.onUnitSphere;
        randomTargetPos.y = 0;
        randomTargetPos = randomTargetPos.normalized * Random.Range(randomTargetDistMin, randomTargetDistMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            useRandomTarget = true;

        Vector3 targetPos;
        if (useRandomTarget || target == null)
            targetPos = randomTargetPos;
        else
            targetPos = target.position;

        Vector3 deplacement = target.position - transform.position;
        deplacement = deplacement.normalized * vitesse * Time.deltaTime;
        transform.position += deplacement;

        transform.LookAt(target);
    }
    
}
