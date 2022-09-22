using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 12f;
    public float rotationSpeed = 30f;

    Vector3 velocity;

    void Update()
    {
        if (Input.GetKey("w")) transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey("s")) transform.Translate(Vector3.right * -speed * Time.deltaTime);

        if (Input.GetKey("a")) transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        if (Input.GetKey("d")) transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
