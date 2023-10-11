using UnityEngine;

// INHERITANCE
public class BlueBall : Ball
{
    private void Start()
    {
        Awake();
        // POLYMORPHISM
        BouncingForce = 10;
    }

    // POLYMORPHISM
    protected override void Bounce()
    {
        base.Bounce();
        Debug.Log("Blue ball bounced with a force of: " + BouncingForce);
    }
}