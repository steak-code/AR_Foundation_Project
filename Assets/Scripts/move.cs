using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField, Header("µêÀÀ·n±ì")]
    private Joystick joystick;
    [SerializeField, Header("²¾°Ê³t«×"), Range(0, 100)]
    private float  moveSpeed = 3.5f;

    private Rigidbody rig;
    private Animator ani;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        rig.velocity = new Vector3(joystick.Horizontal, 0, joystick.Vertical) * moveSpeed;
        ani.SetFloat("walk", rig.velocity.magnitude / moveSpeed);
    }
}
