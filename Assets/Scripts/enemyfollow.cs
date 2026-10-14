using UnityEngine;

public class enemyfollow : MonoBehaviour
{
    public Rigidbody RB;
    //My stats
    public float Speed = 2.5f;

    //Who do I walk towards?
    public GameObject Target;

    void Start()
    {
        
    }

    private void Update()
    {
        //Copied from teacher

        //Rotate to look at the player
        transform.LookAt(Target.transform);
        //Make a temp velocity variable to calculate how I should move
        //By default, I keep my old momentum
        Vector3 vel = RB.linearVelocity;
        //Walk forwards, but don't do it perfectly. Lerp towards my desired speed
        //This makes it so that if I take a knockback it takes a second for me to recover
        vel = Vector3.Lerp(vel, transform.forward * Speed, 10 * Time.deltaTime);
        //Use my old Y velocity, though. I shouldn't be able to fly
        vel.y = RB.linearVelocity.y;
        //Plug it into my rigidbody
        RB.linearVelocity = vel;
    }
}
