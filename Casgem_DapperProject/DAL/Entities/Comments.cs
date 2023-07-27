namespace Casgem_DapperProject.DAL.Entities
{
    public class Comments
    {
        public int CommentsID { get; set; }
        public string CommentsContent { get; set; }
        public string CommentsAuthor { get; set; }
        public bool CommentsStatus { get; set; }
        public DateTime CommentsDate { get; set; }
        public int CommentsHeading { get; set; }
    }
}
