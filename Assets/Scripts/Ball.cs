using UnityEngine;

public class Ball : MonoBehaviour
{
    // ENCAPSULATION
    protected float BouncingForce
    {
        get
        {
            return bouncingForce;
        }
        set
        {
            if (value > 0)
            {
                bouncingForce = value;
            }
            else
            {
                Debug.LogError("Bouncing force must be greater than zero.");
            }
        }
    }
    private float bouncingForce;

    private Rigidbody ballRigidbody;

    protected void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        Bounce();
    }

    // ABSTRACTION
    protected virtual void Bounce()
    {
        ballRigidbody.AddForce(Vector3.up * bouncingForce, ForceMode.Impulse);
    }
}
