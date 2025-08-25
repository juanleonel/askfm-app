namespace askfm.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // // Si el comentario está relacionado con otra entidad (ej. Post, Product, etc.)
        // public int? PostId { get; set; }
        // public Post Post { get; set; }
    }
}