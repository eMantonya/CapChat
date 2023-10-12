using UserLibrary;

namespace ClientTests
{
    [TestClass]
    public class UnitTest1
    {
        const int keySize = 64;
        byte[] salt = Enumerable.Repeat((byte)1, keySize).ToArray();
        CryptoHelper helper = new CryptoHelper();

        [TestMethod]
        public void TestHashing()
        {

            string expected = "B4CC6561E8F1AE876184A069933E139B08C9429BFB1729EFAAE7DC9EBC172990199546B0218B00998806041D5253DDE52CC803ECB088AF674A25A60BBA3222B1";
            string password = "password";

            var result = Convert.ToHexString(helper.ComputeHash(password, salt));

            Assert.AreEqual(expected, result);
        }

    }
}