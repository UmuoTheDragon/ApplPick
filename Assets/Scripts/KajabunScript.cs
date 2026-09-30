using UnityEngine;
using UnityEngine.InputSystem;

public class KajabunScript : MonoBehaviour
{
    public Camera camera;
    public Rigidbody RB;
    public AppleScript ApplePrefab;
    public float MSensitivity = 1;
    public float Speed = 5;
    public float AppleTimer = 10;
    public int Score = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //bapple
        AppleTimer -= Time.deltaTime;
        if (AppleTimer <= 0)
        {
            AppleTimer = 5;
            Instantiate(ApplePrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(0, 1)), Quaternion.identity);
        }

        //Mouse Movement
        Vector2 mouse = Mouse.current.delta.ReadValue();

        transform.Rotate(0, mouse.x * MSensitivity, 0);
        camera.transform.Rotate(mouse.y * MSensitivity * -1, 0, 0);

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

    public void UpdateScore()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        AppleScript Apple = other.GetComponent<AppleScript>();
        if (Apple != null)
        {
            Apple.GetBumped();
            Score++;

        }
    }
}
