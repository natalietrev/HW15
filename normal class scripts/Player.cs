using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    private string name;
    private Room currentRoom;

    public Player(string name)
    {
        this.name = name;
        this.currentRoom = null;
    }

    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }

    public Room getPreviousRoom()
    {
        return this.previousRoom;

    public void setCurrentRoom(Room r)
    {
        this.currentRoom = r;
    }

    public void setPreviousRoom(Room p)
    {
        this.previousRoom = p;

}
