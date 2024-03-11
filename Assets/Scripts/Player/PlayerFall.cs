using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    [SerializeField] private float x, y, z;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("FallCollision"))
        {
            //Debug.Log("Detectó la colision");
            transform.position = new Vector3(x, y, z);
          
        }
    }
}
