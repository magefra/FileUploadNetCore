# FileUploadNetCore
 Pequeña aplicación con la que pueda cargar archivos de cualquier tipo en una ubicación del sistema de archivos o en una tabla de base de datos centralizada.

# Instalar.
 ```
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.20

 ```
 
 # Empezar
 
 1. Agregar la cadena de conexión en el archivo appsetting.json
 ```
 "ConnectionStrings": {
  "DefaultConnection": "<Copia tu conexión aquí>"
}
```

2. Configurar el archivo Startup.cs
```
 services.AddDbContext<ApplicationDbContext>(options =>
            {
                options
                .UseMySQL(Configuration.GetConnectionString("DefaultConnection"),
                            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });
```

3. Hacer la migración y actualizar la base de datos.
```
add-migration Initial
update-database
```

