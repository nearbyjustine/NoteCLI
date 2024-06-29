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
        public Note ViewNote(int id)
        {
            return notes.Single(n => n.Id == id);
        }
        public void RemoveNote(int id)
        {
            // TODO: Add try catch for when note does not exist.
            notes.Remove(this.ViewNote(id));
        }
        public void EditNote(int id, string title, string content)
        {
            Note note = this.ViewNote(id);
            note.Title = title;
            note.Content = content;
        }
    }
}
