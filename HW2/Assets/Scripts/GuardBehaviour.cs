using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Patrol());
    }
    public Transform startP;
    public Transform endP;
    private float speed = 4f;

    private Vector3 currentdir = new Vector3(5, 0, 0);
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Patrol()
    {
        while (true)
        {
            while (Vector3.Distance(transform.position, startP.position) > 0.1f)
            {
                MoveTowardsTarget(startP.position);
                yield return null;
            }
            while (Vector3.Distance(transform.position, endP.position) > 0.1f)
            {
                MoveTowardsTarget(endP.position);
                yield return null;
            }
        }
    }
    void MoveTowardsTarget(Vector3 target)
    {
        // Move there at specified speed
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
