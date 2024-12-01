using Godot;
using System;

namespace Notepad.interfaces
{
	public partial interface iNotepadObject
	{
		public int Index { get; set; }

		public void UseObject();
    }
}
