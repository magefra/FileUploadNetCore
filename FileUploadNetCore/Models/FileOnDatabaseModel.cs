using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileUploadNetCore.Models
{
    public class FileOnDatabaseModel : FileModel
    {

        
        public byte[] Data { get; set; }
    }
}
