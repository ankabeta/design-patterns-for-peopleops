using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    #region İnterface tanımlarımızı yapıyoruz. 

    public interface IPlayer
    {
        string GetTopScorer();
    }

    public interface ITeam          // Interface'leri amacı diğer classlara yön göstermektir. Bu yüzden Interface tanımları içerisinde kesinlikle kod bloğumuz bulunmaz.
                                    // Interface yapılar sadece tanımlamalardan ibarettir, içerisinde hiçbir yapıcı metod ekleyemeyiz.
    {
        string GetTeamColor();
    }

    public interface IFootballFactory
    {
        ITeam CreateTeam();
        IPlayer CreatePlayer();
    }

    #endregion

    #region IFootballFactory interface ini gerçekleyen ülke ve ülkelerin liglerini oluşturalım.
    public class TurkishLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Fenerbahce();
        }

        public IPlayer CreatePlayer()
        {
            return new TurkishligaPlayer();
        }
    }
    public class BundesLigaFactory : IFootballFactory 
    {
        public ITeam CreateTeam()
        {
            return new BorussiaDotmund();
        }

        public IPlayer CreatePlayer()
        {
            return new BundesligaPlayer();
        }
    }

    public class LaLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }

        public IPlayer CreatePlayer()
        {
            return new LaLigaPlayer();
        }
    }
    public class SerieAFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Juventus();
        }

        public IPlayer CreatePlayer()
        {
            return new SerieAPlayer();
        }
    }
    #endregion
    #region ITeam interface ini gerçekleyen takımları İçerisinde takıma ait renklerin string olarak döndüğü bir metot içeren halleriyle oluşturalım.
    public class Fenerbahce : ITeam
    {
        public string GetTeamColor()
        {
            return "Yellow and Navy blue";
        }
    }
    public class BorussiaDotmund : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and Yellow";
        }
    }
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue and White";
        }
    }
    #endregion
    #region IPlayer interface’ini gerçekleyen Player class larımızı oluşturalım.
    public class TurkishligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Mesut Özil";
        }
    }
    public class BundesligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Robert Lewandowski";
        }
    }
    public class LaLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Lionel Messi";
        }
    }
    public class SerieAPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Cristiano Ronaldo";
        }
    }
    #endregion
    #region Altyapıyı bu şekilde oluşturduk diyebiliriz. Şimdi client class ımızı oluşturalım. Adına FootballWorld diyoruz.
        public class FootballWorld
    {
        private readonly IPlayer _teamScorer;

        private readonly ITeam _team;
        public FootballWorld(IFootballFactory factory)
        {
            _team = factory.CreateTeam();
            _teamScorer = factory.CreatePlayer(); 
                                                    // Görüldüğü üzere client class ının ne herhangi bir ülkeyle ne de herhangi bir takımla bağlantısı mevcut.
        }                                          // Tamamen soyutlanmış durumda.Ben hangi ülkeyi kullanmak istersem o ülkenin takımına ait rengi ve futbolcuyu bana dönecektir.

        public string GetFootballTeamColor()
        {
            return _team.GetTeamColor();
        }
        public string GetTopScorer()
        {
            return _teamScorer.GetTopScorer();
        }
       
    }
    #endregion
    #region
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            string user1;

            IFootballFactory germany = new BundesLigaFactory();
            IFootballFactory spain = new LaLigaFactory();
            IFootballFactory italy = new SerieAFactory();
            IFootballFactory turkey = new TurkishLigaFactory();

            Console.WriteLine("Lütfen bilgi sahibi olmak istediğiniz takımın ülkesini giriniz.");
            Console.WriteLine("Germany for press G, Spain for press S, Italy for press I and Turkey for press T");
            user = Console.ReadLine();
            user1 = user.ToUpper();
            if (user1 == "G")
            {
                FootballWorld footballWorld1 = new FootballWorld(germany);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "S")
            {
                FootballWorld footballWorld1 = new FootballWorld(spain);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "I")
            {
                FootballWorld footballWorld1 = new FootballWorld(italy);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "T")
            {
                FootballWorld footballWorld1 = new FootballWorld(turkey);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else
            {
                Console.WriteLine("YANLIŞ BİR TIKLAMA YAPTINIZ! ");
            }

            Console.ReadLine();
        }
    }
    #endregion
}
