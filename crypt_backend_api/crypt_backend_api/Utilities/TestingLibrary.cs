using crypt_backend_api.Classes;

namespace crypt_backend_api.Utilities
{
    public static class TestingLibrary
    {
        public static List<CryptoModel> GetTestingCryptoModelList()
        {
            Random rnd = new Random();
            return new List<CryptoModel>
            {
                new CryptoModel{id="66ff44", name="BTC", description="Bitcoin", price=GetRandomNumber(100000,110000)},
                new CryptoModel{id="66ff45", name="ETH", description="Ethereum", price=GetRandomNumber(3000,4000)},
                new CryptoModel{id="66ff46", name="XRP", description="XRP", price=GetRandomNumber(3,5)},
                new CryptoModel{id="66ff47", name="USDT", description="Tether", price=GetRandomNumber(1,4)},
                new CryptoModel{id="66ff48", name="SOL", description="Solana", price=GetRandomNumber(200,400)},
                new CryptoModel{id="66ff49", name="BNB", description="BNB", price=GetRandomNumber(600,700)},
                new CryptoModel{id="66ff50", name="DOGE", description="Dogecoin", price=GetRandomNumber(0.1,2)},
                new CryptoModel{id="66ff51", name="USDC", description="USDC", price=GetRandomNumber(0.1,0.5)},
                new CryptoModel{id="66ff52", name="ADA", description="Cardano", price=GetRandomNumber(0.9,1.5)},
                new CryptoModel{id="66ff53", name="TRX", description="TRON", price=GetRandomNumber(0.2,0.3)},
            };
        }
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
