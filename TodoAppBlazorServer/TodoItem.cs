namespace TodoAppBlazorServer
{
    public class TodoItem  //Data class
    {
        public TodoItem(string text)  //Constructor
        {
            Text = text;
        }
        public string Text { get; set; } = String.Empty;
        public bool Completed { get; set; }  = false;
    }
}
