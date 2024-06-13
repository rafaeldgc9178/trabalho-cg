using UnityEngine;

public class Press : MonoBehaviour
{
    public GameObject lata;
    public Material[] materials;
    private new Renderer renderer;

    private void Awake()
    {
        renderer = lata.GetComponentInChildren<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lata.SetActive(!lata.activeInHierarchy);
            if (lata.activeInHierarchy && renderer != null)
            {
                renderer.material = materials[Random.Range(0, materials.Length)];
            }
        }
    }
}
