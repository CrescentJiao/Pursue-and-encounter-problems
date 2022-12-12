using UnityEngine;


public class WukongMove : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;
    //移动速度

  //  private CharacterController _characterController;
    [SerializeField] public static float m_moveSpeed = 0f;
     //float m_turnSpeed = 200;



    //[SerializeField] private Rigidbody m_rigidBody = null;
    public static float h = 0;



    private float m_currentV = 0;
    private float m_currentH = 0;

    private readonly float m_interpolation = 10;
    private readonly float m_walkScale = 0.33f;



    private bool m_wasGrounded;
    private Vector3 m_currentDirection = Vector3.zero;



    private Animator animator;

    private bool m_isGrounded;

    //private List<Collider> m_collisions = new List<Collider>();



    void Start()
    {
        animator = GetComponent<Animator>();
        // myAnimator.animators[0] = new Animator();//赋值
        //  myAnimator.animators[0] = ani;

        // myAnimator.animators[0].SetFloat()
        //m_animator.SetBool("walk", false);
        animator.SetFloat("speedh", 0);
    }



    void FixedUpdate()
    {



    }

    void Update()
    {

        /*//角色坐标移动实现   基于当前角色视角的方向移动，适用于3d游戏
        //根据输入的x y值获得移动方向
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(horizontal, 0f, vertical);
        // 计算 基于当前物体坐标，要移动的方向
        moveDirection = transform.TransformDirection(moveDirection) * movespeed;
        // 移动
        _characterController.Move(Vector3.right * movespeed * Time.deltaTime);
    **/
        float v = 0;



        Transform camera = Camera.main.transform;

        if (Input.GetKey(KeyCode.LeftShift))
        {

            v *= m_walkScale;
            h *= m_walkScale;
        }

        m_currentV = Mathf.Lerp(m_currentV, v, Time.deltaTime * m_interpolation);
        m_currentH = Mathf.Lerp(m_currentH, h, Time.deltaTime * m_interpolation);

        Vector3 direction = camera.forward * m_currentV + camera.right * m_currentH;

        float directionLength = direction.magnitude;
        direction.y = 0;
        direction = direction.normalized * directionLength;

        if (direction != Vector3.zero)
        {
            m_currentDirection = Vector3.Slerp(m_currentDirection, direction, Time.deltaTime * m_interpolation);

            //transform.rotation = Quaternion.LookRotation(m_currentDirection);
            // transform.position += m_currentDirection * m_moveSpeed * Time.deltaTime;
            transform.position = new Vector3 (transform.position.x+(m_currentDirection * m_moveSpeed * Time.deltaTime)[0], transform.position.y, transform.position.z);

            // m_animator.SetFloat("animation", direction.magnitude);

            // RunandStop();
            animator.SetFloat("speedh", h);

        }

    }

    void RunandStop()
    {
        if (h == 0)
        {
            //animator.SetFloat("speedv", speed);

        }
        else if (h == 1)
        {
            //  animator.SetFloat("speedv", speed);

        }

    }
}