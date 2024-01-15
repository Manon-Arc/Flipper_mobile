using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public GameObject prefabVie;
    public GameObject conteneur_vie;

    public int nombreDeVies = 3;

    private void Start()
    {
        InstancierVies();
    }

    private void InstancierVies()
    {

        for (int i = 0; i < nombreDeVies; i++)
        {
            GameObject vie = Instantiate(prefabVie, conteneur_vie.transform);

            vie.transform.position = new Vector3(i * 0.7f, 0.0f, 0.0f);
        }
    }

    public void DecrementerVies()
    {
        nombreDeVies--;
    }
}
