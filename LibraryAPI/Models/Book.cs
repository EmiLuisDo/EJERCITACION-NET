namespace Library.Models{
    public class Book{
        public int Id_Book { get; set; }
        public int id_Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Section { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
    }
}