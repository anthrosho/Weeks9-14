using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public bool Player1 = true;

    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Player1)
        {
            // WASD controls
            if (Input.GetKey(KeyCode.W)) movement.y += 1;
            if (Input.GetKey(KeyCode.S)) movement.y -= 1;
            if (Input.GetKey(KeyCode.A)) movement.x -= 1;
            if (Input.GetKey(KeyCode.D)) movement.x += 1;
        }
        else
        {
            // Arrow key controls
            if (Input.GetKey(KeyCode.UpArrow)) movement.y += 1;
            if (Input.GetKey(KeyCode.DownArrow)) movement.y -= 1;
            if (Input.GetKey(KeyCode.LeftArrow)) movement.x -= 1;
            if (Input.GetKey(KeyCode.RightArrow)) movement.x += 1;
        }

        // Apply movement to BOTH cases
        transform.position += (Vector3)(movement.normalized * speed * Time.deltaTime);
    }
}