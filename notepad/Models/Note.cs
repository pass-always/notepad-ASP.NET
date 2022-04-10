namespace notepad.Models
{
    public class Note
    {
        //prop tab*2 you will get public int MyProperty {get; set;}
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public Note()
        {

        }
    }
}
