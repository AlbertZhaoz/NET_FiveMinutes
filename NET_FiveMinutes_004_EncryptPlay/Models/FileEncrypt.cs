using SqlSugar;

namespace NET_FiveMinutes_004_EncryptPlay.Models
{
    [SugarTable("T_FileEncrypt")]
    public class FileEncrypt
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string FileOrigin { get; set; }
        public string FileDesctionMd5 { get; set; }
        public string FileSaltKeyMd5 { get; set; }
    }
}
