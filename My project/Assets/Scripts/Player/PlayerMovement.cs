using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerspeed = 2;
    public float horizontalSpeed = 3;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerspeed, Space.World);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
        }
    }
}
