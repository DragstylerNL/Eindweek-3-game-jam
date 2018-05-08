using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMotor : MonoBehaviour
{

    [SerializeField]
    private Camera cam;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Move(float Xmov)
    {
        Vector2 _V2Movement = new Vector2(Xmov,0);
        rb2d.AddForce(_V2Movement);
    }
}
