using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public Transform TR;
    public SpriteRenderer SP;
    public Rigidbody RB;
    public Camera mainCamera;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //tutorial used: SunnyValleyStudio - Adding 2D Sprites to 3D
    private void LateUpdate()
    {
        //get cam pos
        Vector3 cameraPosition = mainCamera.transform.position;
        //rotate on y axis
        cameraPosition.y = transform.position.y;
        //sprite faces camera
        transform.LookAt(cameraPosition);
        //rotate 180
        transform.Rotate(0f, 180f, 0f);
    }
}
