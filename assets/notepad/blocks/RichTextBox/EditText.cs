using Godot;
using System;

public partial class EditText : RichTextLabel
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_gui_input(InputEvent @event)
	{
		if (@event is InputEventMouseButton eventKey) 
		{
			if (eventKey.ButtonIndex == MouseButton.Left && eventKey.Pressed)
			{
				GD.Print("Press!");
				DisplayServer.VirtualKeyboardShow("");
			}
		}
	}
}
