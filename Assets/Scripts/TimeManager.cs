using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float maxTime = 30;  // half a minute
    public TextMeshProUGUI badLabel;
    private float startTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.time;
        badLabel.text = "You are taking too long!!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > 0.9 * maxTime)
        {
            badLabel.gameObject.SetActive(true);
        }

        if (Time.time - startTime > maxTime)
        {
            badLabel.text = "Go Back!!";
            SceneManager.LoadScene(0); // Go back to the start!
        }
        
    }
}
