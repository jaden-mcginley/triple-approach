using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_FloorSpikes : MonoBehaviour
{
    [SerializeField] GameObject floorSpikesPrefab;
    [SerializeField] GameObject floorSpikesGame;

    internal string animationName_FloorSpikeRise = "anim_FloorSpikesRise";
    internal string animationName_FloorSpikeApproach = "anim_FloorSpikesApproach";

    private void Start()
    {
        SpawnFloorSpikes();
        AnimateFloorSpikesRise();
        StartCoroutine(WaitFor_AnimateFloorSpikesApproach(4f));
        StartCoroutine(WaitFor_DestroyFloorSpikes(30f));
    }

    private void SpawnFloorSpikes()
    {
        floorSpikesGame = Instantiate(floorSpikesPrefab);
    }

    private void AnimateFloorSpikesRise()
    {
        floorSpikesGame.GetComponent<Animator>().Play(animationName_FloorSpikeRise);
    }

    private IEnumerator WaitFor_AnimateFloorSpikesApproach(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        AnimateFloorSpikesApproach();
    }

    private void AnimateFloorSpikesApproach()
    {
        floorSpikesGame.GetComponent<Animator>().Play(animationName_FloorSpikeApproach);
    }

    private IEnumerator WaitFor_DestroyFloorSpikes(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        DestroyFloorSpikes();
    }

    private void DestroyFloorSpikes()
    {
        Destroy(this);
    }
}
