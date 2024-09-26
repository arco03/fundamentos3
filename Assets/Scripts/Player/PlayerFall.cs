using UnityEngine;
public class PlayerFall : MonoBehaviour
{
    [SerializeField] private float x, y, z;
    [SerializeField] Timer timer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("FallCollision"))
        {
            Debug.Log("Detectó la colision");
            timer.Die();
        }
    }
}
