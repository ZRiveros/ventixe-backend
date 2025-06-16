using System.Text.Json;
using users_api.Models;

namespace users_api.Services;

public class UserService
{
    private readonly string _filePath = "users.json";
    private List<User> _users;

    public UserService()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            _users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
        else
        {
            _users = new List<User>();
        }

        // Lägg till defaultanvändare om den inte finns
        if (!_users.Any(u => u.Username == "test123"))
        {
            _users.Add(new User { Username = "test123", Password = "hejhej" });
            SaveUsers();
        }
    }

    public bool Register(User user)
    {
        if (_users.Any(u => u.Username == user.Username))
            return false;

        _users.Add(user);
        SaveUsers();
        return true;
    }

    public bool Authenticate(User user)
    {
        return _users.Any(u =>
            u.Username == user.Username &&
            u.Password == user.Password);
    }

    private void SaveUsers()
    {
        var json = JsonSerializer.Serialize(_users);
        File.WriteAllText(_filePath, json);
    }
}
