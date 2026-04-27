using UnityEngine;

public class Move : MonoBehaviour
{
    public float _speed;
    public float _jumpForce;
    public float _Xpos;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _Xpos = transform.position.x;
        Debug.Log("X座標、" + _Xpos);
        transform.Translate(_speed * Time.deltaTime, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0f, _jumpForce, 0f, ForceMode.Impulse);
            Debug.Log("ジャンプ成功");
        }
    }
    
}
