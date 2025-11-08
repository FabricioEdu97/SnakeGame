using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private BoxCollider2D spawnArea;

    private void Start()
    {
        RandomPositionFood();
    }

    public void RandomPositionFood()
    {
        Bounds bounds = spawnArea.bounds;

        Vector2 randomPos = new Vector2(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y)
        );

        float roundXPos = Mathf.Round(randomPos.x);
        float roundYPos = Mathf.Round(randomPos.y);

        transform.position = new Vector2(roundXPos, roundYPos);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            RandomPositionFood();
    }
}
