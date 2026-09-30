using UnityEngine;
using UnityEngine.InputSystem;

public class KajabunScript : MonoBehaviour
{
    public Camera camera;
    public Rigidbody RB;
    public float MSensitivity = 1;
    public float Speed = 5;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse Movement
        Vector2 mouse = Mouse.current.delta.ReadValue();

        camera.transform.Rotate(mouse.y * MSensitivity * -1, mouse.x * MSensitivity, 0);

        //Walking
        Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
        if (Keyboard.current.wKey.isPressed)
            vel += transform.forward * Speed;
        if (Keyboard.current.sKey.isPressed)
            vel += transform.forward * -Speed;
        if (Keyboard.current.aKey.isPressed)
            vel += transform.right * -Speed;
        if (Keyboard.current.dKey.isPressed)
            vel += transform.right * Speed;
        RB.linearVelocity = vel;
    }
}
