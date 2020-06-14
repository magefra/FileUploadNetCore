using FileUploadNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadNetCore.Data
{


    /// <summary>
    /// Para guardar el archivo en la bd necesitamos el tipo de columna con mas long.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
    }
}
