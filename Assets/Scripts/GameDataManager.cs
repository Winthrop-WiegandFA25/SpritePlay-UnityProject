using UnityEngine;

public class GameDataManager : MonoBehaviour {
    // Our reference to the singleton instance
    public static GameDataManager Instance; 
    
    public float score;  // A field of the object

    private void Awake() {
    	// If an instance exists, destroy it
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

		// Otherwise, this instance I am creating
		// is it, but don't let Unity destroy it
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}