using UnityEngine;

public class exampleScript : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        renderer.material.color = Random.ColorHSV();
    }
}
