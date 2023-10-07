using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusManager : MonoBehaviour
{
    public float attackDistance = 0.1f;

    public Transform cactus1Transform;
    public Transform cactus2Transform;

    public Animator cactus1Animator;
    public Animator cactus2Animator;

    void Start()
    {        
    }

    void Update()
    {
        float distance = Vector3.Distance(cactus1Transform.position, cactus2Transform.position);

        Debug.Log(distance);

        bool areCactusesNear = distance <= attackDistance;
        SetCactusesNear(areCactusesNear);
    }

    void SetCactusesNear(bool areCactusesNear)
    {
        cactus1Animator.SetBool("isNearOtherCactus", areCactusesNear);
        cactus2Animator.SetBool("isNearOtherCactus", areCactusesNear);
    }
}
