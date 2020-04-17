namespace c_commandline.Models
{
    public class Command {
        // Entity framework core will automatically see this Id as the first field and assume it is PK
        public int Id {get; set;}
        public string HowTo {get; set;}
        public string Platform {get; set;}
        public string Commandline {get; set;}

    }
}