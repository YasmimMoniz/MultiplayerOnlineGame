using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviourPun
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (!photonView.IsMine)
        {
            // Desativa este script se não for controlado pelo jogador local
            enabled = false;
        }
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveX, moveY) * speed;
            rb.velocity = movement;
        }
    }
}
