
using UnityEngine;


public interface IInteractable
{
    void Interact();
}


public interface IMovable
{
    void Move();
}








public abstract class Animal
{
    public string animalName;
    public float hunger;
    public bool isSleeping;

   
    public abstract void MakeSound();
}



// Crocodile 
public class Crocodile : Animal, IInteractable, IMovable
{
    public Crocodile()
    {
        animalName = "Crocodile";
        hunger = 70.0f;
        isSleeping = false;
    }

    public override void MakeSound()
    {
        Debug.Log(" Growls Growls Growls Growls");
    }

    public void BaskInSun() // crocodile unique behaviour
    {
        Debug.Log("I am basking in the sun");
    }

    //  IInteractable
    public void Interact()
    {
        Debug.Log("You are interacting with the Crocodile!");
        BaskInSun();
    }

    //  IMovable
    public void Move()
    {
        Debug.Log("Crocodile walks slowly");
    }
}


// Kangaroo 
public class Kangaroo : Animal, IInteractable, IMovable
{
    public Kangaroo()
    {
        animalName = "Kangaroo";
        hunger = 40.0f;
        isSleeping = false;
    }

    public override void MakeSound()
    {
        Debug.Log("Kang Kang Kang Kang Kang");
    }

    public void JumpAround() //Kangaroo unique behaviour
    {
        Debug.Log("Kangaroo is jumping around!");
    }

    // IInteractable
    public void Interact()
    {
        Debug.Log("You are interacting with the Kangaroo");
        JumpAround();
    }

    //IMovable
    public void Move()
    {
        Debug.Log("Kangaroo hops around, Yaayyyyyy ");
    }
}

// Dolphin
public class Dolphin : Animal, IInteractable, IMovable
{
    public Dolphin()
    {
        animalName = "Dolphin";
        hunger = 25.0f;
        isSleeping = false;
    }

    public override void MakeSound()
    {
        Debug.Log(" Clicks Clicks Clicks Clicks");
    }

    public void JumpThroughHoops()
    {
        Debug.Log("Dolphin is jumping ");
    }

    
    public void Interact()
    {
        Debug.Log("You are interacting with the Dolphin!");
        JumpThroughHoops();
    }

    
    public void Move()
    {
        Debug.Log("Dolphin swims gracefully!");
    }
}



// Monkey
public class Monkey : Animal, IInteractable, IMovable
{
    public Monkey()
    {
        animalName = "Monkey";
        hunger = 30.0f;
        isSleeping = false;
    }

    public override void MakeSound()
    {
        Debug.Log("khoooo khoooo khoooo khoooo khoooo");
    }

    public void SwingOnVines() //Monkey unique behaviour
    {
        Debug.Log("Monkey is swinging on vines!");
    }

    
    public void Interact()
    {
        Debug.Log("You are interacting with the Monkey!");
        SwingOnVines();
    }

    
    public void Move()
    {
        Debug.Log("Monkey swings on the trees!");
    }
}

