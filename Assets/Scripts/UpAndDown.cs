using UnityEngine;

public class UpAndDown : MonoBehaviour
{

    public float speed = 2f;       // How fast the object moves up and down
    public float height = 0.5f;     // How far up and down it travels from its start position

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //original starting position
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;

        // Apply the new position while keeping the original X and Z
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
