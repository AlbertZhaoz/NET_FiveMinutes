using SqlSugar;

namespace NET_FiveMinutes_004_EncryptPlay.Models
{
    [SugarTable("T_UserInformation")]
    public class UserInformation
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
