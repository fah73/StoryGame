using UnityEngine;
using UnityEngine.SceneManagement;
public class TeaThief : MonoBehaviour
{
    public float speed = 4f;
    public GameObject teacup;

    bool hasCup = false;
    Vector2 escapePoint;

    void Start()
    {
        escapePoint = new Vector2(15, transform.position.y);
    }

    void Update()
    {
        if (!hasCup)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                teacup.transform.position,
                speed * Time.deltaTime
            );
        }
        else
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                escapePoint,
                speed * Time.deltaTime
            );
        }

        if(hasCup && transform.position.x > 14)
    {
        SceneManager.LoadScene("Level1");
    }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teacup"))
        {
            hasCup = true;

            teacup.transform.SetParent(transform);
            teacup.transform.localPosition = new Vector2(0.5f, 0);
        }
    }
}