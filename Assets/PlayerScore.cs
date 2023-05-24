using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int hitCount = 0;

    private void OnCollisionEnter(Collision other)
    {
        hitCount++;
        Debug.Log("You Have Bumped Into Things: " + hitCount);
    }
}
