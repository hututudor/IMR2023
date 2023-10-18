using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreManager scoreManager;
    
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.GetComponent<Dart>())
        {
            return;
        }
        
        float distance = Vector3.Distance(transform.position, other.transform.position);
        int score = (int)Math.Floor((8 - distance) * 10);
        scoreManager.AddScore(score);
    }
}
