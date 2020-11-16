using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject end;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            end.SetActive(true);
        }

        if (collision.tag == "鑽石")
        {
            Destroy(collision.gameObject);

            count++;

            textcount.text = "鑽石數量：" + count;
        }
    }
}
