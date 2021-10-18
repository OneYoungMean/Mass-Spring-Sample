using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene0_Spring : MonoBehaviour
{
    public Transform particleA;
    public Transform particleB;
    public float originLength=0.1f;
    public float originSpring = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (particleA!=null&&particleB!=null)
        {
            CalcSpringSystem();
        }
    }

    void CalcSpringSystem()
    {
        Vector3 direction = particleB.position - particleA.position;
        float directionLength = direction.magnitude;
        Vector3 directionNormal = direction.normalized;
        float pushForce = directionLength - originLength;
        Vector3 pushForward = directionNormal * pushForce * 0.5f * originSpring;
        particleA.position += pushForward;
        particleB.position -= pushForward;
    }
}
