using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_SpawnAttack : MonoBehaviour
{
    [SerializeField] internal scr_GameManager gameManager;
    [SerializeField] private GameObject[] pickableAttacks;
    [SerializeField] private List<GameObject> activeAttacks;

    private int randomAttack;

    [SerializeField] internal float initialDelay = 3f;
    [SerializeField] internal float attackInterval = 1f;

    internal int newIndex = -1;

    void Start()
    {
        InvokeRepeating("PickAttack", initialDelay, attackInterval);
        InvokeRepeating("DestroyOldestAttack", 30f, 30f);
    }

    private void Update()
    {
        if (gameManager.gameSettings.gameOver)
        {
            CancelInvoke("PickAttack");
            CancelInvoke("DestroyOldestAttack");
        }
    }

    void PickAttack()
    {
        randomAttack = Random.Range(0, pickableAttacks.Length + 1);

        if (randomAttack == 0) // Big Floating Rocks
        {
            SpawnAttack_BigFloatingRocks();
        }
        else if (randomAttack == 1) // Floor Spikes
        {
            SpawnAttack_FloorSpikes();
        }
        else if (randomAttack == 2) // Fallen Logs
        {
            SpawnAttack_FallenLogs();
        }
        else if (randomAttack == 3) // Standing Trees
        {
            SpawnAttack_StandingTrees();
        }
        else if (randomAttack == 4) // Spinning Log
        {
            SpawnAttack_SpinningLog();
        }
    }

    void SpawnAttack_BigFloatingRocks()
    {
        activeAttacks.Add(Instantiate(pickableAttacks[0]));
    }

    void SpawnAttack_FloorSpikes()
    {
        // Instantiate
        activeAttacks.Add(Instantiate(pickableAttacks[1]));
    }

    void SpawnAttack_FallenLogs()
    {
        activeAttacks.Add(Instantiate(pickableAttacks[2]));
    }

    void SpawnAttack_StandingTrees()
    {
        activeAttacks.Add(Instantiate(pickableAttacks[3]));
    }

    void SpawnAttack_SpinningLog()
    {
        // Instantiate
    }

    private void DestroyOldestAttack()
    {
        newIndex += 1;
        Destroy(activeAttacks[newIndex]);
    }
}
