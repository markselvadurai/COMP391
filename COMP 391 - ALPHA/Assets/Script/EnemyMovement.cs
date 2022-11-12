using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public AnimationCurve myCurve;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate(Time.time % myCurve.length), transform.position.z);
    }
}
