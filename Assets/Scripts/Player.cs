using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    private float movement;

    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.back, movement * Time.fixedDeltaTime * moveSpeed);
    }
}
