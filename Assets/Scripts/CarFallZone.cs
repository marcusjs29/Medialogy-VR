using UnityEngine;

public class CarScoreZone : MonoBehaviour
{
    public AudioSource scoreAudio;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that fell into the zone is a car
        if (other.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>() != null)
        {
            // 1. Play the scoring sound instantly
            if (scoreAudio != null)
            {
                scoreAudio.Play();
            }

            // 2. Destroy the car after 0.2 seconds so it clears the space
            Destroy(other.gameObject, 0.2f);

            Debug.Log("Car destroyed and score counted!");
        }
    }
}
