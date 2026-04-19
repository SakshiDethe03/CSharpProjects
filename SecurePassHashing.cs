using System.Security.Cryptography;

var hash = BCrypt.Net.BCrypt.HashPassword("password");
bool ok = BCrypt.Net.BCrypt.Verify("password", hash);