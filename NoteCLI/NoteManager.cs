using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCLI
{
    internal class NoteManager
    {
        private List<Note> notes;
        public NoteManager() 
        {
            this.notes = new List<Note>();
        }

        public void AddNote(Note note)
        {
            // TODO: Add checking
            notes.Add(note);
        }
        public void RemoveNote(int id)
        {
            // TODO: Add try catch for when note does not exist.
            notes.Remove(notes.Single( n => n.Id == id));
        }

    }
}
