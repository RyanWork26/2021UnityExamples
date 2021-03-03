using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;

public class ECSParticleSystem : MonoBehaviour
{
    CinemaControls ecsControls;
    public int numEntities;
    public int maxEntities;
    public Entity entityPrefab;
    public EntityArchetype entityArchetypePrefab;
    public GameObject ecsGameObject;
   // PhysicsEventSystem pes;
    public float rand;
    // Start is called before the first frame update
    void Start()
    {
        ecsControls = new CinemaControls();
       // pes=  World.DefaultGameObjectInjectionWorld.GetExistingSystem<PhysicsEventSystem>();
        ecsControls.Enable();
        //pes.randomness = rand;
    }

    // Update is called once per frame
    void Update()
    {
        float test = ecsControls.ECSTest.SpawnEntity.ReadValue<float>();
        if (test != 0)
        {
            SpawnEntity();
        }
    }
    public void SpawnEntity()
    {
        if (numEntities < maxEntities)
        {
            numEntities++;
            // World.DefaultGameObjectInjectionWorld.EntityManager.Instantiate(entityPrefab);
            Instantiate(ecsGameObject);
        }
    }
}
