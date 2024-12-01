using Godot;
using System;
using Notepad.interfaces;
using System.Text.Json;

public partial class EditText : RichTextLabel, iNotepadObject
{
	[Export]
	public MainTextEdit mainTextEditObject;

	public int Index { get; set; }

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

		string json = Json.Stringify(this);
		GD.Print(json);

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
