
namespace UI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Description { get; set; }
        public string Datebirth { get; set; }
        public string BirthPlace { get; set; }
        public string NbView { get; set; }
        public string NbShare { get; set; }
        public string PP { get; set; }
        public string Couv { get; set; }

        public User()
        {
            Username = "Perceval";
            Description = "Perceval est un des Chevaliers de la Table Ronde. Il est l'un des chevaliers les plus fidèles au Roi Arthur et le considère comme un des être les plus chers. Alors qu'il est souvent traité d'imbécile, il est relativement intelligent par moments. Il est aussi extrêmement sensible aux gens qui l'aiment et qui l'entourent.";
            Datebirth = "4/12/1130";
            BirthPlace = "Listenois";
            NbView = "0";
            NbShare = "0";
            PP = "pedroaLaMer.jpg";
            Couv = "bull2.png";
        }
    }
}
