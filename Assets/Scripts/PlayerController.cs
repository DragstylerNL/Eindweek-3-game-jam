using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;

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
    }

    void Move(float _xMov)
    {
        
    }
}