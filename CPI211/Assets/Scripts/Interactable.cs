using UnityEngine;


    public class Interactable : MonoBehaviour
    {
        //Base class for interactble objects
        public Transform player;

        public virtual void Interact()
        {
            //method is meant to be overriden
        }

        private void OnTriggerEnter(Collider other)
        {
            if( other.gameObject.tag == "Player")
            {
            Destroy(this.gameObject);
            }
        }

    }
