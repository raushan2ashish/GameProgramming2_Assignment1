using UnityEngine;
using System.Collections.Generic;

public class AnimalHandler : MonoBehaviour
{
    [System.Serializable]
    public struct AnimalData
    {
        public string animalName;
        public float hunger;
        public bool isSleeping;
        public GameObject habitat;
    }


    public List<AnimalData> animals = new List<AnimalData>();

   
    public AnimalData GetAnimalByHabitat(GameObject habitat)
    {
        foreach (AnimalData animal in animals)
        {
            if (animal.habitat == habitat)
            {
                return animal;
            }
        }
        return default;
    }

   
    public string GetAnimalInfo(AnimalData animal)
    {
        return $"{animal.animalName}\nHunger: {animal.hunger}\nisSleep: {animal.isSleeping}";
    }
}
