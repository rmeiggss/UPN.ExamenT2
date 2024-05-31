using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Context
{
    public class StaticContext
    {
        public StaticContext() { }

        public static List<Duenho> pd_DuenhoData = new List<Duenho>()!;
        public static List<Mascota> pd_MascotaData = new List<Mascota>()!;
        public static List<Raza> pd_RazaData = new List<Raza>()
        {
            new Raza(1, "Pastor Aleman"),
            new Raza(2, "Bulldog"),
            new Raza(3, "Pitbull"),
            new Raza(4, "Chihuahua"),
            new Raza(5, "Labrador"),
            new Raza(6, "Golden Retriever"),
            new Raza(7, "Poodle"),
            new Raza(8, "Beagle"),
            new Raza(9, "Rottweiler"),
            new Raza(10, "Doberman"),
            new Raza(11, "Husky"),
            new Raza(12, "Dalmata"),
            new Raza(13, "Boxer"),
            new Raza(14, "Schnauzer"),
            new Raza(15, "Pug"),
            new Raza(16, "Shih Tzu"),
            new Raza(17, "Yorkshire Terrier"),
            new Raza(18, "Bichon Frise"),
            new Raza(19, "Maltese"),
            new Raza(20, "Cocker Spaniel"),
            new Raza(21, "Pomeranian"),
            new Raza(22, "Border Collie"),
            new Raza(23, "Basset Hound"),
            new Raza(24, "Great Dane"),
            new Raza(25, "Siberian Husky"),
            new Raza(26, "Chow Chow"),
            new Raza(27, "Shar Pei"),
            new Raza(28, "Akita"),
            new Raza(29, "Samoyed"),
            new Raza(30, "Alaskan Malamute"),
            new Raza(31, "Shiba Inu"),
            new Raza(32, "Pekingese"),
            new Raza(33, "Bull Terrier"),
            new Raza(34, "Staffordshire Bull Terrier"),
            new Raza(35, "English Bulldog"),
            new Raza(36, "French Bulldog"),
            new Raza(37, "American Bulldog"),
            new Raza(38, "Boston Terrier"),
            new Raza(39, "Cane Corso"),
            new Raza(40, "Mastiff")
        };
    }
}
