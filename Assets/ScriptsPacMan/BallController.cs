using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed = 60;
    public float sec = 8f;
    private Rigidbody rigid;
    private Canvas canvas_win;
    public int coins;

    public GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        canvas_win = GameObject.Find("Canvas_Win").GetComponent<Canvas>();
        canvas_win.gameObject.SetActive(false);
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Debug.Log("coins collected");
            coins = coins + 1;
            Debug.Log(coins);
            col.gameObject.SetActive(false);
            //yield return new WaitForSeconds(delay_t);
            StartCoroutine(LateCall(col));
            //score.AddScore(coins);
            GameObject.Find("Score").GetComponent<TMP_Text>().text = "Score : " + coins;
            if (coins == 10)
            {
                canvas_win.gameObject.SetActive(true);
                StartCoroutine(WinPanel(canvas_win));
            }
            
        }
    }

    //after same sec Object to false
    IEnumerator LateCall(Collider col)
    {
        yield return new WaitForSeconds(sec);
        col.gameObject.SetActive(true);
    }

    IEnumerator WinPanel(Canvas canvas_win)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rigid.AddForce(-Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rigid.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(-Vector3.forward * speed * Time.deltaTime);
        }
    }
}
