using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGateBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Patrol());
    }
    public Transform startP;
    public Transform endP;
    public float speed = 0.955f;

    private Vector3 currentdir = new Vector3(5, 0, 0);
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Patrol()
    {
                yield return new WaitForSeconds(0f);

        while (true)
        {
            while (Vector3.Distance(transform.position, startP.position) > 0.1f)
            {
                MoveTowardsUp(startP.position);
                yield return null;
            }
            while (Vector3.Distance(transform.position, endP.position) > 0.1f)
            {
                
                MoveTowardsDown(endP.position);
                yield return null;
            }
        }
    }
    void MoveTowardsDown(Vector3 target)
    {
        // Move there at specified speed
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime * 4);
    }
    void MoveTowardsUp(Vector3 target)
    {
        // Move there at specified speed
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
