namespace dotnet_rpg.Data
{
    public static class Utility
    {
        //The last two parameters will be store in the database;
        //The out keyword causes arguments to be passed by reference. 
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        
    }
}