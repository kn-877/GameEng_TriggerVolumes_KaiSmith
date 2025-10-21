using UnityEngine;

public class triggerscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public class TriggerSetActive : MonoBehaviour
    {
        public GameObject targetObject;

        void OnTriggerEnter(Collider other)
        {
            targetObject.SetActive(false);
        }

        void OnTriggerExit(Collider other)
        {
            targetObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
