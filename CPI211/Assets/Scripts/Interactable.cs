using UnityEngine;


    public class Interactable : MonoBehaviour
    {
        //Base class for interactble objects
        public float radius = 3f;
        bool hasInteracted = false;
        public Transform player;

        public virtual void Interact()
        {
            //method is meant to be overriden
        }

        void Update()
        {
           if(!hasInteracted)
            {
                float distance = Vector3.Distance(player.position, transform.position);
                if (distance <= radius)
                {
                    Debug.Log("INTERACTED");
                    hasInteracted = true;
                }
            } 
        }
        

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, radius);
        }

    }
