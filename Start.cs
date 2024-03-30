using Godot;
using System;

public partial class Start : Control
{
    // Called when the node enters the scene tree for the first time.
    private Button _conn;
    private GameContext _context = new GameContext();

    public override void _Ready()
    {
        _conn = GetNode<Button>("Conn");
        _conn.Pressed += (() =>
        {
            Console.WriteLine("Hello 1");
            //SQLitePCL.Batteries.Init();
            Console.WriteLine("Hello 2");
        });

        using (var context = new GameContext())
        {
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}