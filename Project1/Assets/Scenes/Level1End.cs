using UnityEngine;
using UnityEngine.SceneManagement;



public class Level1End : MonoBehaviour
{
    public GameObject window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        // Load Level 2 Scene
        SceneManager.LoadScene("Level2");
    }

 
}
