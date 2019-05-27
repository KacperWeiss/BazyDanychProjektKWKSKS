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
        readonly graphics_cards testUser;

        public UserAccessTests()
        {
            access = new UserAccessor();
            testUsername = "TestUser";
            testUser = new graphics_cards()
            {
                username = testUsername,
                password = "test",
                access_level = 1
            };

            access.CreateNewUser(testUser);
        }

        ~UserAccessTests() => access.DeleteUserByUsername(testUsername);

        [TestMethod]
        public void SelectUserFromDataBaseTest()
        {
            Assert.AreEqual(testUser, access.GetUserByUsername(testUsername));
        }
    }
}