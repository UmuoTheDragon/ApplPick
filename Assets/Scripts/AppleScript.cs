using UnityEngine;

public class AppleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //public SpriteRenderer SR;
    public float AppleTimer = 10;

    // Update is called once per frame
    void Update()
    {
        AppleTimer -= Time.deltaTime;
        if (AppleTimer <= 0)
        {
            //change color later;
            Destroy(gameObject);
        }
    }

    public void GetBumped()
    {
        Destroy(gameObject);
    }
}
