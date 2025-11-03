using UnityEngine;
using System.Collections;

public class BoxContactScript : MonoBehaviour
{
    public ParticleSystem particlePrefab;
    private float contactTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        contactTime = Time.time;
    }

    // Update is called once per frame
    void Update(){}
    
    void OnCollisionEnter2D(Collision2D other) {
        if ((other.gameObject.tag == "Player") && (Time.time-contactTime > 4.0f) ) {
            ParticleSystem part = Instantiate(particlePrefab);
            part.transform.position = gameObject.transform.position;
            Debug.Log(part.transform.position);
            part.Play();
            contactTime = Time.time;

            //GameObjectGameObject.FindGameObjectWithTag("GameDataManager");
            GameDataManager.Instance.score++;
        }
    }
}
