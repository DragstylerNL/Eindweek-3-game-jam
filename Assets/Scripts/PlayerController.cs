using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    
    public float speed = 1000f;

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Move(_xMov);
        Jump(_zMov);
    }

    void Move(float _xMov)
    {
        float sendX = _xMov * speed * Time.deltaTime;
        motor.Move(sendX);
    }

    void Jump(float _zMov)
    {
        
    }
}