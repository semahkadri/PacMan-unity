using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Collision : MonoBehaviour
{
    private Rigidbody rigid;
    public Canvas canvas_gameover;
    public float sec = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        canvas_gameover = GameObject.Find("Canvas_GameOver").GetComponent<Canvas>();
        canvas_gameover.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy collision done");
            canvas_gameover.gameObject.SetActive(true);
            StartCoroutine(LateCall(canvas_gameover));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    IEnumerator LateCall(Canvas canvas_gameover)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //canvas_gameover.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
