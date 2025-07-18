using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 2f;
    public float MaxMovement = 2f;

    private void Awake()
    {
        if (DataManager.Instance != null)
            Speed = DataManager.Instance.PaddleSpeed;
    }

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;
    }
}
