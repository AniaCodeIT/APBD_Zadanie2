using LegacyApp;

namespace LegacyAppTest;

public class UserServiceTest
{
    [Fact]
    public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        var service = new UserService();

        bool result = service.AddUser("Jan", "Kowalski", "jan", new DateTime(1980, 1, 1), 1);
        
        Assert.Equal(false, result);
    }

    [Fact]
    public void AddUser_Should_Return_False_When_Missing_FirstName()
    {
        var service = new UserService();

        bool result = service.AddUser(null, "Kowalski", "jan@kowalski.com", new DateTime(1980, 1, 1), 1);
        
        Assert.Equal(false, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Younger_Than_21_Years_Old()
    {
        var service = new UserService();

        bool result = service.AddUser(null, "Kowalski", "jan@kowalski.com", new DateTime(2020, 1, 1), 1);
        
        Assert.Equal(false, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_True_When_Important_Client()
    {
        var service = new UserService();

        bool result = service.AddUser("Jan", "Kowalski", "jan@kowalski.com", new DateTime(1980, 1, 1), 4);
        
        Assert.Equal(true, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Normal_Client()
    {
        var service = new UserService();

        var result = service.AddUser("Jan", "Kowalski", "jan@kowalski.com", new DateTime(1980, 1, 1), 5);
        
        Assert.Equal(false, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_True_When_Very_Important_Client()
    {
        var service = new UserService();

        bool result = service.AddUser("Jan", "Kowalski", "jan@kowalski.com", new DateTime(1980, 1, 1), 2);
        
        Assert.Equal(true, result);
    }
    
    [Fact]
    public void AddUser_Should_Throw_Exception_When_User_Does_Not_Exist()
    {

    }
    
    [Fact]
    public void AddUser_Should_Throw_Exception_When_No_Credit_Limit_Exists_For_User()
    {
        
    }
    
    
}