using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAccessApp;
using ShopAccessApp.BackEnd;

namespace ShopAccessUnitTests
{
    [TestClass]
    public class UserAccessTests
    {
        UserAccessor access;
        string testUsername;
        readonly users testUser;

        public UserAccessTests()
        {
            access = new UserAccessor();
            testUsername = "TestUser";
            testUser = new users()
            {
                username = testUsername,
                password = "test",
                access_level = 1
            };

            access.CreateNew(testUser);
        }

        ~UserAccessTests() => access.DeleteByUsername(testUsername);

        [TestMethod]
        public void SelectUserFromDataBaseTest()
        {
            Assert.AreEqual(testUser, access.GetByUsername(testUsername));
        }
    }
}
