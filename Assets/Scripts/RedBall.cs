using UnityEngine;

// INHERITANCE
public class RedBall : Ball
{
    private void Start()
    {
        Awake();
        // POLYMORPHISM
        BouncingForce = 15;
    }

    // POLYMORPHISM
    protected override void Bounce()
    {
        base.Bounce();
        Debug.Log("Red ball bounced with a force of: " + BouncingForce);
    }
}
