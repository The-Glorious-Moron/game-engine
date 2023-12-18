using System.Collections.Generic;

public class World
{
    // Properties
    public string Name { get; set; }
    public List<GameObject> GameObjects { get; private set; }

    // Constructor
    public GameWorld(string name)
    {
        Name = name;
        GameObjects = new List<GameObject>();
    }

    // Methods
    public void AddObject(GameObject gameObject)
    {
        GameObjects.Add(gameObject);
    }

    public void RemoveObject(GameObject gameObject)
    {
        GameObjects.Remove(gameObject);
    }

    // Update method for game loop
    public void Update()
    {
        foreach (var gameObject in GameObjects)
        {
            gameObject.Update();
        }
    }
}
