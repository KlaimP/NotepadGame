using Godot;
using System;

public partial class EditText : RichTextLabel
{
	[Export]
	public MainTextEdit mainTextEditObject;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void UseObject()
	{
		mainTextEditObject.Use(this);
		GD.Print("[b][bgcolor=red]Press![/bgcolor][/b]");
		GD.PrintRich("[b][bgcolor=red]Press![/bgcolor][/b]");

	}

	private void _on_gui_input(InputEvent @event)
	{
		if (@event is InputEventMouseButton eventKey) 
		{
			if (eventKey.ButtonIndex == MouseButton.Left && !eventKey.Pressed)
			{
				UseObject();
			}
		}
	}
}
