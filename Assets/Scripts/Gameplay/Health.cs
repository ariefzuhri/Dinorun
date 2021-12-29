using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public static int healthCount = 5;
    public GameObject healthIcon;
    private List<GameObject> healthBar = new List<GameObject>();

    void Start()
    {
        healthCount = 5;

        // Buat healthIcon sebanyak nilai health
        for (int i = 0; i < healthCount; i++)
        {
            GameObject newHealthIcon = Instantiate(healthIcon);
            newHealthIcon.transform.position = transform.position + new Vector3(0 + i, 0, 0);
            healthBar.Add(newHealthIcon);
        }
    }

    void Update()
    {
        // Jika jumlah healthBar tidak sesuai dengan nilai health saat ini ...
        while (healthBar.Count > healthCount)
        {
            // ... buang healthIcon yang ada di healthBar sampai jumlahnya sesuai
            var lastIndex = healthBar.Count - 1;
            Destroy(healthBar[lastIndex]);
            healthBar.RemoveAt(lastIndex);
        }
    }
}