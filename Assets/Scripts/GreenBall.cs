using UnityEngine;

// INHERITANCE
public class GreenBall : Ball
{
    private void Start()
    {
        Awake();
        // POLYMORPHISM
        BouncingForce = 5;
    }

    // POLYMORPHISM
    protected override void Bounce()
    {
        base.Bounce();
        Debug.Log("Green ball bounced with a force of: " + BouncingForce);
    }
}
