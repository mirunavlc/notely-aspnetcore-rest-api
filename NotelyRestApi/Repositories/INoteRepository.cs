using System.Collections.Generic;
using NotelyRestApi.Models;

namespace NotelyRestApi.Repositories
{
    public interface INoteRepository
    {
        public Note FindNoteById(long id);

        public IEnumerable<Note> GetAllNotes();

        public void SaveNote(Note note);

        public void EditNote(Note note);

        public void DeleteNote(Note noteModel);
    }
}
